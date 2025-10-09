using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.SUS.Staging.OP.Clearing;

internal class SusOPStagingSchema : StagingSchema, ISusOPStagingSchema
{
    public SusOPStagingSchema(IOptions<Configuration> configuration, ILogger<SusOPStagingSchema> logger) : base(configuration, logger)
    {
    }

    protected override string[] ClearStagingSql =>
    [
        "truncate table omop_staging.sus_OP_ICDDiagnosis;",
        "truncate table omop_staging.sus_OP_ReadDiagnosis;",
        "truncate table omop_staging.sus_OP_OPCSProcedure;",
        "truncate table omop_staging.sus_OP_ReadProcedure;",
        "truncate table omop_staging.sus_OP;",
    ];
}