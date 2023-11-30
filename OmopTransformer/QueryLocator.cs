using OmopTransformer.Transformation;

namespace OmopTransformer;

internal class QueryLocator : IQueryLocator
{
    private readonly Dictionary<string, Query> _queries;

    public QueryLocator(Dictionary<string, Query> queries)
    {
        _queries = queries ?? throw new ArgumentNullException(nameof(queries));
    }

    public Query GetQuery(string queryName) => _queries[queryName];

    public static async Task<QueryLocator> Create()
    {
        string runningDirectory = AppDomain.CurrentDomain.BaseDirectory;

        string[] queryFilePaths = Directory.GetFiles(runningDirectory, "*.xml", SearchOption.AllDirectories);

        var fileLoadTasks =
            queryFilePaths
                .Select(async
                    path =>
                    new
                    {
                        path,
                        content = await File.ReadAllTextAsync(path),
                        fileName = Path.GetFileName(path)
                    })
                .ToList();

        await Task.WhenAll(fileLoadTasks);

        var fileDictionary =
            fileLoadTasks
                .GroupBy(file => file.Result.fileName)
                .Select(files => files.First())
                .ToDictionary(
                    keySelector: file => file.Result.fileName,
                    elementSelector: file => AggregateQueryParser.ParseAggregateQuery(file.Result.content));

        return new QueryLocator(fileDictionary);
    }
}