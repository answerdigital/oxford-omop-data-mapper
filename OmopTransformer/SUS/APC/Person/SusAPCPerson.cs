using OmopTransformer.Annotations;
using OmopTransformer.Omop.Person;

namespace OmopTransformer.SUS.APC;

internal class SusAPCPerson : OmopPerson<SusAPCPersonRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? person_source_value { get; set; }
}