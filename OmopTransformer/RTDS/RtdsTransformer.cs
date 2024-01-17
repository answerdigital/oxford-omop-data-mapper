using Microsoft.Extensions.Logging;
using OmopTransformer.Omop.Location;
using OmopTransformer.Omop.Person;
using OmopTransformer.RTDS.Demographics;
using OmopTransformer.Transformation;

namespace OmopTransformer.RTDS;

internal class RtdsTransformer : Transformer
{
    private readonly ILocationRecorder _locationRecorder;
    private readonly IPersonRecorder _personRecorder;
    
    public RtdsTransformer(IRecordTransformer recordTransformer, ILogger<IRecordTransformer> logger, TransformOptions transformOptions, IRecordProvider recordProvider, ILocationRecorder locationRecorder, IPersonRecorder personRecorder) : base(recordTransformer, logger, transformOptions, recordProvider, "RTDS")
    {
        _locationRecorder = locationRecorder;
        _personRecorder = personRecorder;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        await Transform<RtdsDemographics, RtdsPerson>(
            _personRecorder.InsertUpdatePersons,
            "Rtds Person",
            cancellationToken);
        
        await Transform<RtdsPasLocation, RtdsLocation>(
            _locationRecorder.InsertUpdateLocations,
            "Rtds Location",
            cancellationToken);
    }
}