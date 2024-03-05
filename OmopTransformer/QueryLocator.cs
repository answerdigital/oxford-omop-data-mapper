using OmopTransformer.Transformation;

namespace OmopTransformer;

internal class QueryLocator : IQueryLocator
{
    public QueryLocator(Dictionary<string, Query> queries)
    {
        Queries = queries ?? throw new ArgumentNullException(nameof(queries));
    }

    public Dictionary<string, Query> Queries { get; }

    public Query GetQuery(string queryName) => Queries[queryName];

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
                .Select(
                    file =>
                        new
                        {
                            key = file.Result.fileName,
                            query = AggregateQueryParser.ParseAggregateQuery(file.Result.content, file.Result.fileName)
                        })
                .Where(query => query.query != null)
                .ToDictionary(
                    keySelector: file => file.key,
                    elementSelector: file => file.query!);

        return new QueryLocator(fileDictionary);
    }
}