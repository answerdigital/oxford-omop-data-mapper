﻿using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.OP.VisitOccurrenceWithSpell;

[DataOrigin("SUS")]
[Description("SUS OP VisitOccurrenceWithSpell")]
[SourceQuery("SusOPVisitOccurrenceWithSpell.xml")]
internal class SusOPVisitOccurrenceWithSpellRecord
{
    public string? NHSNumber { get; set; }
    public string? SUSgeneratedspellID { get; set; }
    public string? VisitStartDate { get; set; }
    public string? VisitStartTime { get; set; }
    public string? VisitEndDate { get; set; }
    public string? VisitEndTime { get; set; }
}