using Microsoft.Extensions.Logging;
using OmopTransformer.Transformation;
using OmopTransformer.Omop;
using OmopTransformer.Omop.Location;
using OmopTransformer.Omop.Person;
using OmopTransformer.Omop.DrugExposure;
using OmopTransformer.SACT.Person;
using OmopTransformer.SACT.Location;
using OmopTransformer.SACT.DrugExposure;


namespace OmopTransformer.SACT;
internal class SactTransformer : Transformer
{
    private readonly ILocationRecorder _locationRecorder;
    private readonly IPersonRecorder _personRecorder;
    private readonly IDrugExposureRecorder _drugExposureRecorder;

    public SactTransformer(
        IRecordTransformer recordTransformer,
        ILogger<IRecordTransformer> logger,
        TransformOptions transformOptions,
        IRecordProvider recordProvider,
        ILocationRecorder locationRecorder,
        IPersonRecorder personRecorder,
        IDrugExposureRecorder drugExposureRecorder,
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
        _drugExposureRecorder = drugExposureRecorder;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        Guid newId = Guid.NewGuid();

        await Transform<SactPersonRecord, SactPerson>(
            _personRecorder.InsertUpdatePersons,
            "SACT Person",
            newId,
            cancellationToken);

        await Transform<SactLocationRecord, SactLocation>(
            _locationRecorder.InsertUpdateLocations,
            "SACT Locations",
            newId,
            cancellationToken);

        await Transform<SactDrugExposureRecord, SactDrugExposure>(
            _drugExposureRecorder.InsertUpdateDrugExposure,
            "SACT Drug Exposure",
            newId,
            cancellationToken);
    }
}