using Microsoft.Extensions.Logging;
using OmopTransformer.Omop;
using OmopTransformer.Omop.Death;
using OmopTransformer.Omop.Location;
using OmopTransformer.Omop.Person;
using OmopTransformer.OxfordGP.Death;
using OmopTransformer.OxfordGP.Location;
using OmopTransformer.OxfordGP.Person;
using OmopTransformer.Transformation;

namespace OmopTransformer.OxfordGP;

internal class OxfordGPTransformer : Transformer
{
    private readonly ILocationRecorder _locationRecorder;
    private readonly IPersonRecorder _personRecorder;
    private readonly IDeathRecorder _deathRecorder;
    private readonly ConceptResolver _conceptResolver;

    public OxfordGPTransformer(
        IRecordTransformer recordTransformer,
        TransformOptions transformOptions,
        IRecordProvider recordProvider,
        ILocationRecorder locationRecorder,
        IPersonRecorder personRecorder,
        IDeathRecorder deathRecorder,
        ConceptResolver conceptResolver,
        IConceptMapper conceptMapper,
        IRunAnalysisRecorder runAnalysisRecorder,
        ILoggerFactory loggerFactory) : base(recordTransformer,
        transformOptions,
        recordProvider,
        "Oxford-GP",
        conceptMapper,
        runAnalysisRecorder,
        loggerFactory)
    {
        _locationRecorder = locationRecorder;
        _personRecorder = personRecorder;
        _deathRecorder = deathRecorder;
        _conceptResolver = conceptResolver;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        Guid runId = Guid.NewGuid();

        await Transform<OxfordGPPersonRecord, OxfordGPPerson>(
          _personRecorder.InsertUpdatePersons,
          "Oxford GP Person",
          runId,
          cancellationToken);

        await Transform<OxfordGPDeathRecord, OxfordGPDeath>(
          _deathRecorder.InsertUpdateDeaths,
          "Oxford GP Death",
          runId,
          cancellationToken);


        await Transform<OxfordGPLocationRecord, OxfordGPLocation>(
          _locationRecorder.InsertUpdateLocations,
          "Oxford GP Location",
          runId,
          cancellationToken);

        _conceptResolver.PrintErrors();
    }
}
