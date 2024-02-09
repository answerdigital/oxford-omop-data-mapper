using Newtonsoft.Json;
using OmopTransformer.Documentation.Charting;

namespace OmopTransformer.Documentation.JSONRendering;

public class JSONRenderer
{
    private readonly IReadOnlyCollection<Relationship> _relationships;
    private readonly string _origin;
    private readonly string _omopTable;

    public JSONRenderer(IReadOnlyCollection<Relationship> relationships, string origin, string omopTable)
    {
        _relationships = relationships;
        _origin = origin;
        _omopTable = omopTable;
    }

    public string Render()
    {
        var groupedRelationships = _relationships.GroupBy(r => r.Target);
        List<OMOPColumns> mappingObjects = new List<OMOPColumns>();

        foreach (var group in groupedRelationships)
        {
            OMOPColumns mappingObject = new OMOPColumns
            {
                Name = group.Key,
                SourceColumns = group.Select(r => r.Source).ToList()
            };

            mappingObjects.Add(mappingObject);
        }

        JSONStructure tableMapping = new JSONStructure
        {
            OmopTable = _omopTable,
            Origin =  _origin,
            OmopColumns = mappingObjects
        };

        var settings = new JsonSerializerSettings
        {
            ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver()
        };


        return JsonConvert.SerializeObject(tableMapping, Formatting.Indented, settings);
    }
}

