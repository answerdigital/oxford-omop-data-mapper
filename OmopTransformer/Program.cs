using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using CommandLine;
using OmopTransformer.Documentation;
using OmopTransformer.COSD;

[assembly: InternalsVisibleTo("OmopTransformerTests")]

namespace OmopTransformer;

internal class Program
{
    private static async Task Main(string[] args)
    {
        HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

        var result = Parser.Default.ParseArguments<StagingOptions, DocumentationOptions>(args);

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
                builder.Services.AddTransient<ICosdStagingSchema, CosdStagingSchema>();

                if (stagingOptions.Action == null)
                {
                    return;
                }

                switch (stagingOptions.Action.ToLower())
                {
                    case "load":
                        builder.Services.AddTransient<ICosdStaging, CosdStaging>();
                        builder.Services.AddHostedService<LoadStagingHostedService>();
                        break;
                    case "clear":
                        builder.Services.AddHostedService<ClearStagingHostedService>();
                        break;
                    default:
                        return;
                }
            }
            else
            {
                return;
            }
        }

        builder.Services.AddTransient<IDocumentationWriter, DocumentationWriter>();

        IHostEnvironment env = builder.Environment;

        builder.Configuration
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true, true);

        builder.Services.Configure<Configuration>(builder.Configuration);

        using IHost host = builder.Build();

        await host.RunAsync();
    }
}

[Verb("staging", HelpText = "Handles staging operations.")]
public class StagingOptions
{
    [Value(0, MetaName = "action", Required = true, HelpText = "Action to be performed (e.g., load).")]
    public string? Action { get; set; }

    [Option('t', "type", Required = false, HelpText = "Type of the operation (e.g., cosd).")]
    public string? Type { get; set; }

    [Value(1, MetaName = "filename", Required = false, HelpText = "Filename to be processed (e.g., file.zip).")]
    public string? FileName { get; set; }
}

[Verb("docs", HelpText = "Documentation generation.")]
public class DocumentationOptions
{
    [Value(0, MetaName = "filename", Required = true, HelpText = "Target path for the generated documentation.")]
    public string? FilePath { get; set; }
}