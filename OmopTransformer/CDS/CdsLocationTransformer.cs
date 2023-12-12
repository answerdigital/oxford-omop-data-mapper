using Microsoft.Extensions.Logging;
using OmopTransformer.CDS.StructuredAddress;
using OmopTransformer.CDS.UnstructuredAddress;
using OmopTransformer.Omop.Location;
using OmopTransformer.Transformation;

namespace OmopTransformer.CDS;

internal class CdsLocationTransformer : Transformer
{
    private readonly ILocationRecorder _locationRecorder;

    public CdsLocationTransformer(IRecordTransformer recordTransformer, ILogger<IRecordTransformer> logger, TransformOptions transformOptions, IRecordProvider recordProvider, ILocationRecorder locationRecorder) : base(recordTransformer, logger, transformOptions, recordProvider)
    {
        _locationRecorder = locationRecorder;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        await Transform<CdsStructuredAddress, StructuredAddress.CdsLocation>(
            _locationRecorder.InsertUpdateLocations,
            "CDS Structured Address",
            cancellationToken);

        await Transform<CdsUnstructuredAddress, UnstructuredAddress.CdsLocation>(
            _locationRecorder.InsertUpdateLocations,
            "CDS Unstructured Address",
            cancellationToken);
    }
}