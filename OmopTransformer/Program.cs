using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using CommandLine;
using OmopTransformer.CDS;
using OmopTransformer.CDS.Parser;
using OmopTransformer.CDS.Staging;
using OmopTransformer.Documentation;
using OmopTransformer.COSD;
using OmopTransformer.Transformation;
using OmopTransformer.COSD.Demographics;
using OmopTransformer.Omop.Location;
using OmopTransformer.SACT;
using OmopTransformer.SACT.Staging;
using OmopTransformer.COSD.Staging;

[assembly: InternalsVisibleTo("OmopTransformerTests")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2, PublicKey=0024000004800000940000000602000000240000525341310004000001000100c547cac37abd99c8db225ef2f6c8a3602f3b3606cc9891605d02baa56104f4cfc0734aa39b93bf7852f7d9266654753cc297e7d2edfe0bac1cdcf9f717241550e0a7b191195b7667bb4f64bcb8e2121380fd1d9d46ad2d92d2d15605093924cceaf74c4861eff62abf69b9291ed0a340e113be11e6a7d3113e92484cf7045cc7")]
namespace OmopTransformer;

internal class Program
{
    private static async Task ActionMustBeSpecifiedError() => await Console.Error.WriteLineAsync("Action flag must be specified.");
    private static async Task UnknownActionMustBeSpecifiedError(string actionName) => await Console.Error.WriteLineAsync($"Unknown action {actionName}.");

    private static async Task Main(string[] args)
    {
        var builder = Host.CreateApplicationBuilder(args);

        var result = Parser.Default.ParseArguments<StagingOptions, DocumentationOptions, TransformOptions>(args);

        if (result.Value == null)
        {
            return;
        }

        if (result.Value is DocumentationOptions generateDocumentation)
        {
            builder.Services.AddTransient(_ => generateDocumentation);
            builder.Services.AddHostedService<DocumentationGenerationHostedService>();
        }

        if (result.Value is StagingOptions stagingOptions)
        {
            builder.Services.AddTransient(_ => stagingOptions);

            if (string.Equals(stagingOptions.Type, "cosd", StringComparison.OrdinalIgnoreCase))
            {
                if (stagingOptions.Action == null)
                {
                    await ActionMustBeSpecifiedError();
                    return;
                }

                switch (stagingOptions.Action.ToLower())
                {
                    case "load":
                        builder.Services.AddTransient<ICosdStaging, CosdStaging>();
                        builder.Services.AddHostedService<CosdLoadStagingHostedService>();
                        break;
                    case "clear":
                        builder.Services.AddHostedService<SactClearStagingHostedService>();
                        break;
                    default:
                        await UnknownActionMustBeSpecifiedError(stagingOptions.Action);
                        return;
                }
            }
            else if (string.Equals(stagingOptions.Type, "sact", StringComparison.OrdinalIgnoreCase))
            {
                if (stagingOptions.Action == null)
                {
                    await ActionMustBeSpecifiedError();
                    return;
                }

                switch (stagingOptions.Action.ToLower())
                {
                    case "load":
                        builder.Services.AddTransient<ISactInserter, SactInserter>();
                        builder.Services.AddTransient<ISactStaging, SactStaging>();
                        builder.Services.AddHostedService<SactLoadStagingHostedService>();
                        break;
                    case "clear":
                        builder.Services.AddHostedService<SactClearStagingHostedService>();
                        break;
                    default:
                        await UnknownActionMustBeSpecifiedError(stagingOptions.Action);
                        return;
                }
            }
            else if (string.Equals(stagingOptions.Type, "cds", StringComparison.OrdinalIgnoreCase))
            {
                if (stagingOptions.Action == null)
                {
                    await ActionMustBeSpecifiedError();
                    return;
                }

                switch (stagingOptions.Action.ToLower())
                {
                    case "load":
                        builder.Services.AddTransient<ICdsNhs62Parser, CdsNhs62Parser>();
                        builder.Services.AddTransient<ICdsInserter, CdsInserter>();
                        builder.Services.AddTransient<ICdsStaging, CdsStaging>();
                        builder.Services.AddHostedService<CdsLoadStagingHostedService>();
                        break;
                    case "clear":
                        builder.Services.AddHostedService<CdsClearStagingHostedService>();
                        break;
                    default:
                        await UnknownActionMustBeSpecifiedError(stagingOptions.Action);
                        return;
                }
            }
            else
            {
                await Console.Error.WriteLineAsync("Unknown staging type {stagingOptions.Type}.");
                return;
            }
        }

        if (result.Value is TransformOptions transformOptions)
        {
            builder.Services.AddTransient(_ => transformOptions);

            builder.Services.AddTransient<ILocationRecorder, LocationRecorder>();

            if (string.Equals(transformOptions.Type, "cosd", StringComparison.OrdinalIgnoreCase))
            {
                builder.Services.AddTransient<CosdLocationTransformer>();
                builder.Services.AddHostedService<CosdTransformHostedService>();
            }
            else if (string.Equals(transformOptions.Type, "sact", StringComparison.OrdinalIgnoreCase))
            {
                builder.Services.AddTransient<SactLocationTransformer>();
                builder.Services.AddHostedService<SactTransformHostedService>();
            }
            else if (string.Equals(transformOptions.Type, "cds", StringComparison.OrdinalIgnoreCase))
            {
                builder.Services.AddTransient<CdsLocationTransformer>();
                builder.Services.AddHostedService<CdsTransformHostedService>();
            }
            else
            {
                await Console.Error.WriteLineAsync("Unknown transform type {stagingOptions.Type}.");
            }
        }

        builder.Services.AddTransient<IDocumentationWriter, DocumentationWriter>();
        builder.Services.AddTransient<IRecordTransformer, RecordTransformer>();
        builder.Services.AddTransient<IRecordProvider, RecordProvider>();
        builder.Services.AddTransient<ICosdStagingSchema, CosdStagingSchema>();
        builder.Services.AddTransient<ISactStagingSchema, SactStagingSchema>();
        builder.Services.AddTransient<ICdsStagingSchema, CdsStagingSchema>();

        var queryLocator = await QueryLocator.Create();
        builder.Services.AddSingleton<IQueryLocator, QueryLocator>(_ => queryLocator);

        IHostEnvironment env = builder.Environment;

        builder.Configuration
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true, true);

        builder.Services.Configure<Configuration>(builder.Configuration);

        using IHost host = builder.Build();

        await host.RunAsync();
    }
}

[Verb("stage", HelpText = "Handles staging operations.")]
public class StagingOptions
{
    [Value(0, MetaName = "action", Required = true, HelpText = "Action to be performed (e.g., load).")]
    public string? Action { get; set; }

    [Option('t', "type", Required = false, HelpText = "Type of the data source (e.g., cosd, sact).")]
    public string? Type { get; set; }

    [Value(1, MetaName = "filename", Required = false, HelpText = "Filename to be processed (e.g., file.zip).")]
    public string? FileName { get; set; }
}

[Verb("transform", HelpText = "Handles transformation operations.")]
public class TransformOptions
{
    [Option('t', "type", Required = true, HelpText = "Type of the transformation (e.g., omop).")]
    public string? Type { get; set; }

    [Option("dry-run", Required = false, Default = false, HelpText = "Run the transformation in dry-run mode.")]
    public bool DryRun { get; set; }
}

[Verb("docs", HelpText = "Documentation generation.")]
public class DocumentationOptions
{
    [Value(0, MetaName = "filename", Required = true, HelpText = "Target path for the generated documentation.")]
    public string? FilePath { get; set; }
}