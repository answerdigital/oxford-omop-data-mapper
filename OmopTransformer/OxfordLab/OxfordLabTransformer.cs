using Microsoft.Extensions.Logging;
using OmopTransformer.Omop;
using OmopTransformer.OxfordLab.Measurements.OxfordLabMeasurement;
using OmopTransformer.Transformation;
using OmopTransformer.Omop.Measurement;

namespace OmopTransformer.OxfordLab;

internal class OxfordLabTransformer : Transformer
{
    private readonly ConceptResolver _conceptResolver;
    private readonly IMeasurementRecorder _measurementRecorder;

    public OxfordLabTransformer(
        IRecordTransformer recordTransformer,
        TransformOptions transformOptions,
        IRecordProvider recordProvider,
        IMeasurementRecorder measurementRecorder,
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

        _conceptResolver.PrintErrors();
    }
}
