using Microsoft.Extensions.Logging;
using OmopTransformer.Omop.Location;
using OmopTransformer.Transformation;

namespace OmopTransformer.SACT;

internal class SactLocationTransformer : Transformer
{
    private readonly ILocationRecorder _locationRecorder;

    public SactLocationTransformer(IRecordTransformer recordTransformer, ILogger<IRecordTransformer> logger, TransformOptions transformOptions, IRecordProvider recordProvider, ILocationRecorder locationRecorder) : base(recordTransformer, logger, transformOptions, recordProvider)
    {
        _locationRecorder = locationRecorder;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        await base.Transform<Sact, SactLocation>(
            _locationRecorder.InsertUpdateLocations,
            "SACT Locations",
            cancellationToken);
    }
}