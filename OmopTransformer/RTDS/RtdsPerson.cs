﻿using OmopTransformer.Annotations;
using OmopTransformer.Omop.Person;
using OmopTransformer.RTDS.Demographics;
using OmopTransformer.Transformation;

namespace OmopTransformer.RTDS;

internal class RtdsPerson : OmopPerson<RtdsDemographics>
{
    [CopyValue(nameof(Source.PatientId))]
    public override string? person_source_value { get; set; }

    [Transform(typeof(YearSelector), nameof(Source.DateOfBirth))]
    public override int? year_of_birth { get; set; }

    [Transform(typeof(MonthOfYearSelector), nameof(Source.DateOfBirth))]
    public override int? month_of_birth { get; set; }

    [Transform(typeof(DayOfMonthSelector), nameof(Source.DateOfBirth))]
    public override int? day_of_birth { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.DateOfBirth))]
    public override DateTime? birth_datetime { get; set; }

    [ConstantValue(0, "Unknown concept")]
    public override int? ethnicity_concept_id { get; set; }

    [Transform(typeof(GenderLookup), nameof(Source.Sex))]
    public override int? gender_concept_id { get; set; }
}