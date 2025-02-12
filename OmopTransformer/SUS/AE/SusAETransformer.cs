using Microsoft.Extensions.Logging;
using OmopTransformer.SUS.AE.Death;
using OmopTransformer.SUS.AE.Location;
using OmopTransformer.SUS.AE.ConditionOccurrence;
using OmopTransformer.SUS.AE.ProcedureOccurrence;
// using OmopTransformer.SUS.AE.Measurements.SusAEMeasurement;
using OmopTransformer.SUS.AE.VisitOccurrenceWithSpell;
using OmopTransformer.SUS.AE.Observation.AsthmaticPatient;
using OmopTransformer.SUS.AE.Observation.DiabeticPatient;
using OmopTransformer.SUS.AE.Observation.SourceOfReferralForOutpatients;
using OmopTransformer.SUS.AE.VisitDetails;
// using OmopTransformer.SUS.AE.CareSite;
// using OmopTransformer.SUS.AE.Provider;
using OmopTransformer.Omop.ConditionOccurrence;
using OmopTransformer.Omop.Measurement;
using OmopTransformer.Omop.Death;
using OmopTransformer.Omop.DrugExposure;
using OmopTransformer.Omop.Location;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Omop.Person;
using OmopTransformer.Omop.ProcedureOccurrence;
using OmopTransformer.Omop.VisitDetail;
using OmopTransformer.Omop.VisitOccurrence;
using OmopTransformer.Omop.CareSite;
using OmopTransformer.Omop.Provider;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.AE;

internal class SusAETransformer : Transformer
{
    private readonly ILocationRecorder _locationRecorder;
    private readonly IPersonRecorder _personRecorder;
    private readonly IMeasurementRecorder _measurementRecorder;
    private readonly IConditionOccurrenceRecorder _conditionOccurrenceRecorder;
    private readonly IVisitOccurrenceRecorder _visitOccurrenceRecorder;
    private readonly IVisitDetailRecorder _visitDetailRecorder;
    private readonly IDeathRecorder _deathRecorder;
    private readonly IProcedureOccurrenceRecorder _procedureOccurrenceRecorder;
    private readonly IDrugExposureRecorder _drugExposureRecorder;
    private readonly IObservationRecorder _observationRecorder;
    private readonly ConceptResolver _conceptResolver;
    private readonly ICareSiteRecorder _careSiteRecorder;
    private readonly IProviderRecorder _providerRecorder;

    public SusAETransformer(
        ICareSiteRecorder careSiteRecorder,
        IProviderRecorder providerRecorder,
        IMeasurementRecorder measurementRecorder,
        IRecordTransformer recordTransformer,
        ILogger<IRecordTransformer> logger,
        TransformOptions transformOptions,
        IRecordProvider recordProvider,
        ILocationRecorder locationRecorder,
        IPersonRecorder personRecorder,
        IConditionOccurrenceRecorder conditionOccurrenceRecorder,
        IVisitOccurrenceRecorder visitOccurrenceRecorder,
        IVisitDetailRecorder visitDetailRecorder,
        IDeathRecorder deathRecorder,
        IProcedureOccurrenceRecorder procedureOccurrenceRecorder, 
        ConceptResolver conceptResolver, 
        IDrugExposureRecorder drugExposureRecorder, 
        IObservationRecorder observationRecorder,
        IConceptMapper conceptMapper) : base(recordTransformer,
        logger,
        transformOptions,
        recordProvider,
        "SUSAE",
        conceptMapper)
    {
        _locationRecorder = locationRecorder;
        _personRecorder = personRecorder;
        _measurementRecorder = measurementRecorder;
        _conditionOccurrenceRecorder = conditionOccurrenceRecorder;
        _visitOccurrenceRecorder = visitOccurrenceRecorder;
        _visitDetailRecorder = visitDetailRecorder;
        _deathRecorder = deathRecorder;
        _procedureOccurrenceRecorder = procedureOccurrenceRecorder;
        _conceptResolver = conceptResolver;
        _drugExposureRecorder = drugExposureRecorder;
        _observationRecorder = observationRecorder;
        _careSiteRecorder = careSiteRecorder;
        _providerRecorder = providerRecorder;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        await Transform<SusAEPersonRecord, SusAEPerson>(
          _personRecorder.InsertUpdatePersons,
          "Sus AE Person",
          cancellationToken);

        await Transform<SusAEDeathRecord, SusAEDeath>(
          _deathRecorder.InsertUpdateDeaths,
          "SUS AE Death",
          cancellationToken);

        await Transform<SusAEProcedureOccurrenceRecord, SusAEProcedureOccurrence>(
          _procedureOccurrenceRecorder.InsertUpdateProcedureOccurrence,
          "SUS AE Procedure Occurrence",
          cancellationToken);

        await Transform<SusAEConditionOccurrenceRecord, SusAEConditionOccurrence>(
          _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
          "SUS AE Conditon Occurrence",
          cancellationToken);

        await Transform<SusAELocationRecord, SusAELocation>(
          _locationRecorder.InsertUpdateLocations,
          "SUS AE Location",
          cancellationToken);

        await Transform<SusAEVisitOccurrenceWithSpellRecord, SusAEVisitOccurrenceWithSpell>(
          _visitOccurrenceRecorder.InsertUpdateVisitOccurrence,
          "SUS AE VisitOccurrenceWithSpell",
          cancellationToken);

        await Transform<SusAEDiabeticPatientRecord, SusAEDiabeticPatient>(
          _observationRecorder.InsertUpdateObservations,
        "SUS AE DiabeticPatient",
          cancellationToken);

        await Transform<SusAEAsthmaticPatientRecord, SusAEAsthmaticPatient>(
          _observationRecorder.InsertUpdateObservations,
        "SUS AE AsthmaticPatient",
          cancellationToken);

        await Transform<SusAESourceOfReferralForOutpatientsRecord, SusAESourceOfReferralForOutpatients>(
          _observationRecorder.InsertUpdateObservations,
          "SUS AE SourceOfReferralForOutpatients",
          cancellationToken);

        await Transform<SusAEVisitDetailsRecord, SusAEVisitDetail>(
          _visitDetailRecorder.InsertUpdateVisitDetail,
          "SUS AE VisitDetail",
          cancellationToken);

        // await Transform<SusAECareSiteRecord, SusAECareSite>(
        //    _careSiteRecorder.InsertUpdateCareSite,
        //    "SUS AE CareSite",
        //    cancellationToken);

        // await Transform<SusAEProviderRecord, SusAEProvider>(
        //    _providerRecorder.InsertUpdateProvider,
        //    "SUS AE Provider",
        //    cancellationToken);

        // await Transform<SusAEMeasurementRecord, SusAEMeasurement>(
        //     _measurementRecorder.InsertUpdateMeasurements,
        //     "SUS AE Measurements",
        //     cancellationToken);

        _conceptResolver.PrintErrors();
    }
}
