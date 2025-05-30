﻿using OmopTransformer.Annotations;
using OmopTransformer.Omop.DeviceExposure;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.CCMDS.DeviceExposure;

internal class SusCCMDSDeviceExposure : OmopDeviceExposure<SusCCMDSDeviceExposureRecord>
{
     [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [CopyValue(nameof(Source.HospitalProviderSpellNumber))]
    public override string? HospitalProviderSpellNumber { get; set; }

    [Transform(typeof(StandardDeviceConceptSelector), useOmopTypeAsSource: true, nameof(device_source_concept_id))]
    public override int[]? device_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.DeviceExposureStartDate))]
    public override DateTime? device_exposure_start_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.DeviceExposureStartDate), nameof(Source.DeviceExposureStartTime))]
    public override DateTime? device_exposure_start_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.DeviceExposureEndDate))]
    public override DateTime? device_exposure_end_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.DeviceExposureEndDate), nameof(Source.DeviceExposureEndTime))]
    public override DateTime? device_exposure_end_datetime { get; set; }

    [ConstantValue(32818, "`EHR administration record`")]
    public override int? device_type_concept_id { get; set; }

    [Transform(typeof(NhsCriticalCareActivityDeviceLookup), nameof(Source.CriticalCareActivityCode))]
    public override int? device_source_concept_id { get; set; }

    [CopyValue(nameof(Source.CriticalCareActivityCode))]
    public override string? device_source_value { get; set; }
}