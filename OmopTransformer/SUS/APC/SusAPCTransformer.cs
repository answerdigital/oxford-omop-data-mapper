﻿using Microsoft.Extensions.Logging;
using OmopTransformer.SUS.APC.Death;
using OmopTransformer.SUS.APC.Location;
using OmopTransformer.SUS.APC.ConditionOccurrence;
using OmopTransformer.SUS.APC.ProcedureOccurrence;
using OmopTransformer.SUS.APC.Measurements.SusAPCMeasurement;
using OmopTransformer.SUS.APC.VisitOccurrenceWithSpell;
using OmopTransformer.SUS.APC.Observation.AnaestheticDuringLabourDelivery;
using OmopTransformer.SUS.APC.Observation.AnaestheticGivenPostLabourDelivery;
using OmopTransformer.SUS.APC.Observation.BirthWeight;
using OmopTransformer.SUS.APC.Observation.CarerSupportIndicator;
using OmopTransformer.SUS.APC.Observation.GestationLengthLabourOnset;
using OmopTransformer.SUS.APC.Observation.NumberOfBabies;
using OmopTransformer.SUS.APC.Observation.TotalPreviousPregnancies;
using OmopTransformer.SUS.APC.Observation.SourceOfReferralForOutpatients;
using OmopTransformer.SUS.APC.VisitDetails;
using OmopTransformer.SUS.APC.CareSite;
using OmopTransformer.SUS.APC.Provider;
using OmopTransformer.Omop.ConditionOccurrence;
using OmopTransformer.Omop.Measurement;
using OmopTransformer.Omop.Death;
using OmopTransformer.Omop.Location;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Omop.Person;
using OmopTransformer.Omop.ProcedureOccurrence;
using OmopTransformer.Omop.VisitDetail;
using OmopTransformer.Omop.VisitOccurrence;
using OmopTransformer.Omop.CareSite;
using OmopTransformer.Omop.Provider;
using OmopTransformer.Transformation;
using OmopTransformer.Omop;

namespace OmopTransformer.SUS.APC;

internal class SusAPCTransformer : Transformer
{
    private readonly ILocationRecorder _locationRecorder;
    private readonly IPersonRecorder _personRecorder;
    private readonly IMeasurementRecorder _measurementRecorder;
    private readonly IConditionOccurrenceRecorder _conditionOccurrenceRecorder;
    private readonly IVisitOccurrenceRecorder _visitOccurrenceRecorder;
    private readonly IVisitDetailRecorder _visitDetailRecorder;
    private readonly IDeathRecorder _deathRecorder;
    private readonly IProcedureOccurrenceRecorder _procedureOccurrenceRecorder;
    private readonly IObservationRecorder _observationRecorder;
    private readonly ConceptResolver _conceptResolver;
    private readonly ICareSiteRecorder _careSiteRecorder;
    private readonly IProviderRecorder _providerRecorder;

    public SusAPCTransformer(
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
        IObservationRecorder observationRecorder,
        IConceptMapper conceptMapper,
        IRunAnalysisRecorder runAnalysisRecorder) : 
        base(
            recordTransformer,
            logger,
            transformOptions,
            recordProvider,
            "SUSAPC",
            conceptMapper,
            runAnalysisRecorder)
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
        _observationRecorder = observationRecorder;
        _careSiteRecorder = careSiteRecorder;
        _providerRecorder = providerRecorder;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        Guid runId = Guid.NewGuid();

        await Transform<SusAPCPersonRecord, SusAPCPerson>(
          _personRecorder.InsertUpdatePersons,
          "Sus Apc Person",
          runId,
          cancellationToken);

        await Transform<SusAPCDeathRecord, SusAPCDeath>(
          _deathRecorder.InsertUpdateDeaths,
          "SUS APC Death",
          runId,
          cancellationToken);

        await Transform<SusAPCProcedureOccurrenceRecord, SusAPCProcedureOccurrence>(
          _procedureOccurrenceRecorder.InsertUpdateProcedureOccurrence,
          "SUS APC Procedure Occurrence",
          runId,
          cancellationToken);

        await Transform<SusAPCConditionOccurrenceRecord, SusAPCConditionOccurrence>(
          _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
          "SUS APC Conditon Occurrence",
          runId,
          cancellationToken);

        await Transform<SusAPCLocationRecord, SusAPCLocation>(
          _locationRecorder.InsertUpdateLocations,
          "SUS APC Location",
          runId,
          cancellationToken);

        await Transform<SusAPCVisitOccurrenceWithSpellRecord, SusAPCVisitOccurrenceWithSpell>(
          _visitOccurrenceRecorder.InsertUpdateVisitOccurrence,
          "SUS APC VisitOccurrenceWithSpell",
          runId,
          cancellationToken);

        await Transform<SusAPCAnaestheticDuringLabourDeliveryRecord, SusAPCAnaestheticDuringLabourDelivery>(
          _observationRecorder.InsertUpdateObservations,
        "SUS APC AnaestheticDuringLabourDelivery",
          runId,
          cancellationToken);

        await Transform<SusAPCAnaestheticGivenPostLabourDeliveryRecord, SusAPCAnaestheticGivenPostLabourDelivery>(
          _observationRecorder.InsertUpdateObservations,
          "SUS APC AnaestheticGivenPostLabourDelivery",
          runId,
          cancellationToken);

        await Transform<SusAPCBirthWeightRecord, SusAPCBirthWeight>(
          _observationRecorder.InsertUpdateObservations,
          "SUS APC BirthWeight",
          runId,
          cancellationToken);

        await Transform<SusAPCCarerSupportIndicatorRecord, SusAPCCarerSupportIndicator>(
          _observationRecorder.InsertUpdateObservations,
          "SUS APC CarerSupportIndicator",
          runId,
          cancellationToken);

        await Transform<SusAPCGestationLengthLabourOnsetRecord, SusAPCGestationLengthLabourOnset>(
          _observationRecorder.InsertUpdateObservations,
          "SUS APC GestationLengthLabourOnset",
          runId,
          cancellationToken);

        await Transform<SusAPCNumberOfBabiesRecord, SusAPCNumberOfBabies>(
          _observationRecorder.InsertUpdateObservations,
          "SUS APC NumberOfBabies",
          runId,
          cancellationToken);

        await Transform<SusAPCTotalPreviousPregnanciesRecord, SusAPCTotalPreviousPregnancies>(
          _observationRecorder.InsertUpdateObservations,
          "SUS APC TotalPreviousPregnancies",
          runId,
          cancellationToken);

        await Transform<SusAPCSourceOfReferralForOutpatientsRecord, SusAPCSourceOfReferralForOutpatients>(
          _observationRecorder.InsertUpdateObservations,
          "SUS APC SourceOfReferralForOutpatients",
          runId,
          cancellationToken);

        await Transform<SusAPCVisitDetailsRecord, SusAPCVisitDetail>(
          _visitDetailRecorder.InsertUpdateVisitDetail,
          "SUS APC VisitDetail",
          runId,
          cancellationToken);

        await Transform<SusAPCCareSiteRecord, SusAPCCareSite>(
           _careSiteRecorder.InsertUpdateCareSite,
           "SUS APC CareSite",
           runId,
           cancellationToken);

        await Transform<SusAPCProviderRecord, SusAPCProvider>(
           _providerRecorder.InsertUpdateProvider,
           "SUS APC Provider",
           runId,
           cancellationToken);

        await Transform<SusAPCMeasurementRecord, SusAPCMeasurement>(
            _measurementRecorder.InsertUpdateMeasurements,
            "SUS APC Measurements",
            runId,
            cancellationToken);

        _conceptResolver.PrintErrors();
    }
}
