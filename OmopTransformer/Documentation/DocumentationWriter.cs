using System.Reflection;
using Microsoft.Extensions.Logging;
using OmopTransformer.Transformation;

namespace OmopTransformer.Documentation;

internal class DocumentationWriter : IDocumentationWriter
{
    private readonly DocumentationOptions _documentationOption;
    private readonly ILogger<DocumentationWriter> _logger;

    public DocumentationWriter(DocumentationOptions documentationOption, ILogger<DocumentationWriter> logger)
    {
        _documentationOption = documentationOption;
        _logger = logger;
    }

    public async Task WriteToPath(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Generating documentation.");

        if (_documentationOption.FilePath == null)
        {
            _logger.LogCritical("Path must be specified.");
            return;
        }

        string runningDirectory = AppDomain.CurrentDomain.BaseDirectory;

        string[] queryFilePaths = Directory.GetFiles(runningDirectory, "*.xml", SearchOption.AllDirectories);

        var queryFiles =
            queryFilePaths
                .Select(async path =>
                    new
                    {
                        Path = path,
                        Text = await File.ReadAllTextAsync(path, cancellationToken)
                    })
                .ToList();

        await Task.WhenAll(queryFiles);

        var aggregateQueries =
            queryFiles
                .ToDictionary(
                    keySelector: query => Path.GetFileName(query.Result.Path),
                    elementSelector: query => AggregateQueryParser.ParseAggregateQuery(query.Result.Text));

        Assembly currentAssembly = Assembly.GetExecutingAssembly();

        string documentation = new DocumentationRenderer(currentAssembly.GetTypes(), aggregateQueries).Render();

        await File.WriteAllTextAsync(_documentationOption.FilePath, documentation, cancellationToken);
    }
}