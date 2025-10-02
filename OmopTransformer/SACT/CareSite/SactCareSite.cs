using OmopTransformer.Annotations;
using OmopTransformer.Omop.CareSite;

namespace OmopTransformer.SACT.CareSite;

internal class SactCareSite : OmopCareSite<SactCareSiteRecord>
{
    [CopyValue(nameof(Source.Organisation_Identifier_Code_Of_Provider))]
    public override string? care_site_name { get; set; }
}