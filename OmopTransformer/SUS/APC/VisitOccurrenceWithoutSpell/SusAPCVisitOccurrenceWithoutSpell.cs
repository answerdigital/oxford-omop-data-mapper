﻿using OmopTransformer.Annotations;
using OmopTransformer.Omop.VisitOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.APC.VisitOccurrenceWithoutSpell;

[Notes(
    "Assumptions",
    "* `Emergency` covers a visit to A&E Within the given Hospital Provider, and hence covers Admission Code 21 and 24 only",
    "* `Location Class` ID 24 is a Consultant Clinic Within the Health Care Provider.",
    "* `Patient Classification` ID 1 is the only entry that covers 24 hours or more With the use of a bed, and whilst others may be a day/night only, they will be discounted because they are less than 24 hours. Also, maternity is also not taken as an `Inpatient` visit.",
    "* No calculations to be made between Start and end visit date to try to calculate 24 hours, but instead the `Patient Classification` will be sufficient")]
internal class SusAPCVisitOccurrenceWithoutSpell : OmopVisitOccurrence<SusAPCVisitOccurrenceWithoutSpellRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? NhsNumber { get; set; }

    [CopyValue(nameof(Source.RecordConnectionIdentifier))]
    public override string? RecordConnectionIdentifier { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.EpisodeStartDate))]
    public override DateTime? visit_start_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.EpisodeStartDate), nameof(Source.EpisodeStartTime))]
    public override DateTime? visit_start_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.EpisodeEndDate))]
    public override DateTime? visit_end_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.EpisodeEndDate), nameof(Source.EpisodeEndTime))]
    public override DateTime? visit_end_datetime { get; set; }

    [ConstantValue(9202, "`Outpatient Visit`")]
    public override int? visit_concept_id { get; set; }

    [ConstantValue(32818, "`EHR Administration Record`")]
    public override int? visit_type_concept_id { get; set; }

    [Transform(typeof(AdmittedSourceLookup), nameof(Source.SourceofAdmissionCode))]
    public override int? admitted_from_concept_id { get; set; }

    [CopyValue(nameof(Source.SourceofAdmissionCode))]
    public override string? admitted_from_source_value { get; set; }

    [Transform(typeof(DischargeDestinationLookup), nameof(Source.DischargeDestinationCode))]
    public override int? discharged_to_concept_id { get; set; }

    [CopyValue(nameof(Source.DischargeDestinationCode))]
    public override string? discharged_to_source_value { get; set; }
}