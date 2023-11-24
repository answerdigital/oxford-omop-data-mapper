using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using CommandLine;

[assembly: InternalsVisibleTo("OmopTransformerTests")]

namespace OmopTransformer;

internal class Program
{
    private static async Task Main(string[] args)
    {
        HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

        var result = Parser.Default.ParseArguments<GenerateDocumentationOption, MigrateOption>(args);

        if (result.Value == null)
        {
            return;
        }

        if (result.Value is GenerateDocumentationOption generateDocumentation)
        {
            builder.Services.AddTransient(_ => generateDocumentation);
            builder.Services.AddHostedService<DocumentationGenerationHostedService>();
        }

        builder.Services.AddTransient<IDocumentationWriter, DocumentationWriter>();

        IHostEnvironment env = builder.Environment;

        builder.Configuration
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true, true);

        builder.Services.Configure<Configuration>(builder.Configuration);

        using IHost host = builder.Build();

        await host.RunAsync();
    }
}

[Verb("docs", HelpText = "Documentation generation")]
public class GenerateDocumentationOption
{
    [Option('f', "file-path", Required = true, HelpText = "Target path for the generated documentation.")]
    public string FilePath { get; set; }
}

[Verb("migrate", HelpText = "Data migration")]
public class MigrateOption
{
    [Option('d', "dry-run", Required = false, HelpText = "Dry run. Does not record to OMOP database.")]
    public bool DryRun { get; set; }
}