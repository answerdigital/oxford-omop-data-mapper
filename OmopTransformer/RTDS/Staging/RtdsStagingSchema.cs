using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.RTDS.Staging;

internal class RtdsStagingSchema : StagingSchema, IRtdsStagingSchema
{
    public RtdsStagingSchema(IOptions<Configuration> configuration, ILogger<RtdsStagingSchema> logger) : base(configuration, logger)
    {
    }

    protected override string[] ClearStagingSql =>
    [
        "if object_id('omop_staging.RTDS_1_Demographics') is not null begin delete omop_staging.RTDS_1_Demographics; end",
        "if object_id('omop_staging.RTDS_2a_Attendances') is not null begin delete omop_staging.RTDS_2a_Attendances; end",
        "if object_id('omop_staging.RTDS_2b_Plan') is not null begin delete omop_staging.RTDS_2b_Plan; end",
        "if object_id('omop_staging.RTDS_3_Prescription') is not null begin delete omop_staging.RTDS_3_Prescription; end",
        "if object_id('omop_staging.RTDS_4_Exposures') is not null begin delete omop_staging.RTDS_4_Exposures; end",
        "if object_id('omop_staging.RTDS_5_Diagnosis_Course') is not null begin delete omop_staging.RTDS_5_Diagnosis_Course; end",
        "if object_id('omop_staging.RTDS_PASSDATA') is not null begin delete omop_staging.RTDS_PASSDATA; end"
    ];
}