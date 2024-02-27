using System.Reflection;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.Documentation;

internal class DocumentationWriter : IDocumentationWriter
{
    private readonly DocumentationOptions _documentationOption;
    private readonly ILogger<DocumentationWriter> _logger;
    private readonly IQueryLocator _queryLocator;
    private readonly DataDictionaryUrlResolver _dataDictionaryUrlResolver;

    public DocumentationWriter(DocumentationOptions documentationOption, ILogger<DocumentationWriter> logger, IQueryLocator queryLocator, DataDictionaryUrlResolver dataDictionaryUrlResolver)
    {
        _documentationOption = documentationOption;
        _logger = logger;
        _queryLocator = queryLocator;
        _dataDictionaryUrlResolver = dataDictionaryUrlResolver;
    }

    public async Task WriteToPath(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Generating documentation.");

        if (_documentationOption.DirectoryPath == null)
        {
            _logger.LogCritical("Directory must be specified.");
            return;
        }

        Assembly currentAssembly = Assembly.GetExecutingAssembly();

        var documentation = new DocumentationRenderer(currentAssembly.GetTypes(), _queryLocator, _logger, _dataDictionaryUrlResolver).Render();

        foreach (Document document in documentation)
        {
            await File.WriteAllTextAsync(Path.Combine(_documentationOption.DirectoryPath, document.FileName), document.Contents, cancellationToken);
        }
    }
}