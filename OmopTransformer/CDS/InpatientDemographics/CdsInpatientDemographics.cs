using OmopTransformer.Annotations;

namespace OmopTransformer.CDS.InpatientDemographics
{
    [Description("CdsInpatientDemographics table")]
    internal class CdsInpatientDemographics
    {
        public DateTime? person_birth_date { get; set; }
        public string? person_current_gender { get; set; }
        public string? ethnic_category { get; set; }
    }
}
