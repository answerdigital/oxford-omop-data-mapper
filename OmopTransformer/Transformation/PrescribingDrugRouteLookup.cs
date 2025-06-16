using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Prescribing Drug Routes to OMOP Condition Concept IDs")]
internal class PrescribingDrugRouteLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "affected eye(s)", new ValueWithNote("40549429", "Ocular") },
            { "anal", new ValueWithNote("4290759", "Rectal") },
            { "bath", new ValueWithNote("4263689", "Topical") },
            { "both ears", new ValueWithNote("4023156", "Otic") },
            { "both eyes", new ValueWithNote("40549429", "Ocular") },
            { "buccal", new ValueWithNote("4181897", "Buccal") },
            { "caudal", new ValueWithNote("4220455", "Caudal") },
            { "chewed", new ValueWithNote("4132161", "Oral") },
            { "dental", new ValueWithNote("4163765", "Dental") },
            { "endotracheal", new ValueWithNote("40491832", "Transtracheal") },
            { "enteral feed", new ValueWithNote("4167540", "Enteral") },
            { "epidural", new ValueWithNote("4225555", "Epidural") },
            { "flush", new ValueWithNote("", "") },
            { "gastrojejunostomy", new ValueWithNote("4133177", "Jejunostomy") },
            { "gastrostomy", new ValueWithNote("4132254", "Gastrostomy") },
            { "gingival", new ValueWithNote("4156704", "Gingival") },
            { "handihaler", new ValueWithNote("40486069", "Respiratory tract") },
            { "inhalation", new ValueWithNote("40486069", "Respiratory tract") },
            { "intraArterial", new ValueWithNote("4240824", "Intra-arterial") },
            { "intraArticular", new ValueWithNote("4006860", "Intra-articular") },
            { "intraBiliary", new ValueWithNote("4223965", "Intrabiliary") },
            { "intraCameral", new ValueWithNote("4303409", "Intracameral") },
            { "intraCardiac", new ValueWithNote("4156705", "Intracardiac") },
            { "intraCavernosal", new ValueWithNote("37174549", "Intracorporus cavernosum") },
            { "intraDermal", new ValueWithNote("4156706", "Intradermal") },
            { "intraDISCal", new ValueWithNote("4163769", "Intradiscal") },
            { "intraLesional", new ValueWithNote("4157758", "Intralesional") },
            { "intraLymphatic", new ValueWithNote("4157759", "Intralymphatic") },
            { "intraMuscular", new ValueWithNote("4302612", "Intramuscular") },
            { "intraMyometrial", new ValueWithNote("4168038", "Intramyometrial") },
            { "intraOcular", new ValueWithNote("4157760", "Intraocular") },
            { "intraOsseous", new ValueWithNote("4213522", "Intraosseous") },
            { "intraPeritoneal", new ValueWithNote("4243022", "Intraperitoneal") },
            { "intraPleural", new ValueWithNote("4156707", "Intrapleural") },
            { "intraThecal", new ValueWithNote("4217202", "Intrathecal") },
            { "intraTracheal", new ValueWithNote("4229543", "Intratracheal") },
            { "intraUrethral", new ValueWithNote("4305382", "Transurethral") },
            { "intraUterine", new ValueWithNote("4269621", "Intrauterine") },
            { "intraVenous", new ValueWithNote("4171047", "Intravenous") },
            { "intraVenous (central)", new ValueWithNote("4170113", "Intravenous central") },
            { "intraVentricular", new ValueWithNote("4222259", "Intraventricular route - cardiac") },
            { "intraVesical", new ValueWithNote("4186838", "Intravesical") },
            { "intravITeal", new ValueWithNote("4302785", "intraVitreal") },
            { "intraVitreal", new ValueWithNote("4302785", "Intravitreal") },
            { "irrigation", new ValueWithNote("", "") },
            { "jejunostomy", new ValueWithNote("4133177", "Jejunostomy") },
            { "left ear", new ValueWithNote("4023156", "Otic") },
            { "left eye", new ValueWithNote("40549429", "Ocular") },
            { "line lock", new ValueWithNote("", "") },
            { "local infiltration", new ValueWithNote("37397638", "Infiltrationr") },
            { "nasal", new ValueWithNote("4262914", "Nasal") },
            { "nasogastric", new ValueWithNote("4132711", "Nasogastric") },
            { "nasojejunal", new ValueWithNote("4305834", "Nasojejunal") },
            { "nebulised inhalation", new ValueWithNote("40486069", "Respiratory tract") },
            { "oral", new ValueWithNote("4132161", "Oral") },
            { "orogastric", new ValueWithNote("4303795", "Orogastric") },
            { "orojejunal", new ValueWithNote("4133177", "jejunostomy") },
            { "oromucosal", new ValueWithNote("4186839", "Oromucosal") },
            { "paravertebral", new ValueWithNote("4170267", "Paravertebral") },
            { "patient-controlled epidural analgesia", new ValueWithNote("4225555", "Epidural") },
            { "patient-controlled intravenous analgesia", new ValueWithNote("4171047", "Intravenous") },
            { "per rectum", new ValueWithNote("4290759", "Rectal") },
            { "regional analgesia", new ValueWithNote("", "") },
            { "right ear", new ValueWithNote("4023156", "Otic") },
            { "right eye", new ValueWithNote("40549429", "Ocular") },
            { "rinse", new ValueWithNote("4263689", "Topical") },
            { "soak", new ValueWithNote("4263689", "Topical") },
            { "soap", new ValueWithNote("4263689", "Topical") },
            { "subconjunctival", new ValueWithNote("4163770", "Subconjunctival") },
            { "subcutaneous", new ValueWithNote("4142048", "Subcutaneous") },
            { "subdermal", new ValueWithNote("4142048", "Subcutaneous") },
            { "sublingual", new ValueWithNote("4292110", "Sublingual") },
            { "topical", new ValueWithNote("4263689", "Topical") },
            { "transdermal", new ValueWithNote("4262099", "Transdermal") },
            //{ "subdermal", new ValueWithNote("4186839", "Oromucosal") },
            { "transUrethral", new ValueWithNote("4305382", "Transurethral") },
            { "vaginal", new ValueWithNote("4057765", "Vaginal") },
            { "via CVVHD", new ValueWithNote("", "") }
        };


    public string[] ColumnNotes =>
    [
        "[OMOP Routes](https://athena.ohdsi.org/search-terms/terms?domain=Route&standardConcept=Standard&page=1&pageSize=500&query=&boosts"
    ];
}
