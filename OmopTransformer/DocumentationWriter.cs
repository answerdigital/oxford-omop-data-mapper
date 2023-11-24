using System.Reflection;
using OmopTransformer.Transformation;

namespace OmopTransformer;

internal class DocumentationWriter : IDocumentationWriter
{
    private readonly GenerateDocumentationOption _documentationOption;

    public DocumentationWriter(GenerateDocumentationOption documentationOption)
    {
        _documentationOption = documentationOption;
    }

    public async Task WriteToPath(CancellationToken cancellationToken)
    {
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