using Microsoft.Extensions.Logging;
using OmopTransformer.CDS.ConditionOccurrence;
using OmopTransformer.CDS.Death;
using OmopTransformer.CDS.DrugExposure;
using OmopTransformer.CDS.Observation.AnaestheticDuringLabourDelivery;
using OmopTransformer.CDS.Observation.AnaestheticGivenPostLabourDelivery;
using OmopTransformer.CDS.Observation.BirthWeight;
using OmopTransformer.CDS.Observation.CarerSupportIndicator;
using OmopTransformer.CDS.Observation.GestationLengthLabourOnset;
using OmopTransformer.CDS.Observation.NumberOfBabies;
using OmopTransformer.CDS.Observation.PersonWeight;
using OmopTransformer.CDS.Observation.SourceOfReferralForOutpatients;
using OmopTransformer.CDS.Observation.TotalPreviousPregnancies;
using OmopTransformer.CDS.Person;
using OmopTransformer.CDS.ProcedureOccurrence;
using OmopTransformer.CDS.StructuredAddress;
using OmopTransformer.CDS.UnstructuredAddress;
using OmopTransformer.CDS.VisitDetails;
using OmopTransformer.CDS.VisitOccurrenceWithoutSpell;
using OmopTransformer.CDS.VisitOccurrenceWithSpell;
using OmopTransformer.Omop.ConditionOccurrence;
using OmopTransformer.Omop.Death;
using OmopTransformer.Omop.DrugExposure;
using OmopTransformer.Omop.Location;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Omop.Person;
using OmopTransformer.Omop.ProcedureOccurrence;
using OmopTransformer.Omop.VisitDetail;
using OmopTransformer.Omop.VisitOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.CDS;

internal class CdsTransformer : Transformer
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

    public CdsTransformer(IRecordTransformer recordTransformer,
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
        "CDS")
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

        await Transform<CdsUnstructuredAddress, CdsUnstructuredLocation>(
            _locationRecorder.InsertUpdateLocations,
            "CDS Unstructured Address",
            cancellationToken);

        await Transform<CdsConditionOccurrenceRecord, CdsConditionOccurrence>(
            _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
            "CDS Condition Occurrences",
            cancellationToken);

        await Transform<CdsVisitOccurrenceWithSpellRecord, CdsVisitOccurrenceWithSpell>(
            _visitOccurrenceRecorder.InsertUpdateVisitOccurrence,
            "CDS VisitOccurrenceWithSpell",
            cancellationToken);

        await Transform<CdsVisitOccurrenceWithoutSpellRecord, CdsVisitOccurrenceWithoutSpell>(
            _visitOccurrenceRecorder.InsertUpdateVisitOccurrence,
            "CDS VisitOccurrenceWithoutSpell",
            cancellationToken);

        await Transform<CdsVisitDetailsRecord, CdsVisitDetail>(
            _visitDetailRecorder.InsertUpdateVisitDetail,
            "CDS VisitDetail",
            cancellationToken);

        await Transform<CdsDeathRecord, CdsDeath>(
            _deathRecorder.InsertUpdateDeaths,
            "CDS Death",
            cancellationToken);

        await Transform<CdsProcedureOccurrenceRecord, CdsProcedureOccurrence>(
            _procedureOccurrenceRecorder.InsertUpdateProcedureOccurrence,
            "CDS Procedure Occurrence",
            cancellationToken);

        await Transform<CdsDrugExposureRecord, CdsDrugExposure>(
            _drugExposureRecorder.InsertUpdateDrugExposure,
            "CDS Drug Exposure",
            cancellationToken);

        await Transform<CdsAnaestheticDuringLabourDeliveryRecord, CdsAnaestheticDuringLabourDelivery>(
            _observationRecorder.InsertUpdateObservations,
        "CdsAnaestheticDuringLabourDelivery",
            cancellationToken);

        await Transform<CdsAnaestheticGivenPostLabourDeliveryRecord, CdsAnaestheticGivenPostLabourDelivery>(
            _observationRecorder.InsertUpdateObservations,
            "Cds AnaestheticGivenPostLabourDelivery",
            cancellationToken);

        await Transform<CdsBirthWeightRecord, CdsBirthWeight>(
            _observationRecorder.InsertUpdateObservations,
            "Cds BirthWeight",
            cancellationToken);

        await Transform<CdsCarerSupportIndicatorRecord, CdsCarerSupportIndicator>(
            _observationRecorder.InsertUpdateObservations,
            "Cds CarerSupportIndicator",
            cancellationToken);

        await Transform<CdsGestationLengthLabourOnsetRecord, CdsGestationLengthLabourOnset>(
            _observationRecorder.InsertUpdateObservations,
            "Cds GestationLengthLabourOnset",
            cancellationToken);

        await Transform<CdsNumberOfBabiesRecord, CdsNumberOfBabies>(
            _observationRecorder.InsertUpdateObservations,
            "Cds NumberOfBabies",
            cancellationToken);

        await Transform<CdsPersonWeightRecord, CdsPersonWeight>(
            _observationRecorder.InsertUpdateObservations,
            "Cds PersonWeight",
            cancellationToken);

        await Transform<CdsSourceOfReferralForOutpatientsRecord, CdsSourceOfReferralForOutpatients>(
            _observationRecorder.InsertUpdateObservations,
            "Cds SourceOfReferralForOutpatients",
            cancellationToken);

        await Transform<CdsTotalPreviousPregnanciesRecord, CdsTotalPreviousPregnancies>(
            _observationRecorder.InsertUpdateObservations,
            "Cds TotalPreviousPregnancies",
            cancellationToken);

        _conceptSnomedResolver.PrintErrors();
    }
}