using Microsoft.Extensions.Logging;
using OmopTransformer.CDS.Person;
using OmopTransformer.CDS.StructuredAddress;
using OmopTransformer.CDS.UnstructuredAddress;
using OmopTransformer.Omop.Location;
using OmopTransformer.Omop.Person;
using OmopTransformer.Transformation;

namespace OmopTransformer.CDS;

internal class CdsTransformer : Transformer
{
    private readonly ILocationRecorder _locationRecorder;
    private readonly IPersonRecorder _personRecorder;

    public CdsTransformer(IRecordTransformer recordTransformer, ILogger<IRecordTransformer> logger, TransformOptions transformOptions, IRecordProvider recordProvider, ILocationRecorder locationRecorder, IPersonRecorder personRecorder) : base(recordTransformer, logger, transformOptions, recordProvider)
    {
        _locationRecorder = locationRecorder;
        _personRecorder = personRecorder;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        await Transform<CdsPersonRecord, CdsPerson>(
            _personRecorder.InsertUpdatePersons,
            "CDS Person",
            cancellationToken);

        await Transform<CdsStructuredAddress, CdsStructuredLocation>(
            _locationRecorder.InsertUpdateLocations,
            "CDS Structured Address",
            cancellationToken);

        await Transform<CdsUnstructuredAddress, CdsLocation>(
            _locationRecorder.InsertUpdateLocations,
            "CDS Unstructured Address",
            cancellationToken);
    }
}