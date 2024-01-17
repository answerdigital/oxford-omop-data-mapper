using Microsoft.Extensions.Logging;
using OmopTransformer.Omop.Location;
using OmopTransformer.Omop.Person;
using OmopTransformer.Transformation;

namespace OmopTransformer.SACT;

internal class SactTransformer : Transformer
{
    private readonly ILocationRecorder _locationRecorder;
    private readonly IPersonRecorder _personRecorder;
    
    public SactTransformer(IRecordTransformer recordTransformer, ILogger<IRecordTransformer> logger, TransformOptions transformOptions, IRecordProvider recordProvider, ILocationRecorder locationRecorder, IPersonRecorder personRecorder) : base(recordTransformer, logger, transformOptions, recordProvider, "SACT")
    {
        _locationRecorder = locationRecorder;
        _personRecorder = personRecorder;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        await Transform<Sact, SactPerson>(
            _personRecorder.InsertUpdatePersons,
            "SACT Person",
            cancellationToken);

        await Transform<Sact, SactLocation>(
            _locationRecorder.InsertUpdateLocations,
            "SACT Locations",
            cancellationToken);
    }
}