using Microsoft.Extensions.Logging;
using OmopTransformer.COSD.Demographics;
using OmopTransformer.Omop.Location;
using OmopTransformer.Omop.Person;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD;

internal class CosdTransformer : Transformer
{
    private readonly ILocationRecorder _locationRecorder;
    private readonly IPersonRecorder _personRecorder;

    public CosdTransformer(IRecordTransformer recordTransformer, ILogger<IRecordTransformer> logger, TransformOptions transformOptions, IRecordProvider recordProvider, ILocationRecorder locationRecorder, IPersonRecorder personRecorder) : base(recordTransformer, logger, transformOptions, recordProvider)
    {
        _locationRecorder = locationRecorder;
        _personRecorder = personRecorder;
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
    }
}