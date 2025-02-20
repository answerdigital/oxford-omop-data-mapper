using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup discharge destination concept.")]
internal class AccidentAndEmergencyInvestigationLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "01", new ValueWithNote("45768233", "X-ray") },
            { "02", new ValueWithNote("45768113", "Electrocardiograph") },
            { "08", new ValueWithNote("45768357", "Microscope (histology)") },
            { "10", new ValueWithNote("45768281", "Ultrasound") },
            { "11", new ValueWithNote("4234381", "Magnetic Resonance Imaging (MRI)") },
            { "12", new ValueWithNote("45762714", "Computerised Tomography (CT)") },
            { "09", new ValueWithNote("45762714", "Computerised Tomography (CT)") },
            { "19", new ValueWithNote("618883", "Blood culture bottle") },
        };

    public string[] ColumnNotes => new string[] {};
}