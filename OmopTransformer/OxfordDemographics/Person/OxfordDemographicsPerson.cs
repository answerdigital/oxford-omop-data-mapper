using OmopTransformer.Annotations;
using OmopTransformer.Omop.Person;
using OmopTransformer.Transformation;

namespace OmopTransformer.OxfordDemographics.Person;

internal class OxfordDemographicsPerson : OmopPerson<OxfordDemographicsPersonRecord>
{
    [CopyValue(nameof(Source.nhs_number))]
    public override string? person_source_value { get; set; }

    [Transform(typeof(DatabricksGenderLookup), nameof(Source.sex))]
    public override int? gender_concept_id { get; set; }

    [Transform(typeof(YearSelector), nameof(Source.date_of_birth))]
    public override int? year_of_birth { get; set; }

    [Transform(typeof(MonthOfYearSelector), nameof(Source.date_of_birth))]
    public override int? month_of_birth { get; set; }

    [Transform(typeof(DayOfMonthSelector), nameof(Source.date_of_birth))]
    public override int? day_of_birth { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.date_of_birth))]
    public override DateTime? birth_datetime { get; set; }

    [Transform(typeof(DatabricksEthnicityLookup), nameof(Source.ethnic_group))]
    public override int? race_concept_id { get; set; }

    [CopyValue(nameof(Source.sex))]
    public override string? gender_source_value { get; set; }

    [CopyValue(nameof(Source.ethnic_group))]
    public override string? race_source_value { get; set; }

    [Description("OMOP ethnicity represents Hispanic or non-Hispanic ethnicity. UK ethnic groups are mapped to race instead.")]
    [ConstantValue(0, "Unknown concept")]
    public override int? ethnicity_concept_id { get; set; }
}
