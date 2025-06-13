using OmopTransformer.Annotations;
using OmopTransformer.Omop.Person;
using OmopTransformer.Transformation;

namespace OmopTransformer.OxfordGP.Person;

internal class OxfordGPPerson : OmopPerson<OxfordGPPersonRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? person_source_value { get; set; }

    [Transform(typeof(YearSelector), nameof(Source.DOB))]
    public override int? year_of_birth { get; set; }

    [Transform(typeof(MonthOfYearSelector), nameof(Source.DOB))]
    public override int? month_of_birth { get; set; }

    [Transform(typeof(DayOfMonthSelector), nameof(Source.DOB))]
    public override int? day_of_birth { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.DOB))]
    public override DateTime? birth_datetime { get; set; }

    [Description("Note: This is specific to US-based data mappings and is in regards to being “Hispanic “ and “Not Hispanic”. All our data is UK-based.")]
    [ConstantValue(0, "Unknown concept")]
    public override int? ethnicity_concept_id { get; set; }
}