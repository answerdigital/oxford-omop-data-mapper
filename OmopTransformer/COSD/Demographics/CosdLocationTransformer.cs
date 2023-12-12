using Microsoft.Extensions.Logging;
using OmopTransformer.Omop.Location;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD.Demographics;

internal class CosdLocationTransformer : Transformer
{
    private readonly ILocationRecorder _locationRecorder;

    public CosdLocationTransformer(IRecordTransformer recordTransformer, ILogger<IRecordTransformer> logger, TransformOptions transformOptions, IRecordProvider recordProvider, ILocationRecorder locationRecorder) : base(recordTransformer, logger, transformOptions, recordProvider)
    {
        _locationRecorder = locationRecorder;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        await Transform<CosdDemographics, CosdLocation>(
            _locationRecorder.InsertUpdateLocations,
            "COSD Location",
            cancellationToken);
    }
}