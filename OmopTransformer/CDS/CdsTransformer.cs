using Microsoft.Extensions.Logging;
using OmopTransformer.CDS.ConditionOccurrence;
using OmopTransformer.CDS.Person;
using OmopTransformer.CDS.StructuredAddress;
using OmopTransformer.CDS.UnstructuredAddress;
using OmopTransformer.CDS.VisitOccurrenceWithoutSpell;
using OmopTransformer.CDS.VisitOccurrenceWithSpell;
using OmopTransformer.Omop.ConditionOccurrence;
using OmopTransformer.Omop.Location;
using OmopTransformer.Omop.Person;
using OmopTransformer.Omop.VisitOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.CDS;

internal class CdsTransformer : Transformer
{
    private readonly ILocationRecorder _locationRecorder;
    private readonly IPersonRecorder _personRecorder;
    private readonly IConditionOccurrenceRecorder _conditionOccurrenceRecorder;
    private readonly IVisitOccurrenceRecorder _visitOccurrenceRecorder;

    public CdsTransformer(IRecordTransformer recordTransformer, ILogger<IRecordTransformer> logger, TransformOptions transformOptions, IRecordProvider recordProvider, ILocationRecorder locationRecorder, IPersonRecorder personRecorder, IConditionOccurrenceRecorder conditionOccurrenceRecorder, IVisitOccurrenceRecorder visitOccurrenceRecorder) : base(recordTransformer, logger, transformOptions, recordProvider, "CDS")
    {
        _locationRecorder = locationRecorder;
        _personRecorder = personRecorder;
        _conditionOccurrenceRecorder = conditionOccurrenceRecorder;
        _visitOccurrenceRecorder = visitOccurrenceRecorder;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        await Transform<CdsPersonRecord, CdsPerson>(
            _personRecorder.InsertUpdatePersons,
            "CDS Person",
            cancellationToken);

        await Transform<CdsStructuredAddress, CdsStructuredLocation>(
            _locationRecorder.InsertUpdateLocations,
            "CDS Structured Address",
            cancellationToken);

        await Transform<CdsUnstructuredAddress, CdsLocation>(
            _locationRecorder.InsertUpdateLocations,
            "CDS Unstructured Address",
            cancellationToken);

        await Transform<CdsConditionOccurrenceRecord, CdsConditionOccurrence>(
            _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
            "CDS Condition Occurrences",
            cancellationToken);

        await Transform<CdsVisitOccurrenceWithSpellRecord, CdsVisitOccurrenceWithSpell>(
            _visitOccurrenceRecorder.InsertUpdateVisitOccurrence,
            "CDS VisitOccurrenceWithSpell",
            cancellationToken);

        await Transform<CdsVisitOccurrenceWithoutSpellRecord, CdsVisitOccurrenceWithoutSpell>(
            _visitOccurrenceRecorder.InsertUpdateVisitOccurrence,
            "CDS VisitOccurrenceWithoutSpell",
            cancellationToken);
    }
}