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

    private IReadOnlyCollection<Box> FilteredSourceBoxes => FilerBoxes(_sourceBoxes, relationship => relationship.Source);
    private IReadOnlyCollection<Box> FilteredTargetBoxes => FilerBoxes(_targetBoxes, relationship => relationship.Target);

    private IReadOnlyCollection<Box> FilerBoxes(IEnumerable<Box> boxes, Func<Relationship, string> filter) =>
        boxes
            .Where(
                box => 
                    _relationships
                        .Any(relationship => filter(relationship) == box.Name))
            .ToList();

    public string Render()
    {
        var height = GetBoxY(Math.Max(FilteredSourceBoxes.Count, FilteredTargetBoxes.Count)) + BoxHeight;

        XElement svg =
            new XElement(
                SvgNamespace + "svg",
                new XAttribute("xmlns", SvgNamespace),
                new XAttribute("width", "1500"),
                new XAttribute("height", height),
                new XElement(
                    SvgNamespace + "rect",
                    new XAttribute("width", "100%"),
                    new XAttribute("height", "100%"),
                    new XAttribute("fill", "white")),
                DrawBoxes(FilteredSourceBoxes, 10, "#fab10c", "black"),
                DrawBoxes(FilteredTargetBoxes, 400, "#3c4459", "white"),
                DrawLines());   

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
        int targetIndex = GetBoxIndex(FilteredTargetBoxes, relationship.Target);
            
        int box1Y = GetBoxY(sourceIndex);

        int box2X = 400;

        int arrowStartX = BoxWidth + 10;
        int arrowStartY = box1Y + BoxHeight / 2;

        int arrowEndX = box2X;
        int arrowEndY = GetBoxY(targetIndex) + BoxHeight / 2;

        return 
            new XElement(
                SvgNamespace + "g",
                new XElement(
                    SvgNamespace + "line",
                    new XAttribute("x1", arrowStartX),
                    new XAttribute("y1", arrowStartY),
                    new XAttribute("x2", arrowEndX),
                    new XAttribute("y2", arrowEndY),
                    new XAttribute("stroke", GetLineColour(index)),
                    new XAttribute("stroke-width", "2")),
                new XElement(
                    SvgNamespace + "text",
                    new XAttribute("x", BoxWidth + 410),
                    new XAttribute("y", arrowEndY + 5),
                    new XAttribute("fill", "black"),
                    new XAttribute("font-family", "Helvetica"),
                    new XAttribute("text-anchor", "start"),
                    relationship.Label));
    }

    private static int GetBoxY(int index) => index * 100 + 10;

    private static IEnumerable<XElement> DrawBoxes(IEnumerable<Box> boxes, int x, string colour, string textColour) =>
        boxes
            .Select(
                (box, index) =>
                    CreateBoxElement(
                        x: x,
                        y: GetBoxY(index),
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
                new XAttribute("stroke", "black"),
                new XAttribute("rx", 10)
            ),
            new XElement(SvgNamespace + "text",
                new XAttribute("x", x + 10),
                new XAttribute("y", y + height / 2 + 5),
                new XAttribute("fill", textColour),
                new XAttribute("font-family", "Helvetica"),
                new XAttribute("text-anchor", "start"),
                label));
}