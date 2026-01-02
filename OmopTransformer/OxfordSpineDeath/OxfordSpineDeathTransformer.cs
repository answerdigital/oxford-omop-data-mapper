using Microsoft.Extensions.Logging;
using OmopTransformer.ConceptResolution;
using OmopTransformer.Omop;
using OmopTransformer.Omop.Death;
using OmopTransformer.OxfordSpineDeath.Death;
using OmopTransformer.Transformation;

namespace OmopTransformer.OxfordSpineDeath;

internal class OxfordSpineDeathTransformer : Transformer
{
    private readonly StandardConceptResolver _conceptResolver;
    private readonly IDeathRecorder _deathRecorder;

    public OxfordSpineDeathTransformer(
        IRecordTransformer recordTransformer,
        TransformOptions transformOptions,
        IRecordProvider recordProvider,
        StandardConceptResolver conceptResolver,
        IRunAnalysisRecorder runAnalysisRecorder,
        ILoggerFactory loggerFactory, IDeathRecorder deathRecorder) : base(recordTransformer,
        transformOptions,
        recordProvider,
        "Oxford-Spine-Death",
        runAnalysisRecorder,
        loggerFactory)
    {
        _conceptResolver = conceptResolver;
        _deathRecorder = deathRecorder;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        Guid runId = Guid.NewGuid();

        await Transform<OxfordSpineDeathRecord, Death.OxfordSpineDeath>(
            _deathRecorder.InsertUpdateDeaths,
            "Oxford Spine Death",
            runId,
            cancellationToken);
    }
}
