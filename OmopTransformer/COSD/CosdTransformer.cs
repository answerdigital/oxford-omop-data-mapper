using Microsoft.Extensions.Logging;
using OmopTransformer.COSD.Death.v8Death;
using OmopTransformer.COSD.Death.v9DeathBasisOfDiagnosisCancer;
using OmopTransformer.COSD.Death.v9DeathDischargeDestination;
using OmopTransformer.COSD.Demographics;
using OmopTransformer.Omop.Death;
using OmopTransformer.Omop.Location;
using OmopTransformer.Omop.Person;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD;

internal class CosdTransformer : Transformer
{
    private readonly ILocationRecorder _locationRecorder;
    private readonly IPersonRecorder _personRecorder;
    private readonly IDeathRecorder _deathRecorder;

    public CosdTransformer(IRecordTransformer recordTransformer, ILogger<IRecordTransformer> logger, TransformOptions transformOptions, IRecordProvider recordProvider, ILocationRecorder locationRecorder, IPersonRecorder personRecorder, IDeathRecorder deathRecorder) : base(recordTransformer, logger, transformOptions, recordProvider, "COSD")
    {
        _locationRecorder = locationRecorder;
        _personRecorder = personRecorder;
        _deathRecorder = deathRecorder;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        await Transform<CosdDemographics, CosdPerson>(
            _personRecorder.InsertUpdatePersons,
            "COSD Person",
            cancellationToken);

        await Transform<CosdDemographics, CosdLocation>(
            _locationRecorder.InsertUpdateLocations,
            "COSD Location",
            cancellationToken);

        await Transform<CosdDemographics, CosdLocation>(
            _locationRecorder.InsertUpdateLocations,
            "COSD Location",
            cancellationToken);

        await Transform<CosdV8DeathRecord, CosdV8Death>(
            _deathRecorder.InsertUpdateDeaths,
            "COSD V8 Death",
            cancellationToken);

        await Transform<CosdV9DeathDischargeDestinationRecord, CosdDeathV9DeathDischargeDestination>(
            _deathRecorder.InsertUpdateDeaths,
            "COSD V9 DeathDischargeDestination Death",
            cancellationToken);

        await Transform<CosdV9BasisOfDiagnosisCancerRecord, CosdV9DeathBasisOfDiagnosisCancer>(
            _deathRecorder.InsertUpdateDeaths,
            "COSD V9 BasisOfDiagnosisCancer Death",
            cancellationToken);
    }
}