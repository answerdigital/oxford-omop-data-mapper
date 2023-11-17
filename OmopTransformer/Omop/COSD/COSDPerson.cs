using OmopTransformer.Annotations;
using OmopTransformer.COSD;

namespace OmopTransformer.Omop.COSD;

internal class COSDPerson : OmopPerson<CNSRecord>
{
    [CopyValue("NhsNumber")]
    public override string person_source_value { get; set; }
}