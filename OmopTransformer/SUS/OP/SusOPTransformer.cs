using Microsoft.Extensions.Logging;
using OmopTransformer.SUS.OP.Death;
using OmopTransformer.SUS.OP.Location;
//using OmopTransformer.SUS.OP.ConditionOccurrence;
//using OmopTransformer.SUS.OP.ProcedureOccurrence;
//using OmopTransformer.SUS.OP.VisitOccurrenceWithoutSpell;
//using OmopTransformer.SUS.OP.VisitOccurrenceWithSpell;
//using OmopTransformer.SUS.OP.Observation.AnaestheticDuringLabourDelivery;
//using OmopTransformer.SUS.OP.Observation.AnaestheticGivenPostLabourDelivery;
//using OmopTransformer.SUS.OP.Observation.BirthWeight;
//using OmopTransformer.SUS.OP.Observation.CarerSupportIndicator;
//using OmopTransformer.SUS.OP.Observation.GestationLengthLabourOnset;
//using OmopTransformer.SUS.OP.Observation.NumberOfBabies;
//using OmopTransformer.SUS.OP.Observation.TotalPreviousPregnancies;
//using OmopTransformer.SUS.OP.VisitDetails;
//using OmopTransformer.SUS.OP.CareSite;
//using OmopTransformer.SUS.OP.Provider;
using OmopTransformer.Omop.ConditionOccurrence;
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



namespace OmopTransformer.SUS.OP;

internal class SusOPTransformer : Transformer
{
    private readonly ILocationRecorder _locationRecorder;
    private readonly IPersonRecorder _personRecorder;
    private readonly IConditionOccurrenceRecorder _conditionOccurrenceRecorder;
    private readonly IVisitOccurrenceRecorder _visitOccurrenceRecorder;
    private readonly IVisitDetailRecorder _visitDetailRecorder;
    private readonly IDeathRecorder _deathRecorder;
    private readonly IProcedureOccurrenceRecorder _procedureOccurrenceRecorder;
    private readonly IDrugExposureRecorder _drugExposureRecorder;
    private readonly IObservationRecorder _observationRecorder;
    private readonly ConceptSnomedResolver _conceptSnomedResolver;
    private readonly ICareSiteRecorder _careSiteRecorder;
    private readonly IProviderRecorder _providerRecorder;

    public SusOPTransformer(
        ICareSiteRecorder careSiteRecorder,
        IProviderRecorder providerRecorder,
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
        ConceptSnomedResolver conceptSnomedResolver, 
        IDrugExposureRecorder drugExposureRecorder, 
        IObservationRecorder observationRecorder) : base(recordTransformer,
        logger,
        transformOptions,
        recordProvider,
        "SUSOP")
    {
        _locationRecorder = locationRecorder;
        _personRecorder = personRecorder;
        _conditionOccurrenceRecorder = conditionOccurrenceRecorder;
        _visitOccurrenceRecorder = visitOccurrenceRecorder;
        _visitDetailRecorder = visitDetailRecorder;
        _deathRecorder = deathRecorder;
        _procedureOccurrenceRecorder = procedureOccurrenceRecorder;
        _conceptSnomedResolver = conceptSnomedResolver;
        _drugExposureRecorder = drugExposureRecorder;
        _observationRecorder = observationRecorder;
        _careSiteRecorder = careSiteRecorder;
        _providerRecorder = providerRecorder;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        await Transform<SusOPPersonRecord, SusOPPerson>(
           _personRecorder.InsertUpdatePersons,
           "Sus OP Person",
           cancellationToken);

        await Transform<SusOPLocationRecord, SusOPLocation>(
           _locationRecorder.InsertUpdateLocations,
           "SUS OP Location",
           cancellationToken);

        await Transform<SusOPDeathRecord, SusOPDeath>(
            _deathRecorder.InsertUpdateDeaths,
            "SUS OP Death",
            cancellationToken);

        //await Transform<SusOPProcedureOccurrenceRecord, SusOPProcedureOccurrence>(
        //    _procedureOccurrenceRecorder.InsertUpdateProcedureOccurrence,
        //    "SUS OP Procedure Occurrence",
        //    cancellationToken);

        //await Transform<SusOPConditionOccurrenceRecord, SusOPConditionOccurrence>(
        //    _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
        //    "SUS OP Conditon Occurrence",
        //    cancellationToken);

        //await Transform<SusOPVisitOccurrenceWithSpellRecord, SusOPVisitOccurrenceWithSpell>(
        //    _visitOccurrenceRecorder.InsertUpdateVisitOccurrence,
        //    "SUS OP VisitOccurrenceWithSpell",
        //    cancellationToken);

        //await Transform<SusOPVisitOccurrenceWithoutSpellRecord, SusOPVisitOccurrenceWithoutSpell>(
        //    _visitOccurrenceRecorder.InsertUpdateVisitOccurrence,
        //    "SUS OP VisitOccurrenceWithoutSpell",
        //    cancellationToken);

        //await Transform<SusOPAnaestheticDuringLabourDeliveryRecord, SusOPAnaestheticDuringLabourDelivery>(
        //    _observationRecorder.InsertUpdateObservations,
        //"SUS OP AnaestheticDuringLabourDelivery",
        //    cancellationToken);

        //await Transform<SusOPAnaestheticGivenPostLabourDeliveryRecord, SusOPAnaestheticGivenPostLabourDelivery>(
        //    _observationRecorder.InsertUpdateObservations,
        //    "SUS OP AnaestheticGivenPostLabourDelivery",
        //    cancellationToken);

        //await Transform<SusOPBirthWeightRecord, SusOPBirthWeight>(
        //    _observationRecorder.InsertUpdateObservations,
        //    "SUS OP BirthWeight",
        //    cancellationToken);

        //await Transform<SusOPCarerSupportIndicatorRecord, SusOPCarerSupportIndicator>(
        //    _observationRecorder.InsertUpdateObservations,
        //    "SUS OP CarerSupportIndicator",
        //    cancellationToken);

        //await Transform<SusOPGestationLengthLabourOnsetRecord, SusOPGestationLengthLabourOnset>(
        //    _observationRecorder.InsertUpdateObservations,
        //    "SUS OP GestationLengthLabourOnset",
        //    cancellationToken);

        //await Transform<SusOPNumberOfBabiesRecord, SusOPNumberOfBabies>(
        //    _observationRecorder.InsertUpdateObservations,
        //    "SUS OP NumberOfBabies",
        //    cancellationToken);

        //await Transform<SusOPTotalPreviousPregnanciesRecord, SusOPTotalPreviousPregnancies>(
        //    _observationRecorder.InsertUpdateObservations,
        //    "SUS OP TotalPreviousPregnancies",
        //    cancellationToken);

        //await Transform<SusOPVisitDetailsRecord, SusOPVisitDetail>(
        //    _visitDetailRecorder.InsertUpdateVisitDetail,
        //    "SUS OP VisitDetail",
        //    cancellationToken);

        //await Transform<SusOPCareSiteRecord, SusOPCareSite>(
        //    _careSiteRecorder.InsertUpdateCareSite,
        //    "SUS OP CareSite",
        //    cancellationToken);

        //await Transform<SusOPProviderRecord, SusOPProvider>(
        //    _providerRecorder.InsertUpdateProvider,
        //    "SUS OP Provider",
        //    cancellationToken);

        _conceptSnomedResolver.PrintErrors();
    }
}