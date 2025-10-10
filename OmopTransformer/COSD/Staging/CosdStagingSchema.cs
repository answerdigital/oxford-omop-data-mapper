using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.COSD.Staging;

internal class CosdStagingSchema : StagingSchema, ICosdStagingSchema
{
    public CosdStagingSchema(IOptions<Configuration> configuration, ILogger<CosdStagingSchema> logger) : base(configuration, logger)
    {
    }

    protected override string[] ClearStagingSql =>
        new[]
        {
            "truncate table omop_staging.cosd_staging;"
        };
}