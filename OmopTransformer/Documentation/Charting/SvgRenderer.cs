using System.Xml.Linq;

namespace OmopTransformer.Documentation.Charting;

public class SvgRenderer
{
    private readonly IReadOnlyCollection<Relationship> _relationships;

    private static readonly XNamespace SvgNamespace = "http://www.w3.org/2000/svg";
    private const int BoxWidth = 400;
    private const int BoxHeight = 50;
    private const int Padding = 20;

    public SvgRenderer(IReadOnlyCollection<Relationship> relationships)
    {
        _relationships = relationships;
    }

    public string Render()
    {
        var sourceBoxesByTargetBoxes = _relationships.GroupBy(r => r.Target);
        var width = GetBoxX(sourceBoxesByTargetBoxes.Count()) + 50;

        XElement svg =
        new XElement(
            SvgNamespace + "svg",
            new XAttribute("xmlns", SvgNamespace),
            new XAttribute("width", width),
            new XAttribute("height", "800"),
            new XElement(
                SvgNamespace + "rect",
                new XAttribute("width", "100%"),
                new XAttribute("height", "100%"),
                new XAttribute("fill", "#3E5EB2")),
            DrawRelationships (sourceBoxesByTargetBoxes)
        );   

        return svg.ToString();
    }

    private static IEnumerable<XElement> DrawRelationships (IEnumerable<IGrouping<string, Relationship>> relationships)
    {
        var boxes = new List<XElement>();
        int index = 0;

        foreach (var relationshipGroup in relationships)
        {
            boxes.AddRange(DrawRelationshipSource(index, relationshipGroup));
            boxes.Add(DrawLine(relationshipGroup.First(), index));
            boxes.Add(CreateBoxElement(
                x: GetBoxX(index),
                y: 620,
                width: BoxWidth,
                height: 80,
                label: relationshipGroup.Key,
                fillColor: "white",
                textColour: "#3E5EB2",
                roundCorners: true)
            );

            index++;
        }

        return boxes;
    }

    private static IEnumerable<XElement> DrawRelationshipSource(int index, IEnumerable<Relationship> relationships)
    {
        int sourceIndex = 0;

        foreach (var relationship in relationships)
        {
            var height = 400;
            var count = relationships.Count();
            var margin = 20;

            yield return
                CreateBoxElement(
                    x: GetBoxX(index),
                    y: GetSourceTopY(height, count, margin, sourceIndex) + Padding,
                    width: BoxWidth,
                    height: GetSourceBoxHeight(height, count, margin),
                    label: relationship.Source,
                    fillColor: "#3E5EB2",
                    textColour: "white",
                    roundCorners: false
               );

            sourceIndex++;
        }
    }

    private static XElement DrawLine(Relationship relationship, int index)
    {
        int box1X = GetBoxX(index);

        int arrowX = box1X + BoxWidth / 2 + Padding;

        int arrowStartY = 420;
        int arrowEndY = arrowStartY + 195;

        return
            new XElement(
                SvgNamespace + "g",
                new XElement(
                    SvgNamespace + "line",
                    new XAttribute("x1", arrowX),
                    new XAttribute("y1", arrowStartY),
                    new XAttribute("x2", arrowX),
                    new XAttribute("y2", arrowEndY),
                    new XAttribute("stroke", "white"),
                    new XAttribute("stroke-width", "2")),
                new XElement(
                    SvgNamespace + "line",
                    new XAttribute("x1", arrowX - 10),
                    new XAttribute("y1", arrowEndY - 10),
                    new XAttribute("x2", arrowX),
                    new XAttribute("y2", arrowEndY),
                    new XAttribute("stroke", "white"),
                    new XAttribute("stroke-width", "2")),
                new XElement(
                    SvgNamespace + "line",
                    new XAttribute("x1", arrowX + 10),
                    new XAttribute("y1", arrowEndY - 10),
                    new XAttribute("x2", arrowX),
                    new XAttribute("y2", arrowEndY),
                    new XAttribute("stroke", "white"),
                    new XAttribute("stroke-width", "2")),
                WrapLabelText(arrowX - 130, BoxHeight + 660, 18, relationship.Label)
            );
    }

    private static int GetBoxX(int index) => index * (BoxWidth + 20) + 5;

    private static int GetSourceBoxHeight(int height, int count, int margin)
    {
        return (height - (margin * (count - 1))) / count;
    }

    private static int GetSourceTopY(int height, int count, int margin, int index)
    {
        return (GetSourceBoxHeight(height, count, margin) + margin) * index;
    }

    private static XElement CreateBoxElement(int x, int y, int width, int height, string fillColor, string label, string textColour, bool roundCorners) =>
        new(
            SvgNamespace + "g",
            new XElement(SvgNamespace + "rect",
                new XAttribute("x", x + Padding),
                new XAttribute("y", y),
                new XAttribute("width", width),
                new XAttribute("height", height),
                new XAttribute("fill", fillColor),
                new XAttribute("stroke", "white"),
                new XAttribute("stroke-width", "2"),
                roundCorners ? new XAttribute("rx", "10") : null
            ),
            new XElement(SvgNamespace + "text",
                new XAttribute("x", x + 30),
                new XAttribute("y", y + height / 2 + 5),
                new XAttribute("fill", textColour),
                new XAttribute("font-family", "Helvetica"),
                new XAttribute("font-size", "1.2em"),
                new XAttribute("text-anchor", "start"),
                label));

    private static IEnumerable<XElement> WrapLabelText(int x, int y, int lineHeight, string label)
    {
        string[] words = label.Split(' ');

        // Calculate the number of segments
        int numSegments = (int)Math.Ceiling((double)words.Length / 5);

        string[] result = new string[numSegments];

        for (int i = 0; i < numSegments; i++)
        {
            result[i] = string.Join(" ", words.Skip(i * 5).Take(5));

            yield return new XElement(SvgNamespace + "text",
                new XAttribute("x", x + 5),
                new XAttribute("y", y + (i + 1) * lineHeight),
                new XAttribute("fill", "white"),
                new XAttribute("font-size", "1em"),
                new XAttribute("font-family", "Helvetica"),
                result[i]);
        }
    }
}