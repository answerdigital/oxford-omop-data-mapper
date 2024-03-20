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
using OmopTransformer.COSD.ProcedureOccurrence.CosdV8ProcedureOccurrencePrimaryProcedureOpcs;
using OmopTransformer.COSD.ProcedureOccurrence.CosdV8ProcedureOccurrenceProcedureOpcs;
using OmopTransformer.COSD.ProcedureOccurrence.CosdV9ProcedureOccurrencePrimaryProcedureOpcs;
using OmopTransformer.COSD.ProcedureOccurrence.CosdV9ProcedureOccurrenceProcedureOpcs;
using OmopTransformer.Omop.ConditionOccurrence;
using OmopTransformer.Omop.Death;
using OmopTransformer.Omop.Location;
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

    public CosdTransformer(
        IRecordTransformer recordTransformer, 
        ILogger<IRecordTransformer> logger, 
        TransformOptions transformOptions, 
        IRecordProvider recordProvider, 
        ILocationRecorder locationRecorder, 
        IPersonRecorder personRecorder, 
        IDeathRecorder deathRecorder, 
        IConditionOccurrenceRecorder conditionOccurrenceRecorder, 
        IProcedureOccurrenceRecorder procedureOccurrenceRecorder) 
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
    }
}