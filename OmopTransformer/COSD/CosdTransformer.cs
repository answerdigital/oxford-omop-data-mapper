using Microsoft.Extensions.Logging;
using OmopTransformer.COSD.Colorectal.ConditionOccurrence.CosdConditionOccurrencePrimaryDiagnosis;
using OmopTransformer.COSD.Colorectal.ConditionOccurrence.CosdConditionOccurrencePrimaryDiagnosisHistologyTopography;
using OmopTransformer.COSD.Colorectal.ConditionOccurrence.CosdConditionOccurrenceProgression;
using OmopTransformer.COSD.Colorectal.ConditionOccurrence.CosdConditionOccurrenceRecurrence;
using OmopTransformer.COSD.Colorectal.ConditionOccurrence.CosdConditionOccurrenceSecondaryDiagnosis;
using OmopTransformer.COSD.Colorectal.ConditionOccurrence.CosdV8ConditionOccurrencePrimaryDiagnosis;
using OmopTransformer.COSD.Colorectal.ConditionOccurrence.CosdV8ConditionOccurrencePrimaryDiagnosisHistologyTopography;
using OmopTransformer.COSD.Core.Death.v8Death;
using OmopTransformer.COSD.Core.Death.v9DeathBasisOfDiagnosisCancer;
using OmopTransformer.COSD.Core.Death.v9DeathDischargeDestination;
using OmopTransformer.COSD.Core.DemographicsV8;
using OmopTransformer.COSD.Core.DemographicsV9;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV8MeasurementGradeOfDifferentiation;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV8MeasurementMcategoryFinalPreTreatmentStage;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV8MeasurementMcategoryIntegratedStage;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV8MeasurementNcategoryFinalPreTreatmentStage;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV8MeasurementNcategoryIntegratedStage;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV8MeasurementNonPrimaryPathwayMetastasis;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV8MeasurementPrimaryPathwayMetastasis;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV8MeasurementSynchronousTumourIndicator;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV8MeasurementTcategoryFinalPreTreatmentStage;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV8MeasurementTcategoryIntegratedStage;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV8MeasurementTNMcategoryFinalPreTreatmentStage;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV8MeasurementTNMcategoryIntegratedStage;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV8MeasurementTumourHeightAboveAnalVerge;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV8MeasurementTumourLaterality;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV9MeasurementGradeOfDifferentiation;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV9MeasurementMcategoryFinalPreTreatmentStage;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV9MeasurementMcategoryIntegratedStage;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV9MeasurementNcategoryFinalPreTreatmentStage;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV9MeasurementNcategoryIntegratedStage;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV9MeasurementNonPrimaryPathwayProgressionMetastasis;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV9MeasurementNonPrimaryPathwayRecurrenceMetastasis;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV9MeasurementPrimaryPathwayMetastasis;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV9MeasurementSynchronousTumourIndicator;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV9MeasurementTcategoryFinalPreTreatmentStage;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV9MeasurementTcategoryIntegratedStage;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV9MeasurementTNMcategoryFinalPreTreatmentStage;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV9MeasurementTNMcategoryIntegratedStage;
using OmopTransformer.COSD.Colorectal.Measurements.CosdV9MeasurementTumourLaterality;
using OmopTransformer.COSD.Colorectal.Observation.CosdV8AdultComorbidityEvaluation;
using OmopTransformer.COSD.Colorectal.Observation.CosdV8AdultPerformanceStatus;
using OmopTransformer.COSD.Colorectal.Observation.CosdV8AlcoholHistoryCancerBeforeLastThreeMonths;
using OmopTransformer.COSD.Colorectal.Observation.CosdV8AlcoholHistoryCancerInLastThreeMonths;
using OmopTransformer.COSD.Colorectal.Observation.CosdV8FamilialCancerSyndromeIndicator;
using OmopTransformer.COSD.Colorectal.Observation.CosdV8PersonStatedSexualOrientationCodeAtDiagnosis;
using OmopTransformer.COSD.Colorectal.Observation.CosdV8SmokingStatusCode;
using OmopTransformer.COSD.Colorectal.Observation.CosdV8SourceOfReferralForOutPatientsNonPrimaryCancerPathway;
using OmopTransformer.COSD.Colorectal.Observation.CosdV8SourceOfReferralOutPatients;
using OmopTransformer.COSD.Colorectal.Observation.CosdV9AdultComorbidityEvaluation;
using OmopTransformer.COSD.Colorectal.Observation.CosdV9AsaScore;
using OmopTransformer.COSD.Colorectal.Observation.CosdV9FamilialCancerSyndrome;
using OmopTransformer.COSD.Colorectal.Observation.CosdV9FamilialCancerSyndromeSubsidiaryComment;
using OmopTransformer.COSD.Colorectal.Observation.CosdV9HistoryOfAlcoholCurrent;
using OmopTransformer.COSD.Colorectal.Observation.CosdV9HistoryOfAlcoholPast;
using OmopTransformer.COSD.Colorectal.Observation.CosdV9MenopausalStatus;
using OmopTransformer.COSD.Colorectal.Observation.CosdV9PerformanceStatusAdult;
using OmopTransformer.COSD.Colorectal.Observation.CosdV9PersonSexualOrientationCodeAtDiagnosis;
using OmopTransformer.COSD.Colorectal.Observation.CosdV9SourceOfReferralForNonPrimaryCancerPathway;
using OmopTransformer.COSD.Colorectal.Observation.CosdV9SourceOfReferralForOutpatients;
using OmopTransformer.COSD.Colorectal.Observation.CosdV9TobaccoSmokingCessation;
using OmopTransformer.COSD.Colorectal.Observation.CosdV9TobaccoSmokingStatus;
using OmopTransformer.COSD.Colorectal.ProcedureOccurrence.CosdV8ProcedureOccurrencePrimaryProcedureOpcs;
using OmopTransformer.COSD.Colorectal.ProcedureOccurrence.CosdV8ProcedureOccurrenceProcedureOpcs;
using OmopTransformer.COSD.Colorectal.ProcedureOccurrence.CosdV9ProcedureOccurrencePrimaryProcedureOpcs;
using OmopTransformer.COSD.Colorectal.ProcedureOccurrence.CosdV9ProcedureOccurrenceProcedureOpcs;
using OmopTransformer.Omop;
using OmopTransformer.Omop.ConditionOccurrence;
using OmopTransformer.Omop.Death;
using OmopTransformer.Omop.Location;
using OmopTransformer.Omop.Measurement;
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
    private readonly IMeasurementRecorder _measurementRecorder;

    public CosdTransformer(
        IRecordTransformer recordTransformer,
        TransformOptions transformOptions,
        IRecordProvider recordProvider,
        ILocationRecorder locationRecorder,
        IPersonRecorder personRecorder,
        IDeathRecorder deathRecorder,
        IConditionOccurrenceRecorder conditionOccurrenceRecorder,
        IProcedureOccurrenceRecorder procedureOccurrenceRecorder,
        IObservationRecorder observationRecorder,
        IMeasurementRecorder measurementRecorder,
        IRunAnalysisRecorder runAnalysisRecorder,
        ILoggerFactory loggerFactory)
        :
        base(
            recordTransformer,
            transformOptions,
            recordProvider,
            "COSD",
            runAnalysisRecorder,
            loggerFactory)
    {
        _locationRecorder = locationRecorder;
        _personRecorder = personRecorder;
        _deathRecorder = deathRecorder;
        _conditionOccurrenceRecorder = conditionOccurrenceRecorder;
        _procedureOccurrenceRecorder = procedureOccurrenceRecorder;
        _observationRecorder = observationRecorder;
        _measurementRecorder = measurementRecorder;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        Guid runId = Guid.NewGuid();

        await Transform<CosdDemographicsV9, CosdPersonV9>(
            _personRecorder.InsertUpdatePersons,
            "COSD V9 Person",
            runId,
            cancellationToken);

        await Transform<CosdDemographicsV8, CosdPersonV8>(
            _personRecorder.InsertUpdatePersons,
            "COSD V8 Person",
            runId,
            cancellationToken);
        
        await Transform<CosdDemographicsV8, CosdV8Location>(
            _locationRecorder.InsertUpdateLocations,
            "COSD V8 Location",
            runId,
            cancellationToken);

        await Transform<CosdDemographicsV9, CosdLocationV9>(
            _locationRecorder.InsertUpdateLocations,
            "COSD V9 Location",
            runId,
            cancellationToken);

        await Transform<CosdV8DeathRecord, CosdV8Death>(
            _deathRecorder.InsertUpdateDeaths,
            "COSD V8 Death",
            runId,
            cancellationToken);

        await Transform<CosdV9DeathDischargeDestinationRecord, CosdDeathV9DeathDischargeDestination>(
            _deathRecorder.InsertUpdateDeaths,
            "COSD V9 DeathDischargeDestination Death",
            runId,
            cancellationToken);

        await Transform<CosdV9BasisOfDiagnosisCancerRecord, CosdV9DeathBasisOfDiagnosisCancer>(
            _deathRecorder.InsertUpdateDeaths,
            "COSD V9 BasisOfDiagnosisCancer Death",
            runId,
            cancellationToken);

        await Transform<CosdV9ConditionOccurrencePrimaryDiagnosisRecord, CosdConditionOccurrencePrimaryDiagnosis>(
            _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
            "Cosd V9 Condition Occurrence Primary Diagnosis",
            runId,
            cancellationToken);

        await Transform<CosdV9ConditionOccurrencePrimaryDiagnosisHistologyTopographyRecord, CosdConditionOccurrencePrimaryDiagnosisHistologyTopography>(
            _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
            "Cosd Condition Occurrence Primary Diagnosis Histology Topography",
            runId,
            cancellationToken);

        await Transform<CosdV9ConditionOccurrenceProgressionRecord, CosdV9ConditionOccurrenceProgression>(
            _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
            "Cosd V9 Condition Occurrence Progression",
            runId,
            cancellationToken);

        await Transform<CosdV9ConditionOccurrenceRecurrenceRecord, CosdV9ConditionOccurrenceRecurrence>(
            _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
            "Cosd V9 Condition Occurrence Recurrence",
            runId,
            cancellationToken);

        await Transform<CosdV9ConditionOccurrenceSecondaryDiagnosisRecord, CosdV9ConditionOccurrenceSecondaryDiagnosis>(
            _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
            "Cosd V9 Condition Occurrence Secondary Diagnosis",
            runId,
            cancellationToken);

        await Transform<CosdV8ConditionOccurrencePrimaryDiagnosisRecord, CosdV8ConditionOccurrencePrimaryDiagnosis>(
            _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
            "Cosd V8 Condition Occurrence Primary Diagnosis",
            runId,
            cancellationToken);

        await Transform<CosdV8ConditionOccurrencePrimaryDiagnosisHistologyTopographyRecord, CosdV8ConditionOccurrencePrimaryDiagnosisHistologyTopography>(
            _conditionOccurrenceRecorder.InsertUpdateConditionOccurrence,
            "Cosd V8 Condition Occurrence Primary Diagnosis Histology Topography",
            runId,
            cancellationToken);

        await Transform<CosdV8ProcedureOccurrencePrimaryProcedureOpcsRecord, CosdV8ProcedureOccurrencePrimaryProcedureOpcs>(
            _procedureOccurrenceRecorder.InsertUpdateProcedureOccurrence,
            "Cosd V8 Procedure Occurrence Primary Procedure Opcs",
            runId,
            cancellationToken);

        await Transform<CosdV8ProcedureOccurrenceProcedureOpcsRecord, CosdV8ProcedureOccurrenceProcedureOpcs>(
            _procedureOccurrenceRecorder.InsertUpdateProcedureOccurrence,
            "Cosd V8 Procedure Occurrence Procedure Opcs",
            runId,
            cancellationToken);

        await Transform<CosdV9ProcedureOccurrencePrimaryProcedureOpcsRecord, CosdV9ProcedureOccurrencePrimaryProcedureOpcs>(
            _procedureOccurrenceRecorder.InsertUpdateProcedureOccurrence,
            "Cosd V9 Procedure Occurrence Primary Procedure Opcs",
            runId,
            cancellationToken);

        await Transform<CosdV9ProcedureOccurrenceProcedureOpcsRecord, CosdV9ProcedureOccurrenceProcedureOpcs>(
            _procedureOccurrenceRecorder.InsertUpdateProcedureOccurrence,
            "Cosd V9 Procedure Occurrence Procedure Opcs",
            runId,
            cancellationToken);

        await Transform<CosdV9TobaccoSmokingStatusRecord, CosdV9TobaccoSmokingStatus>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9TobaccoSmokingStatus",
            runId,
            cancellationToken);

        await Transform<CosdV8SmokingStatusCodeRecord, CosdV8SmokingStatusCode>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV8SmokingStatusCode",
            runId,
            cancellationToken);

        await Transform<CosdV9TobaccoSmokingCessationRecord, CosdV9TobaccoSmokingCessation>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9TobaccoSmokingCessation",
            runId,
            cancellationToken);

        await Transform<CosdV9HistoryOfAlcoholCurrentRecord, CosdV9HistoryOfAlcoholCurrent>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9HistoryOfAlcoholCurrent",
            runId,
            cancellationToken);

        await Transform<CosdV8AlcoholHistoryCancerInLastThreeMonthsRecord, CosdV8AlcoholHistoryCancerInLastThreeMonths>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV8AlcoholHistoryCancerInLastThreeMonths",
            runId,
            cancellationToken);

        await Transform<CosdV9HistoryOfAlcoholPastRecord, CosdV9HistoryOfAlcoholPast>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9HistoryOfAlcoholPast",
            runId,
            cancellationToken);

        await Transform<CosdV8AlcoholHistoryCancerBeforeLastThreeMonthsRecord, CosdV8AlcoholHistoryCancerBeforeLastThreeMonths>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV8AlcoholHistoryCancerBeforeLastThreeMonths",
            runId,
            cancellationToken);

        await Transform<CosdV9MenopausalStatusRecord, CosdV9MenopausalStatus>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9MenopausalStatus",
            runId,
            cancellationToken);

        await Transform<CosdV9PersonSexualOrientationCodeAtDiagnosisRecord, CosdV9PersonSexualOrientationCodeAtDiagnosis>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9PersonSexualOrientationCodeAtDiagnosis",
            runId,
            cancellationToken);

        await Transform<CosdV8PersonStatedSexualOrientationCodeAtDiagnosisRecord, CosdV8PersonStatedSexualOrientationCodeAtDiagnosis>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV8PersonStatedSexualOrientationCodeAtDiagnosis",
            runId,
            cancellationToken);

        await Transform<CosdV9SourceOfReferralForOutpatientsRecord, CosdV9SourceOfReferralForOutpatients>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9SourceOfReferralForOutpatients",
            runId,
            cancellationToken);

        await Transform<CosdV8SourceOfReferralOutPatientsRecord, CosdV8SourceOfReferralOutPatients>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV8SourceOfReferralOutPatients",
            runId,
            cancellationToken);

        await Transform<CosdV9SourceOfReferralForNonPrimaryCancerPathwayRecord, CosdV9SourceOfReferralForNonPrimaryCancerPathway>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9SourceOfReferralForNonPrimaryCancerPathway",
            runId,
            cancellationToken);

        await Transform<CosdV8SourceOfReferralForOutPatientsNonPrimaryCancerPathwayRecord, CosdV8SourceOfReferralForOutPatientsNonPrimaryCancerPathway>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV8SourceOfReferralForOutPatientsNonPrimaryCancerPathway",
            runId,
            cancellationToken);

        await Transform<CosdV9PerformanceStatusAdultRecord, CosdV9PerformanceStatusAdult>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9PerformanceStatusAdult",
            runId,
            cancellationToken);

        await Transform<CosdV8AdultPerformanceStatusRecord, CosdV8AdultPerformanceStatus>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV8AdultPerformanceStatus",
            runId,
            cancellationToken);

        await Transform<CosdV9AdultComorbidityEvaluationRecord, CosdV9AdultComorbidityEvaluation>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9AdultComorbidityEvaluation",
            runId,
            cancellationToken);

        await Transform<CosdV8AdultComorbidityEvaluationRecord, CosdV8AdultComorbidityEvaluation>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV8AdultComorbidityEvaluation",
            runId,
            cancellationToken);

        await Transform<CosdV9AsaScoreRecord, CosdV9AsaScore>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9AsaScore",
            runId,
            cancellationToken);

        await Transform<CosdV9FamilialCancerSyndromeRecord, CosdV9FamilialCancerSyndrome>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9FamilialCancerSyndrome",
            runId,
            cancellationToken);

        await Transform<CosdV8FamilialCancerSyndromeIndicatorRecord, CosdV8FamilialCancerSyndromeIndicator>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV8FamilialCancerSyndromeIndicator",
            runId,
            cancellationToken);

        await Transform<CosdV9FamilialCancerSyndromeSubsidiaryCommentRecord, CosdV9FamilialCancerSyndromeSubsidiaryComment>(
            _observationRecorder.InsertUpdateObservations,
            "Cosd CosdV9FamilialCancerSyndromeSubsidiaryComment",
            runId,
            cancellationToken);

        await Transform<CosdV8MeasurementGradeOfDifferentiationRecord, CosdV8MeasurementGradeOfDifferentiation>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV8MeasurementGradeOfDifferentiation",
            runId,
            cancellationToken);

        await Transform<CosdV8MeasurementMcategoryFinalPreTreatmentStageRecord, CosdV8MeasurementMcategoryFinalPreTreatmentStage>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV8MeasurementMcategoryFinalPreTreatmentStage",
            runId,
            cancellationToken);

        await Transform<CosdV8MeasurementMcategoryIntegratedStageRecord, CosdV8MeasurementMcategoryIntegratedStage>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV8MeasurementMcategoryIntegratedStage",
            runId,
            cancellationToken);

        await Transform<CosdV8MeasurementNcategoryFinalPreTreatmentStageRecord, CosdV8MeasurementNcategoryFinalPreTreatmentStage>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV8MeasurementNcategoryFinalPreTreatmentStage",
            runId,
            cancellationToken);

        await Transform<CosdV8MeasurementNcategoryIntegratedStageRecord, CosdV8MeasurementNcategoryIntegratedStage>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV8MeasurementNcategoryIntegratedStage",
            runId,
            cancellationToken);

        await Transform<CosdV8MeasurementNonPrimaryPathwayMetastasisRecord, CosdV8MeasurementNonPrimaryPathwayMetastasis>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV8MeasurementNonPrimaryPathwayMetastasis",
            runId,
            cancellationToken);

        await Transform<CosdV8MeasurementPrimaryPathwayMetastasisRecord, CosdV8MeasurementPrimaryPathwayMetastasis>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV8MeasurementPrimaryPathwayMetastasis",
            runId,
            cancellationToken);

        await Transform<CosdV8MeasurementSynchronousTumourIndicatorRecord, CosdV8MeasurementSynchronousTumourIndicator>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV8MeasurementSynchronousTumourIndicator",
            runId,
            cancellationToken);

        await Transform<CosdV8MeasurementTcategoryFinalPreTreatmentStageRecord, CosdV8MeasurementTcategoryFinalPreTreatmentStage>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV8MeasurementTcategoryFinalPreTreatmentStage",
            runId,
            cancellationToken);

        await Transform<CosdV8MeasurementTcategoryIntegratedStageRecord, CosdV8MeasurementTcategoryIntegratedStage>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV8MeasurementTcategoryIntegratedStage",
            runId,
            cancellationToken);

        await Transform<CosdV8MeasurementTNMcategoryFinalPreTreatmentStageRecord, CosdV8MeasurementTNMcategoryFinalPreTreatmentStage>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV8MeasurementTNMcategoryFinalPreTreatmentStage",
            runId,
            cancellationToken);

        await Transform<CosdV8MeasurementTNMcategoryIntegratedStageRecord, CosdV8MeasurementTNMcategoryIntegratedStage>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV8MeasurementTNMcategoryIntegratedStage",
            runId,
            cancellationToken);

        await Transform<CosdV8MeasurementTumourHeightAboveAnalVergeRecord, CosdV8MeasurementTumourHeightAboveAnalVerge>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV8MeasurementTumourHeightAboveAnalVerge",
            runId,
            cancellationToken);

        await Transform<CosdV8MeasurementTumourLateralityRecord, CosdV8MeasurementTumourLaterality>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV8MeasurementTumourLaterality",
            runId,
            cancellationToken);

        await Transform<CosdV9MeasurementGradeOfDifferentiationRecord, CosdV9MeasurementGradeOfDifferentiation>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV9MeasurementGradeOfDifferentiation",
            runId,
            cancellationToken);

        await Transform<CosdV9MeasurementMcategoryFinalPreTreatmentStageRecord, CosdV9MeasurementMcategoryFinalPreTreatmentStage>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV9MeasurementMcategoryFinalPreTreatmentStage",
            runId,
            cancellationToken);

        await Transform<CosdV9MeasurementMcategoryIntegratedStageRecord, CosdV9MeasurementMcategoryIntegratedStage>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV9MeasurementMcategoryIntegratedStage",
            runId,
            cancellationToken);

        await Transform<CosdV9MeasurementNcategoryFinalPreTreatmentStageRecord, CosdV9MeasurementNcategoryFinalPreTreatmentStage>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV9MeasurementNcategoryFinalPreTreatmentStage",
            runId,
            cancellationToken);

        await Transform<CosdV9MeasurementNcategoryIntegratedStageRecord, CosdV9MeasurementNcategoryIntegratedStage>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV9MeasurementNcategoryIntegratedStage",
            runId,
            cancellationToken);

        await Transform<CosdV9MeasurementNonPrimaryPathwayProgressionMetastasisRecord, CosdV9MeasurementNonPrimaryPathwayProgressionMetastasis>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV9MeasurementNonPrimaryPathwayProgressionMetastasis",
            runId,
            cancellationToken);

        await Transform<CosdV9MeasurementNonPrimaryPathwayRecurrenceMetastasisRecord, CosdV9MeasurementNonPrimaryPathwayRecurrenceMetastasis>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV9MeasurementNonPrimaryPathwayRecurrenceMetastasis",
            runId,
            cancellationToken);

        await Transform<CosdV9MeasurementPrimaryPathwayMetastasisRecord, CosdV9MeasurementPrimaryPathwayMetastasis>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV9MeasurementPrimaryPathwayMetastasis",
            runId,
            cancellationToken);

        await Transform<CosdV9MeasurementSynchronousTumourIndicatorRecord, CosdV9MeasurementSynchronousTumourIndicator>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV9MeasurementSynchronousTumourIndicator",
            runId,
            cancellationToken);

        await Transform<CosdV9MeasurementTcategoryFinalPreTreatmentStageRecord, CosdV9MeasurementTcategoryFinalPreTreatmentStage>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV9MeasurementTcategoryFinalPreTreatmentStage",
            runId,
            cancellationToken);

        await Transform<CosdV9MeasurementTcategoryIntegratedStageRecord, CosdV9MeasurementTcategoryIntegratedStage>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV9MeasurementTcategoryIntegratedStage",
            runId,
            cancellationToken);

        await Transform<CosdV9MeasurementTNMcategoryFinalPreTreatmentStageRecord, CosdV9MeasurementTNMcategoryFinalPreTreatmentStage>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV9MeasurementTNMcategoryFinalPreTreatmentStage",
            runId,
            cancellationToken);

        await Transform<CosdV9MeasurementTNMcategoryIntegratedStageRecord, CosdV9MeasurementTNMcategoryIntegratedStage>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV9MeasurementTNMcategoryIntegratedStage",
            runId,
            cancellationToken);

        await Transform<CosdV9MeasurementTumourLateralityRecord, CosdV9MeasurementTumourLaterality>(
            _measurementRecorder.InsertUpdateMeasurements,
            "CosdV9MeasurementTumourLaterality",
            runId,
            cancellationToken);
    }
}