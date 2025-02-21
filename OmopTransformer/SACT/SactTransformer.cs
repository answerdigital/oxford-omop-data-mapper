using Microsoft.Extensions.Logging;
using OmopTransformer.Omop;
using OmopTransformer.Omop.Location;
using OmopTransformer.Omop.Person;
using OmopTransformer.Transformation;

namespace OmopTransformer.SACT;

internal class SactTransformer : Transformer
{
    private readonly ILocationRecorder _locationRecorder;
    private readonly IPersonRecorder _personRecorder;
    
    public SactTransformer(
        IRecordTransformer recordTransformer, 
        ILogger<IRecordTransformer> logger, 
        TransformOptions transformOptions, 
        IRecordProvider recordProvider, 
        ILocationRecorder locationRecorder, 
        IPersonRecorder personRecorder, 
        IConceptMapper conceptMapper, 
        IRunAnalysisRecorder runAnalysisRecorder) 
        : base(
            recordTransformer, 
            logger, 
            transformOptions, 
            recordProvider, 
            "SACT", 
            conceptMapper,
            runAnalysisRecorder)
    {
        _locationRecorder = locationRecorder;
        _personRecorder = personRecorder;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        Guid newId = Guid.NewGuid();

        await Transform<Sact, SactPerson>(
            _personRecorder.InsertUpdatePersons,
            "SACT Person",
            newId,
            cancellationToken);

        await Transform<Sact, SactLocation>(
            _locationRecorder.InsertUpdateLocations,
            "SACT Locations",
            newId,
            cancellationToken);
    }
}