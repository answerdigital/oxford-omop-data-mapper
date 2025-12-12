namespace OmopTransformer.ConceptResolution;

public class ConceptCodeMapRow
{
    public int source_concept_id { get; init; }
    public int? target_concept_id { get; init; }

    public string? source_domain_id { get; init; }
    public string? target_domain_id { get; init; }
    public byte mapped_from_standard { get; init; }
}