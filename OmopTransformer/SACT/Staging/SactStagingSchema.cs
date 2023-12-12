using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.SACT.Staging;

internal class SactStagingSchema : StagingSchema, ISactStagingSchema
{
    public SactStagingSchema(IOptions<Configuration> configuration, ILogger<SactStagingSchema> logger) : base(configuration, logger)
    {
    }

    protected override string[] ClearStagingSql =>
        new[]
        {
            "if object_id('omop_staging.sact_staging') is not null begin truncate table omop_staging.sact_staging; end",
        };
}