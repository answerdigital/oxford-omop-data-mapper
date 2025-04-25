using OmopTransformer.Annotations;
using OmopTransformer.Omop.DeviceExposure;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.OP.DeviceExposure;

internal class SusOPDeviceExposure : OmopDeviceExposure<SusOPDeviceExposureRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(StandardDeviceConceptSelector), useOmopTypeAsSource: true, nameof(device_source_concept_id))]
    public override int? device_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.AppointmentDate))]
    public override DateTime? device_exposure_start_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.AppointmentDate), nameof(Source.AppointmentTime))]
    public override DateTime? device_exposure_start_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.AppointmentDate))]
    public override DateTime? device_exposure_end_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.AppointmentDate), nameof(Source.AppointmentTime))]
    public override DateTime? device_exposure_end_datetime { get; set; }

    [ConstantValue(32818, "`EHR administration record`")]
    public override int? device_type_concept_id { get; set; }

    // [Transform(typeof(AccidentAndEmergencyInvestigationLookup), nameof(Source.AccidentAndEmergencyProcedure))]
    // public override int? device_source_concept_id { get; set; }

    // [CopyValue(nameof(Source.AccidentAndEmergencyProcedure))]
    // public override string? device_source_value { get; set; }

    [CopyValue(nameof(Source.HospitalSpellProviderNumber))]
    public override string? HospitalProviderSpellNumber { get; set; }
}
