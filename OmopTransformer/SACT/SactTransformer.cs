using Microsoft.Extensions.Logging;
using OmopTransformer.Transformation;
using OmopTransformer.Omop;
using OmopTransformer.Omop.Location;
using OmopTransformer.Omop.Person;
using OmopTransformer.Omop.DrugExposure;
using OmopTransformer.Omop.ConditionOccurrence;
using OmopTransformer.SACT.Person;
using OmopTransformer.SACT.Location;
using OmopTransformer.SACT.DrugExposure;
using OmopTransformer.SACT.ConditionOccurrence;
using OmopTransformer.SACT.Provider;
using OmopTransformer.Omop.Provider;
using OmopTransformer.Omop.CareSite;
using OmopTransformer.Omop.Measurement;
using OmopTransformer.SACT.Measurements.SactMeasurementHeight;
using OmopTransformer.SACT.Measurements.SactMeasurementWeightAtStartOfCycle;
using OmopTransformer.SACT.Measurements.SactMeasurementWeightAtStartOfRegimen;
using OmopTransformer.SACT.CareSite;

namespace OmopTransformer.SACT;
internal class SactTransformer : Transformer
{
    private readonly ILocationRecorder _locationRecorder;
    private readonly IPersonRecorder _personRecorder;
    private readonly IDrugExposureRecorder _drugExposureRecorder;
    private readonly IConditionOccurrenceRecorder _conditionOccurrenceRecorder;
    private readonly IProviderRecorder _providerRecorder;
    private readonly ICareSiteRecorder _careSiteRecorder;
    private readonly IMeasurementRecorder _measurementRecorder;

    public SactTransformer(
        IRecordTransformer recordTransformer,
        TransformOptions transformOptions,
        IRecordProvider recordProvider,
        ILocationRecorder locationRecorder,
        IPersonRecorder personRecorder,
        IDrugExposureRecorder drugExposureRecorder,
        IConditionOccurrenceRecorder conditionOccurrenceRecorder,
        IMeasurementRecorder measurementRecorder,
        IProviderRecorder providerRecorder,
        ICareSiteRecorder careSiteRecorder,
        IConceptMapper conceptMapper,
        IRunAnalysisRecorder runAnalysisRecorder,
        ILoggerFactory loggerFactory)
        : base(
            recordTransformer,
            transformOptions,
            recordProvider,
            "SACT",
            conceptMapper,
            runAnalysisRecorder,
            loggerFactory)
    {
        _locationRecorder = locationRecorder;
        _personRecorder = personRecorder;
        _drugExposureRecorder = drugExposureRecorder;
        _conditionOccurrenceRecorder = conditionOccurrenceRecorder;
        _measurementRecorder = measurementRecorder;
        _providerRecorder = providerRecorder;
        _careSiteRecorder = careSiteRecorder;
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

        await Transform<SactConditionOccurrenceRecord, SactConditionOccurrence>(
            _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
            "SACT Condition Occurrence",
            newId,
            cancellationToken);

        await Transform<SactMeasurementHeightRecord, SactMeasurementHeight>(
            _measurementRecorder.InsertUpdateMeasurements,
            "SACT Measurement Height",
            newId,
            cancellationToken);

        await Transform<SactMeasurementWeightAtStartOfCycleRecord, SactMeasurementWeightAtStartOfCycle>(
            _measurementRecorder.InsertUpdateMeasurements,
            "SACT Measurement Weight at Start of Cycle",
            newId,
            cancellationToken);

        await Transform<SactMeasurementWeightAtStartOfRegimenRecord, SactMeasurementWeightAtStartOfRegimen>(
            _measurementRecorder.InsertUpdateMeasurements,
            "SACT Measurement Weight at Start of Regimen",
            newId,
            cancellationToken);

        await Transform<SactProviderRecord, SactProvider>(
            _providerRecorder.InsertUpdateProvider,
            "SACT Provider",
            newId,
            cancellationToken);
            
        await Transform<SactCareSiteRecord, SactCareSite>(
            _careSiteRecorder.InsertUpdateCareSite,
            "SACT Care Site",
            newId,
            cancellationToken);
    }
}