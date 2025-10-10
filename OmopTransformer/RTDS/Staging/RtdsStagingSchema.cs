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
        "truncate table omop_staging.RTDS_1_Demographics;",
        "truncate table omop_staging.RTDS_2a_Attendances;",
        "truncate table omop_staging.RTDS_2b_Plan;",
        "truncate table omop_staging.RTDS_3_Prescription;",
        "truncate table omop_staging.RTDS_4_Exposures;",
        "truncate table omop_staging.RTDS_5_Diagnosis_Course;",
        "truncate table omop_staging.RTDS_PASSDATA;"
    ];
}