using Microsoft.Extensions.Logging;
using OmopTransformer.COSD.ConditionOccurrence.CosdConditionOccurrencePrimaryDiagnosis;
using OmopTransformer.COSD.ConditionOccurrence.CosdConditionOccurrencePrimaryDiagnosisHistologyTopography;
using OmopTransformer.COSD.ConditionOccurrence.CosdConditionOccurrenceProgression;
using OmopTransformer.COSD.ConditionOccurrence.CosdConditionOccurrenceRecurrence;
using OmopTransformer.COSD.ConditionOccurrence.CosdConditionOccurrenceSecondaryDiagnosis;
using OmopTransformer.COSD.ConditionOccurrence.CosdV8ConditionOccurrencePrimaryDiagnosis;
using OmopTransformer.COSD.ConditionOccurrence.CosdV8ConditionOccurrencePrimaryDiagnosisHistologyTopography;
using OmopTransformer.COSD.Death.v8Death;
using OmopTransformer.COSD.Death.v9DeathBasisOfDiagnosisCancer;
using OmopTransformer.COSD.Death.v9DeathDischargeDestination;
using OmopTransformer.COSD.Demographics;
using OmopTransformer.COSD.Observation.CosdV8AdultComorbidityEvaluation;
using OmopTransformer.COSD.Observation.CosdV8AdultPerformanceStatus;
using OmopTransformer.COSD.Observation.CosdV8AlcoholHistoryCancerBeforeLastThreeMonths;
using OmopTransformer.COSD.Observation.CosdV8AlcoholHistoryCancerInLastThreeMonths;
using OmopTransformer.COSD.Observation.CosdV8FamilialCancerSyndromeIndicator;
using OmopTransformer.COSD.Observation.CosdV8PersonStatedSexualOrientationCodeAtDiagnosis;
using OmopTransformer.COSD.Observation.CosdV8SmokingStatusCode;
using OmopTransformer.COSD.Observation.CosdV8SourceOfReferralForOutPatientsNonPrimaryCancerPathway;
using OmopTransformer.COSD.Observation.CosdV8SourceOfReferralOutPatients;
using OmopTransformer.COSD.Observation.CosdV9AdultComorbidityEvaluation;
using OmopTransformer.COSD.Observation.CosdV9AsaScore;
using OmopTransformer.COSD.Observation.CosdV9FamilialCancerSyndrome;
using OmopTransformer.COSD.Observation.CosdV9FamilialCancerSyndromeSubsidiaryComment;
using OmopTransformer.COSD.Observation.CosdV9HistoryOfAlcoholCurrent;
using OmopTransformer.COSD.Observation.CosdV9HistoryOfAlcoholPast;
using OmopTransformer.COSD.Observation.CosdV9MenopausalStatus;
using OmopTransformer.COSD.Observation.CosdV9PerformanceStatusAdult;
using OmopTransformer.COSD.Observation.CosdV9PersonSexualOrientationCodeAtDiagnosis;
using OmopTransformer.COSD.Observation.CosdV9SourceOfReferralForNonPrimaryCancerPathway;
using OmopTransformer.COSD.Observation.CosdV9SourceOfReferralForOutpatients;
using OmopTransformer.COSD.Observation.CosdV9TobaccoSmokingCessation;
using OmopTransformer.COSD.Observation.CosdV9TobaccoSmokingStatus;
using OmopTransformer.COSD.ProcedureOccurrence.CosdV8ProcedureOccurrencePrimaryProcedureOpcs;
using OmopTransformer.COSD.ProcedureOccurrence.CosdV8ProcedureOccurrenceProcedureOpcs;
using OmopTransformer.COSD.ProcedureOccurrence.CosdV9ProcedureOccurrencePrimaryProcedureOpcs;
using OmopTransformer.COSD.ProcedureOccurrence.CosdV9ProcedureOccurrenceProcedureOpcs;
using OmopTransformer.Omop.ConditionOccurrence;
using OmopTransformer.Omop.Death;
using OmopTransformer.Omop.Location;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Omop.Person;
using OmopTransformer.Omop.ProcedureOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD;

internal class CosdTransformer : Transformer
{
    private readonly ILocationRecorder _locationRecorder;
    private readonly IPersonRecorder _personRecorder;
    private readonly IDeathRecorder _deathRecorder;
    private readonly IConditionOccurrenceRecorder _conditionOccurrenceRecorder;
    private readonly IProcedureOccurrenceRecorder _procedureOccurrenceRecorder;
    private readonly IObservationRecorder _observationRecorder;

    public CosdTransformer(
        IRecordTransformer recordTransformer, 
        ILogger<IRecordTransformer> logger, 
        TransformOptions transformOptions, 
        IRecordProvider recordProvider, 
        ILocationRecorder locationRecorder, 
        IPersonRecorder personRecorder, 
        IDeathRecorder deathRecorder, 
        IConditionOccurrenceRecorder conditionOccurrenceRecorder, 
        IProcedureOccurrenceRecorder procedureOccurrenceRecorder, 
        IObservationRecorder observationRecorder) 
        : 
        base(
            recordTransformer, 
            logger, 
            transformOptions, 
            recordProvider, 
            "COSD")
    {
        _locationRecorder = locationRecorder;
        _personRecorder = personRecorder;
        _deathRecorder = deathRecorder;
        _conditionOccurrenceRecorder = conditionOccurrenceRecorder;
        _procedureOccurrenceRecorder = procedureOccurrenceRecorder;
        _observationRecorder = observationRecorder;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        await Transform<CosdDemographics, CosdPerson>(
            _personRecorder.InsertUpdatePersons,
            "COSD Person",
            cancellationToken);

        await Transform<CosdDemographics, CosdLocation>(
            _locationRecorder.InsertUpdateLocations,
            "COSD Location",
            cancellationToken);

        await Transform<CosdDemographics, CosdLocation>(
            _locationRecorder.InsertUpdateLocations,
            "COSD Location",
            cancellationToken);

        await Transform<CosdV8DeathRecord, CosdV8Death>(
            _deathRecorder.InsertUpdateDeaths,
            "COSD V8 Death",
            cancellationToken);

        await Transform<CosdV9DeathDischargeDestinationRecord, CosdDeathV9DeathDischargeDestination>(
            _deathRecorder.InsertUpdateDeaths,
            "COSD V9 DeathDischargeDestination Death",
            cancellationToken);

        await Transform<CosdV9BasisOfDiagnosisCancerRecord, CosdV9DeathBasisOfDiagnosisCancer>(
            _deathRecorder.InsertUpdateDeaths,
            "COSD V9 BasisOfDiagnosisCancer Death",
            cancellationToken);

        await Transform<CosdV9ConditionOccurrencePrimaryDiagnosisRecord, CosdConditionOccurrencePrimaryDiagnosis>(
            _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
            "Cosd V9 Condition Occurrence Primary Diagnosis",
            cancellationToken);

        await Transform<CosdV9ConditionOccurrencePrimaryDiagnosisHistologyTopographyRecord, CosdConditionOccurrencePrimaryDiagnosisHistologyTopography>(
            _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
            "Cosd Condition Occurrence Primary Diagnosis Histology Topography",
            cancellationToken);

        await Transform<CosdV9ConditionOccurrenceProgressionRecord, CosdV9ConditionOccurrenceProgression>(
            _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
            "Cosd V9 Condition Occurrence Progression",
            cancellationToken);

        await Transform<CosdV9ConditionOccurrenceRecurrenceRecord, CosdV9ConditionOccurrenceRecurrence>(
            _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
            "Cosd V9 Condition Occurrence Recurrence",
            cancellationToken);

        await Transform<CosdV9ConditionOccurrenceSecondaryDiagnosisRecord, CosdV9ConditionOccurrenceSecondaryDiagnosis>(
            _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
            "Cosd V9 Condition Occurrence Secondary Diagnosis",
            cancellationToken);

        await Transform<CosdV8ConditionOccurrencePrimaryDiagnosisRecord, CosdV8ConditionOccurrencePrimaryDiagnosis>(
            _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
            "Cosd V8 Condition Occurrence Primary Diagnosis",
            cancellationToken);

        await Transform<CosdV8ConditionOccurrencePrimaryDiagnosisHistologyTopographyRecord, CosdV8ConditionOccurrencePrimaryDiagnosisHistologyTopography>(
            _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
            "Cosd V8 Condition Occurrence Primary Diagnosis Histology Topography",
            cancellationToken);

        await Transform<CosdV8ProcedureOccurrencePrimaryProcedureOpcsRecord, CosdV8ProcedureOccurrencePrimaryProcedureOpcs>(
            _procedureOccurrenceRecorder.InsertUpdateProcedureOccurrence,
            "Cosd V8 Procedure Occurrence Primary Procedure Opcs",
            cancellationToken);

        await Transform<CosdV8ProcedureOccurrenceProcedureOpcsRecord, CosdV8ProcedureOccurrenceProcedureOpcs>(
            _procedureOccurrenceRecorder.InsertUpdateProcedureOccurrence,
            "Cosd V8 Procedure Occurrence Procedure Opcs",
            cancellationToken);

        await Transform<CosdV9ProcedureOccurrencePrimaryProcedureOpcsRecord, CosdV9ProcedureOccurrencePrimaryProcedureOpcs>(
            _procedureOccurrenceRecorder.InsertUpdateProcedureOccurrence,
            "Cosd V9 Procedure Occurrence Primary Procedure Opcs",
            cancellationToken);

        await Transform<CosdV9ProcedureOccurrenceProcedureOpcsRecord, CosdV9ProcedureOccurrenceProcedureOpcs>(
            _procedureOccurrenceRecorder.InsertUpdateProcedureOccurrence,
            "Cosd V9 Procedure Occurrence Procedure Opcs",
            cancellationToken);

        await Transform<CosdV9TobaccoSmokingStatusRecord, CosdV9TobaccoSmokingStatus>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9TobaccoSmokingStatus",
            cancellationToken);

        await Transform<CosdV8SmokingStatusCodeRecord, CosdV8SmokingStatusCode>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV8SmokingStatusCode",
            cancellationToken);

        await Transform<CosdV9TobaccoSmokingCessationRecord, CosdV9TobaccoSmokingCessation>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9TobaccoSmokingCessation",
            cancellationToken);

        await Transform<CosdV9HistoryOfAlcoholCurrentRecord, CosdV9HistoryOfAlcoholCurrent>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9HistoryOfAlcoholCurrent",
            cancellationToken);

        await Transform<CosdV8AlcoholHistoryCancerInLastThreeMonthsRecord, CosdV8AlcoholHistoryCancerInLastThreeMonths>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV8AlcoholHistoryCancerInLastThreeMonths",
            cancellationToken);

        await Transform<CosdV9HistoryOfAlcoholPastRecord, CosdV9HistoryOfAlcoholPast>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9HistoryOfAlcoholPast",
            cancellationToken);

        await Transform<CosdV8AlcoholHistoryCancerBeforeLastThreeMonthsRecord, CosdV8AlcoholHistoryCancerBeforeLastThreeMonths>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV8AlcoholHistoryCancerBeforeLastThreeMonths",
            cancellationToken);

        await Transform<CosdV9MenopausalStatusRecord, CosdV9MenopausalStatus>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9MenopausalStatus",
            cancellationToken);

        await Transform<CosdV9PersonSexualOrientationCodeAtDiagnosisRecord, CosdV9PersonSexualOrientationCodeAtDiagnosis>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9PersonSexualOrientationCodeAtDiagnosis",
            cancellationToken);

        await Transform<CosdV8PersonStatedSexualOrientationCodeAtDiagnosisRecord, CosdV8PersonStatedSexualOrientationCodeAtDiagnosis>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV8PersonStatedSexualOrientationCodeAtDiagnosis",
            cancellationToken);

        await Transform<CosdV9SourceOfReferralForOutpatientsRecord, CosdV9SourceOfReferralForOutpatients>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9SourceOfReferralForOutpatients",
            cancellationToken);

        await Transform<CosdV8SourceOfReferralOutPatientsRecord, CosdV8SourceOfReferralOutPatients>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV8SourceOfReferralOutPatients",
            cancellationToken);

        await Transform<CosdV9SourceOfReferralForNonPrimaryCancerPathwayRecord, CosdV9SourceOfReferralForNonPrimaryCancerPathway>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9SourceOfReferralForNonPrimaryCancerPathway",
            cancellationToken);

        await Transform<CosdV8SourceOfReferralForOutPatientsNonPrimaryCancerPathwayRecord, CosdV8SourceOfReferralForOutPatientsNonPrimaryCancerPathway>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV8SourceOfReferralForOutPatientsNonPrimaryCancerPathway",
            cancellationToken);

        await Transform<CosdV9PerformanceStatusAdultRecord, CosdV9PerformanceStatusAdult>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9PerformanceStatusAdult",
            cancellationToken);

        await Transform<CosdV8AdultPerformanceStatusRecord, CosdV8AdultPerformanceStatus>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV8AdultPerformanceStatus",
            cancellationToken);

        await Transform<CosdV9AdultComorbidityEvaluationRecord, CosdV9AdultComorbidityEvaluation>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9AdultComorbidityEvaluation",
            cancellationToken);

        await Transform<CosdV8AdultComorbidityEvaluationRecord, CosdV8AdultComorbidityEvaluation>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV8AdultComorbidityEvaluation",
            cancellationToken);

        await Transform<CosdV9AsaScoreRecord, CosdV9AsaScore>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9AsaScore",
            cancellationToken);

        await Transform<CosdV9FamilialCancerSyndromeRecord, CosdV9FamilialCancerSyndrome>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9FamilialCancerSyndrome",
            cancellationToken);

        await Transform<CosdV8FamilialCancerSyndromeIndicatorRecord, CosdV8FamilialCancerSyndromeIndicator>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV8FamilialCancerSyndromeIndicator",
            cancellationToken);

        await Transform<CosdV9FamilialCancerSyndromeSubsidiaryCommentRecord, CosdV9FamilialCancerSyndromeSubsidiaryComment>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9FamilialCancerSyndromeSubsidiaryComment",
            cancellationToken);
    }
}