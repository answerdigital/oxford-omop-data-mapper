using Microsoft.Extensions.Logging;
using OmopTransformer.SUS.OP.Death;
using OmopTransformer.SUS.OP.Location;
using OmopTransformer.SUS.OP.ConditionOccurrence;
using OmopTransformer.SUS.OP.ProcedureOccurrence;
using OmopTransformer.SUS.OP.Measurements.SusOPMeasurement;
using OmopTransformer.SUS.OP.VisitOccurrenceWithSpell;
using OmopTransformer.SUS.OP.VisitDetails;
using OmopTransformer.SUS.OP.Observation.CarerSupportIndicator;
using OmopTransformer.SUS.OP.Observation.SourceOfReferralForOutpatients;
using OmopTransformer.SUS.OP.CareSite;
using OmopTransformer.SUS.OP.Provider;
using OmopTransformer.Omop.Measurement;
using OmopTransformer.Omop.ConditionOccurrence;
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

namespace OmopTransformer.SUS.OP;

internal class SusOPTransformer : Transformer
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

    public SusOPTransformer(
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
        IRunAnalysisRecorder runAnalysisRecorder) : base(recordTransformer,
        logger,
        transformOptions,
        recordProvider,
        "SUSOP",
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

        await Transform<SusOPPersonRecord, SusOPPerson>(
           _personRecorder.InsertUpdatePersons,
           "Sus OP Person",
           runId,
           cancellationToken);

        await Transform<SusOPLocationRecord, SusOPLocation>(
           _locationRecorder.InsertUpdateLocations,
           "SUS OP Location",
           runId,
           cancellationToken);

        await Transform<SusOPDeathRecord, SusOPDeath>(
            _deathRecorder.InsertUpdateDeaths,
            "SUS OP Death",
            runId,
            cancellationToken);

        await Transform<SusOPMeasurementRecord, SusOPMeasurement>(
            _measurementRecorder.InsertUpdateMeasurements,
            "SUS OP Measurements",
            runId,
            cancellationToken);

        await Transform<SusOPProcedureOccurrenceRecord, SusOPProcedureOccurrence>(
           _procedureOccurrenceRecorder.InsertUpdateProcedureOccurrence,
           "SUS OP Procedure Occurrence",
           runId,
           cancellationToken);

        await Transform<SusOPConditionOccurrenceRecord, SusOPConditionOccurrence>(
           _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
           "SUS OP Conditon Occurrence",
           runId,
           cancellationToken);

        await Transform<SusOPVisitOccurrenceWithSpellRecord, SusOPVisitOccurrenceWithSpell>(
            _visitOccurrenceRecorder.InsertUpdateVisitOccurrence,
            "SUS OP VisitOccurrenceWithSpell",
            runId,
            cancellationToken);

        await Transform<SusOPVisitDetailsRecord, SusOPVisitDetail>(
            _visitDetailRecorder.InsertUpdateVisitDetail,
            "SUS OP VisitDetail",
            runId,
            cancellationToken);

        await Transform<SusOPCarerSupportIndicatorRecord, SusOPCarerSupportIndicator>(
           _observationRecorder.InsertUpdateObservations,
           "SUS OP CarerSupportIndicator",
           runId,
           cancellationToken);

        await Transform<SusOPSourceOfReferralForOutpatientsRecord, SusOPSourceOfReferralForOutpatients>(
           _observationRecorder.InsertUpdateObservations,
           "SUS OP SourceOfReferralForOutpatients",
           runId,
           cancellationToken);

        await Transform<SusOPCareSiteRecord, SusOPCareSite>(
           _careSiteRecorder.InsertUpdateCareSite,
           "SUS OP CareSite",
           runId,
           cancellationToken);

        await Transform<SusOPProviderRecord, SusOPProvider>(
           _providerRecorder.InsertUpdateProvider,
           "SUS OP Provider",
           runId,
           cancellationToken);

        _conceptResolver.PrintErrors();
    }
}