using Microsoft.Extensions.Logging;
using OmopTransformer.Omop;
using OmopTransformer.Omop.Measurement;
using OmopTransformer.Omop.Observation;
using OmopTransformer.OxfordLab.Measurements.OxfordLabMeasurement;
using OmopTransformer.OxfordLab.Observations.LabReportGeneralComment;
using OmopTransformer.Transformation;

namespace OmopTransformer.OxfordLab;

internal class OxfordLabTransformer : Transformer
{
    private readonly ConceptResolver _conceptResolver;
    private readonly IMeasurementRecorder _measurementRecorder;
    private readonly IObservationRecorder _observationRecorder;

    public OxfordLabTransformer(
        IRecordTransformer recordTransformer,
        TransformOptions transformOptions,
        IRecordProvider recordProvider,
        IMeasurementRecorder measurementRecorder,
        IObservationRecorder observationRecorder,
        ConceptResolver conceptResolver,
        IRunAnalysisRecorder runAnalysisRecorder,
        ILoggerFactory loggerFactory) : base(recordTransformer,
        transformOptions,
        recordProvider,
        "Oxford-Lab",
        runAnalysisRecorder,
        loggerFactory)
    {
        _measurementRecorder = measurementRecorder;
        _observationRecorder = observationRecorder;
        _conceptResolver = conceptResolver;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        Guid runId = Guid.NewGuid();

        await Transform<OxfordLabMeasurementRecord, OxfordLabMeasurement>(
            _measurementRecorder.InsertUpdateMeasurements,
            "Oxford Lab Measurements",
            runId,
            cancellationToken);

        await Transform<OxfordLabGeneralCommentRecord, OxfordLabGeneralComment>(
            _observationRecorder.InsertUpdateObservations,
            "Oxford Lab General Comments",
            runId,
            cancellationToken);

        _conceptResolver.PrintErrors();
    }
}
