namespace OmopTransformer.Documentation.JSONRendering;

public class JSONStructure
{
    public string OmopTable { get; set; } = string.Empty;
    public string Origin { get; set; } = string.Empty;
    public List<OMOPColumns> OmopColumns { get; set; } = [];
}