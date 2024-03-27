using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup TNMCategory concepts.")]
internal class TNMCategoryLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "1", new ValueWithNote("1635812", "IRS-modified TNM stage 1") },
            { "I", new ValueWithNote("1635812", "IRS-modified TNM stage 1") },

            { "1a", new ValueWithNote("1635812", "IRS-modified TNM stage 1") },
            { "IA", new ValueWithNote("1635812", "IRS-modified TNM stage 1") },

            { "1b", new ValueWithNote("1635812", "IRS-modified TNM stage 1") },
            { "IB", new ValueWithNote("1635812", "IRS-modified TNM stage 1") },

            { "2", new ValueWithNote("1635007", "IRS-modified TNM stage 2") },
            { "II", new ValueWithNote("1635007", "IRS-modified TNM stage 2") },

            { "2a", new ValueWithNote("1635007", "IRS-modified TNM stage 2") },
            { "IIA", new ValueWithNote("1635007", "IRS-modified TNM stage 2") },

            { "2b", new ValueWithNote("1635007", "IRS-modified TNM stage 2") },
            { "IIB", new ValueWithNote("1635007", "IRS-modified TNM stage 2") },

            { "2c", new ValueWithNote("1635007", "IRS-modified TNM stage 2") },
            { "IIC", new ValueWithNote("1635007", "IRS-modified TNM stage 2") },

            { "3", new ValueWithNote("1633995", "IRS-modified TNM stage 3") },
            { "III", new ValueWithNote("1633995", "IRS-modified TNM stage 3") },

            { "3a", new ValueWithNote("1633995", "IRS-modified TNM stage 3") },
            { "IIIA", new ValueWithNote("1633995", "IRS-modified TNM stage 3") },

            { "3b", new ValueWithNote("1633995", "IRS-modified TNM stage 3") },
            { "IIIB", new ValueWithNote("1633995", "IRS-modified TNM stage 3") },

            { "3c", new ValueWithNote("1633995", "IRS-modified TNM stage 3") },
            { "IIIC", new ValueWithNote("1633995", "IRS-modified TNM stage 3") },

            { "4", new ValueWithNote("1634737", "IRS-modified TNM stage 4") },
            { "IV", new ValueWithNote("1634737", "IRS-modified TNM stage 4") },

            { "4a", new ValueWithNote("1634737", "IRS-modified TNM stage 4") },
            { "IVA", new ValueWithNote("1634737", "IRS-modified TNM stage 4") },

            { "4b", new ValueWithNote("1634737", "IRS-modified TNM stage 4") },
            { "IVB", new ValueWithNote("1634737", "IRS-modified TNM stage 4") },

            { "4c", new ValueWithNote("1634737", "IRS-modified TNM stage 4") },
            { "IVC", new ValueWithNote("1634737", "IRS-modified TNM stage 4") }
        };

    public string[] ColumnNotes =>
    [
        "[OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=tnm&boosts)"
    ];
}