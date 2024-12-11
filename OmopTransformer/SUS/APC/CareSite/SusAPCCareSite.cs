﻿using OmopTransformer.Annotations;
using OmopTransformer.Omop.CareSite;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.APC.CareSite;

internal class SusAPCCareSite : OmopCareSite<SusAPCCareSiteRecord>
{
    [CopyValue(nameof(Source.SiteCodeOfTreatmentAtEpisodeStartDate))]
    public override string? care_site_name { get; set; }

    [CopyValue(nameof(Source.MainSpecialtyCode))]
    public override string? place_of_service_source_value { get; set; }

    [Transform(typeof(NhsMainSpecialityCodeLookup), nameof(Source.MainSpecialtyCode))]
    public override int? place_of_service_concept_id { get; set; }
}