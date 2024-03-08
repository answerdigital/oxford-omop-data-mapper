using System.Text;
using OmopTransformer.Documentation.Charting;

namespace OmopTransformer.Documentation;

internal class MermaidRenderer(IEnumerable<Relationship> relationships)
{
    public string GetMarkdown()
    {
        var stringBuilder = new StringBuilder();

        foreach (var line in GetMermaidLines())
        {
            stringBuilder.AppendLine(line);
        }

        return stringBuilder.ToString();
    }

    private IEnumerable<string> GetMermaidLines()
    {
        yield return "```mermaid";
        yield return "%%{";
        yield return "  init: {";
        yield return "    'theme': 'base',";
        yield return "   'themeVariables': {";
        yield return "         'lineColor': '#Fff',";
        yield return "         'fontSize': '27px'";
        yield return "    }";
        yield return "  }";
        yield return "}%%";
        yield return "";
        yield return "block-beta";
        yield return "  columns 1";
        yield return "  block:container:1";

        int index = 0;

        foreach (var relationshipGroup in relationships.GroupBy(r => r.Target))
        {
            var groupName = ToMermaidName(relationshipGroup.Key);
            var groupNameContainer = groupName + "_container";
            var targetName = groupName + "_target_" + index;
            var labelName = groupName + "_label";

            yield return "    columns 1";
            yield return $"    block:{groupNameContainer}:1";
            yield return "        columns 4";
            yield return $"        block:{groupName}:1";
            yield return "        columns 1";

            foreach (var relationship in relationshipGroup)
            {
                string sourceName = ToMermaidName(relationship.Source) + "_" + index;

                string sourceLabel = AddBrEveryThirdWord(relationship.Source);

                yield return $"            {sourceName}[\"{sourceLabel}\"]";
                yield return $"            class {sourceName} sourceItem";
            }

            yield return "        end";
            yield return "        ";
            yield return "        space";
            yield return "        ";
            yield return $"        {groupName}-->{targetName}[\"{relationshipGroup.Key}\"]";
            yield return "";
            yield return $"        {labelName}([\"{AddBrEveryThirdWord(relationshipGroup.First().Label, false)}\"])";
            yield return "    end";

            yield return $"   class {groupNameContainer} container1";
            yield return $"   class {groupName} container1";
            yield return $"   class {targetName} targetItem";
            yield return $"   class {labelName} targetItem";

            index++;
        }

        yield return "   classDef container1 fill:#3E5EB2, color:#3E5EB2, stroke:#3E5EB2;";
        yield return "   classDef sourceItem fill:#3E5EB2, color:#fff, stroke:#fff;";
        yield return "   classDef targetItem fill:#fff, color:#3E5EB2, stroke:#fff;";
        yield return "end";
        yield return "```";
    }

    private static string ToMermaidName(string name) => name.Replace(" ", "_").Replace("(", "").Replace(")", "").ToLower();

    private static string AddBrEveryThirdWord(string text, bool reachTarget = true)
    {
        StringBuilder sb = new StringBuilder();
        string[] words = text.Split(' ');

        int target = 3;

        for (int i = 0; i < words.Length; i++)
        {
            sb.Append(words[i]);
            if ((i + 1) % 3 == 0 && i != words.Length - 1)
            {
                sb.Append("<br/> ");
                target--;
            }
            else if (i != words.Length - 1)
            {
                sb.Append(" ");
            }
        }

        if (reachTarget && target > 0)
        {
            for (int i = 0; i < target; i++)
            {
                sb.Append("<br/> ");
            }
        }
        

        return sb.ToString();
    }
}
