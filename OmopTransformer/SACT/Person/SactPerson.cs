using OmopTransformer.Annotations;
using OmopTransformer.Omop.Person;
using OmopTransformer.Transformation;

namespace OmopTransformer.SACT.Person;

internal class SactPerson : OmopPerson<SactPersonRecord>
{
    [CopyValue(nameof(Source.NHS_Number))]
    public override string? person_source_value { get; set; }

    [Transform(typeof(YearSelector), nameof(Source.Date_Of_Birth))]
    public override int? year_of_birth { get; set; }

    [Transform(typeof(MonthOfYearSelector), nameof(Source.Date_Of_Birth))]
    public override int? month_of_birth { get; set; }

    [Transform(typeof(DayOfMonthSelector), nameof(Source.Date_Of_Birth))]
    public override int? day_of_birth { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Date_Of_Birth))]
    public override DateTime? birth_datetime { get; set; }

    [Description("Note: This is specific to US-based data mappings and is in regards to being “Hispanic “ and “Not Hispanic”. All our data is UK-based.")]
    [ConstantValue(0, "Unknown concept")]
    public override int? ethnicity_concept_id { get; set; }

    [Transform(typeof(NhsGenderLookup), nameof(Source.Person_Stated_Gender_Code))]
    public override int? gender_concept_id { get; set; }

    [CopyValue(nameof(Source.Person_Stated_Gender_Code))]
    public override string? gender_source_value { get; set; }
}