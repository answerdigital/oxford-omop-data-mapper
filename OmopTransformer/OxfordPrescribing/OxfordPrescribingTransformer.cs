using Microsoft.Extensions.Logging;
using OmopTransformer.Omop;
using OmopTransformer.OxfordPrescribing.DrugExposure;
using OmopTransformer.Transformation;
using OmopTransformer.Omop.DrugExposure;

namespace OmopTransformer.OxfordPrescribing;

internal class OxfordPrescribingTransformer : Transformer
{
    private readonly ConceptResolver _conceptResolver;
    private readonly IDrugExposureRecorder _drugExposureRecorder;

    public OxfordPrescribingTransformer(
        IRecordTransformer recordTransformer,
        TransformOptions transformOptions,
        IRecordProvider recordProvider,
        IDrugExposureRecorder drugExposureRecorder,
        ConceptResolver conceptResolver,
        IConceptMapper conceptMapper,
        IRunAnalysisRecorder runAnalysisRecorder,
        ILoggerFactory loggerFactory) : base(recordTransformer,
        transformOptions,
        recordProvider,
        "Oxford-Prescribing",
        conceptMapper,
        runAnalysisRecorder,
        loggerFactory)
    {
        _drugExposureRecorder = drugExposureRecorder;
        _conceptResolver = conceptResolver;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        Guid runId = Guid.NewGuid();

        await Transform<OxfordPrescribingDrugExposureRecord, OxfordPrescribingDrugExposure>(
          _drugExposureRecorder.InsertUpdateDrugExposure,
          "Oxford Prescribing Drugs",
          runId,
          cancellationToken);

        _conceptResolver.PrintErrors();
    }
}
