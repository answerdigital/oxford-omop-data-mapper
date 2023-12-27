using OmopTransformer.Annotations;
using OmopTransformer.Omop.Person;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD.Demographics;

internal class CosdPerson : OmopPerson<CosdDemographics>
{
    [CopyValue(nameof(Source.NhsNumber))]
    public override string? person_source_value { get; set; }

    [Transform(typeof(YearSelector), nameof(Source.DateOfBirth))]
    public override int? year_of_birth { get; set; }

    [Transform(typeof(MonthOfYearSelector), nameof(Source.DateOfBirth))]
    public override int? month_of_birth { get; set; }

    [Transform(typeof(DayOfMonthSelector), nameof(Source.DateOfBirth))]
    public override int? day_of_birth { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.DateOfBirth))]
    public override DateTime? birth_datetime { get; set; }

    [Transform(typeof(RaceConceptLookup), nameof(Source.EthnicCategory))]
    public override int? race_concept_id { get; set; }
        
    [CopyValue(nameof(Source.EthnicCategory))]
    public override string? race_source_value { get; set; }

    [Transform(typeof(RaceSourceConceptLookup), nameof(Source.EthnicCategory))]
    public override int? race_source_concept_id { get; set; }

    [ConstantValue(0, "Unknown concept")]
    public override int? ethnicity_concept_id { get; set; }
}