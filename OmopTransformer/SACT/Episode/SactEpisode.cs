using OmopTransformer.Annotations;
using OmopTransformer.Transformation;
using OmopTransformer.Omop.Episode;

namespace OmopTransformer.SACT.Episode
{
    internal class SactEpisode : OmopEpisode<SactEpisodeRecord>
    {
        [CopyValue(nameof(Source.NHS_Number))]
        public override string? nhs_number { get; set; }

        [ConstantValue(32531, "Treatment Regimen")]
        public override int? episode_concept_id { get; set; }

        [Transform(typeof(DateConverter), (nameof(Source.Start_Date_Of_Regimen)))]
        public override DateOnly? episode_start_date { get; set; }

        [CopyValue(nameof(Source.Regimen))]
        public override string? episode_source_value { get; set; }

        [ConstantValue(32818, "EHR Administration record")]
        public override int? episode_type_concept_id { get; set; }

        [Transform(typeof(EpisodeRegimenLookup), nameof(Source.Regimen))]
        public override int? episode_object_concept_id { get; set; }
    }
}