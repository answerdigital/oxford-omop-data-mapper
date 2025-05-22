using OmopTransformer.Annotations;
using OmopTransformer.Omop.DeviceExposure;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.AE.DeviceExposure.ProcedureDevice;

internal class SusAEProcedureDevice : OmopDeviceExposure<SusAEProcedureDeviceRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(ConceptDeviceSelector), useOmopTypeAsSource: true, nameof(device_source_concept_id))]
    public override int[]? device_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.PrimaryProcedureDate))]
    public override DateTime? device_exposure_start_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.PrimaryProcedureDate))]
    public override DateTime? device_exposure_start_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.PrimaryProcedureDate))]
    public override DateTime? device_exposure_end_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.PrimaryProcedureDate))]
    public override DateTime? device_exposure_end_datetime { get; set; }

    [ConstantValue(32818, "`EHR administration record`")]
    public override int? device_type_concept_id { get; set; }

    [Transform(typeof(NhsAETreatmentLookup), nameof(Source.PrimaryProcedure))]
    public override int? device_source_concept_id { get; set; }

    [CopyValue(nameof(Source.PrimaryProcedure))]
    public override string? device_source_value { get; set; }

    [CopyValue(nameof(Source.AEAttendanceNumber))]
    public override string? HospitalProviderSpellNumber { get; set; }
}