using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("The UNIT OF MEASUREMENT used for each Systemic Anti-Cancer Therapy Drug Administration in a Systemic Anti-Cancer Therapy Drug Cycle.")]
internal class SactUnitOfMeasurement : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "01", new ValueWithNote("Milligrams (mg)", "") },
            { "02", new ValueWithNote("Micrograms (Mcg)", "") },
            { "03", new ValueWithNote("Grams (g)", "") },
            { "04", new ValueWithNote("Units", "") },
            { "05", new ValueWithNote("Cells", "") },
            { "06", new ValueWithNote("Plaque Forming Units (PFU) (one million) (x10^6)", "") },
            { "07", new ValueWithNote("Plaque Forming Units (PFU) (one hundred million) (x10^8)", "") },
        };

    public string[] ColumnNotes => new string[] {};
}