using System.Collections.Generic;
using System.Xml.Linq;

namespace OmopTransformer.Documentation.Charting;

public class SvgRenderer
{
    private readonly IReadOnlyCollection<Box> _sourceBoxes;
    private readonly IReadOnlyCollection<Box> _targetBoxes;
    private readonly IReadOnlyCollection<Relationship> _relationships;

    private static readonly XNamespace SvgNamespace = "http://www.w3.org/2000/svg";
    private const int BoxWidth = 250;
    private const int BoxHeight = 50;

    public SvgRenderer(IReadOnlyCollection<Box> sourceBoxes, IReadOnlyCollection<Box> targetBoxes, IReadOnlyCollection<Relationship> relationships)
    {
        _sourceBoxes = sourceBoxes;
        _targetBoxes = targetBoxes;
        _relationships = relationships;
    }

    private IReadOnlyCollection<Box> FilteredSourceBoxes => FilterBoxes(_sourceBoxes, relationship => relationship.Source);
    private IReadOnlyCollection<Box> FilteredTargetBoxes => FilterBoxes(_targetBoxes, relationship => relationship.Target);

    private IReadOnlyCollection<Box> FilterBoxes(IEnumerable<Box> boxes, Func<Relationship, string> filter) =>
        boxes
            .Where(
                box =>
                    _relationships
                        .Any(relationship => filter(relationship) == box.Name))
            .ToList();

    static Dictionary<string, List<Box>> GroupSourcesByTarget(List<Box> sources, List<Relationship> relationships)
    {
        // Group relationships by target
        var groupedSources = relationships
            .GroupBy(r => r.Target)
            .ToDictionary(
                group => group.Key,
                group => group.Join(sources, r => r.Source, s => s.Name, (r, s) => s).ToList()
            );

        return groupedSources;
    }

    public string Render()
    {
        var width = GetBoxX(Math.Max(FilteredSourceBoxes.Count, FilteredTargetBoxes.Count)) + BoxWidth;

        XElement svg =
        new XElement(
            SvgNamespace + "svg",
            new XAttribute("xmlns", SvgNamespace),
            new XAttribute("width", width),
            new XAttribute("height", "1500"),
            new XElement(
                SvgNamespace + "rect",
                new XAttribute("width", "100%"),
                new XAttribute("height", "100%"),
                new XAttribute("fill", "#005EB8")),
            DrawBoxes(FilteredSourceBoxes, 10, "#005EB8", "white"),
            DrawBoxes(FilteredTargetBoxes, 400, "white", "#005EB8"),
            DrawLines()
        );   

        return svg.ToString();
    }

    private static string GetLineColour(int index)
    {
        int range = index % 3;

        return range switch
        {
            0 => "#000000",
            1 => "#b0a9af",
            2 => "#3c445a",
            _ => throw new InvalidOperationException()
        };
    }

    private IEnumerable<XElement> DrawLines() =>
        _relationships
            .Select(DrawLine);

    private static int GetBoxIndex(IEnumerable<Box> boxes, string name) =>
        boxes
            .Select((source, index) => new { source, index })
            .Single(box => box.source.Name == name)
            .index;

    private XElement DrawLine(Relationship relationship, int index)
    {
        int sourceIndex = GetBoxIndex(FilteredSourceBoxes, relationship.Source);

        int box1X = GetBoxX(sourceIndex);
        int box2Y = 70;

        int arrowStartX = box1X + BoxWidth / 2;
        int arrowStartY = BoxHeight + 10;

        int arrowEndX = box1X + BoxWidth / 2;
        int arrowEndY = box2Y + 330;

        return
            new XElement(
                SvgNamespace + "g",
                new XElement(
                    SvgNamespace + "line",
                    new XAttribute("x1", arrowStartX),
                    new XAttribute("y1", arrowStartY),
                    new XAttribute("x2", arrowEndX),
                    new XAttribute("y2", arrowEndY),
                    new XAttribute("stroke", "white"),
                    new XAttribute("stroke-width", "2")));
                //new XElement(
                //    SvgNamespace + "text",
                //    new XAttribute("x", arrowEndX - 120),
                //    new XAttribute("y", BoxHeight + 420),
                //    new XAttribute("fill", "white"),
                //    new XAttribute("font-family", "Helvetica"),
                //    new XAttribute("text-anchor", "start"),
                //    relationship.Label));
    }

    private static int GetBoxX(int index) => index * 270 + 5;

    private static IEnumerable<XElement> DrawBoxes(IEnumerable<Box> boxes, int x, string colour, string textColour) =>
        boxes
            .Select(
                (box, index) =>
                    CreateBoxElement(
                        x: GetBoxX(index),
                        y: x,
                        width: BoxWidth,
                        height: BoxHeight,
                        label: box.Name,
                        fillColor: colour,
                        textColour: textColour,
                        hyperlink: box.Hyperlink));

    private static XElement CreateBoxElement(int x, int y, int width, int height, string fillColor, string label, string textColour, string? hyperlink) =>
        new(
            SvgNamespace + "a",
            hyperlink == null ? null : new XAttribute("href", hyperlink),
            new XElement(SvgNamespace + "rect",
                new XAttribute("x", x),
                new XAttribute("y", y),
                new XAttribute("width", width),
                new XAttribute("height", height),
                new XAttribute("fill", fillColor),
                new XAttribute("stroke", "white"),
                new XAttribute("stroke-width", "2")
            ),
            new XElement(SvgNamespace + "text",
                new XAttribute("x", x + 10),
                new XAttribute("y", y + height / 2 + 5),
                new XAttribute("fill", textColour),
                new XAttribute("font-family", "Helvetica"),
                new XAttribute("text-anchor", "start"),
                label));
}