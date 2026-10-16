using Microsoft.Extensions.Logging;
using OmopTransformer.Omop;
using OmopTransformer.Omop.Person;
using OmopTransformer.OxfordDemographics.Person;
using OmopTransformer.Transformation;

namespace OmopTransformer.OxfordDemographics;

internal class OxfordDemographicsTransformer : Transformer
{
    private readonly IPersonRecorder _personRecorder;

    public OxfordDemographicsTransformer(
        IRecordTransformer recordTransformer,
        TransformOptions transformOptions,
        IRecordProvider recordProvider,
        IRunAnalysisRecorder runAnalysisRecorder,
        ILoggerFactory loggerFactory,
        IPersonRecorder personRecorder) : base(
        recordTransformer,
        transformOptions,
        recordProvider,
        "Oxford-Demographics",
        runAnalysisRecorder,
        loggerFactory)
    {
        _personRecorder = personRecorder;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        await Transform<OxfordDemographicsPersonRecord, OxfordDemographicsPerson>(
            _personRecorder.InsertUpdatePersons,
            "Oxford Demographics Person",
            Guid.NewGuid(),
            cancellationToken);
    }
}
