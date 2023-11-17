using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("OmopTransformerTests")]

namespace OmopTransformer;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        string documentation = DocumentationRenderer.Render();

        File.WriteAllText("readme.md", documentation);
    }
}