using System.Reflection;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.Documentation;

internal class DocumentationWriter : IDocumentationWriter
{
    private readonly DocumentationOptions _documentationOption;
    private readonly ILogger<DocumentationWriter> _logger;
    private readonly IQueryLocator _queryLocator;

    public DocumentationWriter(DocumentationOptions documentationOption, ILogger<DocumentationWriter> logger, IQueryLocator queryLocator)
    {
        _documentationOption = documentationOption;
        _logger = logger;
        _queryLocator = queryLocator;
    }

    public async Task WriteToPath(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Generating documentation.");

        if (_documentationOption.FilePath == null)
        {
            _logger.LogCritical("Path must be specified.");
            return;
        }

        Assembly currentAssembly = Assembly.GetExecutingAssembly();

        string documentation = new DocumentationRenderer(currentAssembly.GetTypes(), _queryLocator).Render();

        await File.WriteAllTextAsync(_documentationOption.FilePath, documentation, cancellationToken);
    }
}