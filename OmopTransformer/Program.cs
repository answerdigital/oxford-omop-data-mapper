using System.Reflection;
using System.Runtime.CompilerServices;
using OmopTransformer.Transformation;

[assembly: InternalsVisibleTo("OmopTransformerTests")]

namespace OmopTransformer;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        string runningDirectory = AppDomain.CurrentDomain.BaseDirectory;

        string[] queryFilePaths = Directory.GetFiles(runningDirectory, "*.xml", SearchOption.AllDirectories);

        var aggregateQueries =
            queryFilePaths
                .ToDictionary(
                    keySelector: Path.GetFileName,
                    elementSelector: path => AggregateQueryParser.ParseAggregateQuery(File.ReadAllText(path)));

        Assembly currentAssembly = Assembly.GetExecutingAssembly();

        string documentation = new DocumentationRenderer(currentAssembly.GetTypes(), aggregateQueries).Render();

        File.WriteAllText("readme.md", documentation);
    }
}