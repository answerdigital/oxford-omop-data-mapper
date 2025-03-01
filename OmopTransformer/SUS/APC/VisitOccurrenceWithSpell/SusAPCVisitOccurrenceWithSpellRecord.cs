﻿using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC.VisitOccurrenceWithSpell;

[DataOrigin("SUS")]
[Description("SUS APC VisitOccurrenceWithSpell")]
[SourceQuery("SusAPCVisitOccurrenceWithSpell.xml")]
internal class SusAPCVisitOccurrenceWithSpellRecord
{
    public string? NHSNumber { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
    public string? VisitStartDate { get; set; }
    public string? VisitStartTime { get; set; }
    public string? VisitEndDate { get; set; }
    public string? VisitEndTime { get; set; }
    public int? SourceofAdmissionCode { get; set; }
    public int? DischargeDestinationCode { get; set; }
}