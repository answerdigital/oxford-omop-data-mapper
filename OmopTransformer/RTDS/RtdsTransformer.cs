using Microsoft.Extensions.Logging;
using OmopTransformer.Omop.Location;
using OmopTransformer.Omop.Person;
using OmopTransformer.Omop.ProcedureOccurrence;
using OmopTransformer.Omop.ConditionOccurrence;
using OmopTransformer.Omop.VisitDetail;
using OmopTransformer.Omop;
using OmopTransformer.RTDS.ProcedureOccurrence;
using OmopTransformer.RTDS.ConditionOccurrence;
using OmopTransformer.RTDS.VisitDetails;
using OmopTransformer.RTDS.Person;
using OmopTransformer.RTDS.Location;
using OmopTransformer.Transformation;

namespace OmopTransformer.RTDS;

internal class RtdsTransformer : Transformer
{
    private readonly ILocationRecorder _locationRecorder;
    private readonly IPersonRecorder _personRecorder;
    private readonly IProcedureOccurrenceRecorder _procedureOccurrenceRecorder;
    private readonly IConditionOccurrenceRecorder _conditionOccurrenceRecorder;
    private readonly IVisitDetailRecorder _visitDetailRecorder;

    public RtdsTransformer(
        IRecordTransformer recordTransformer,
        TransformOptions transformOptions,
        IRecordProvider recordProvider,
        ILocationRecorder locationRecorder,
        IPersonRecorder personRecorder,
        IProcedureOccurrenceRecorder procedureOccurrenceRecorder,
        IConditionOccurrenceRecorder conditionOccurrenceRecorder,
        IVisitDetailRecorder visitDetailRecorder,
        IConceptMapper conceptMapper,
        IRunAnalysisRecorder runAnalysisRecorder,
        ILoggerFactory loggerFactory)
        : base(
            recordTransformer,
            transformOptions,
            recordProvider,
            "RTDS",
            conceptMapper,
            runAnalysisRecorder,
            loggerFactory)
    {
        _locationRecorder = locationRecorder;
        _personRecorder = personRecorder;
        _procedureOccurrenceRecorder = procedureOccurrenceRecorder;
        _conditionOccurrenceRecorder = conditionOccurrenceRecorder;
        _visitDetailRecorder = visitDetailRecorder;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        Guid runId = Guid.NewGuid();

        await Transform<RtdsPersonRecord, RtdsPerson>(
            _personRecorder.InsertUpdatePersons,
            "Rtds Person",
            runId,
            cancellationToken);

        await Transform<RtdsLocationRecord, RtdsLocation>(
            _locationRecorder.InsertUpdateLocations,
            "Rtds Location",
            runId,
            cancellationToken);

        await Transform<RtdsProcedureOccurrenceRecord, RtdsProcedureOccurrence>(
          _procedureOccurrenceRecorder.InsertUpdateProcedureOccurrence,
          "Rtds Procedure Occurrence",
          runId,
          cancellationToken);

        await Transform<RtdsConditionOccurrenceRecord, RtdsConditionOccurrence>(
          _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
          "Rtds Condition Occurrence",
          runId,
          cancellationToken);

        await Transform<RtdsVisitDetailsRecord, RtdsVisitDetail>(
          _visitDetailRecorder.InsertUpdateVisitDetail,
          "Rtds Visit Detail",
          runId,
          cancellationToken);
    }
}