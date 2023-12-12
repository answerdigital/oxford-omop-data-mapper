using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.CDS.Staging;

internal class CdsStagingSchema : StagingSchema, ICdsStagingSchema
{
    public CdsStagingSchema(IOptions<Configuration> configuration, ILogger<CdsStagingSchema> logger) : base(configuration, logger)
    {
    }

    protected override string[] ClearStagingSql => 
        new[]
        {
            "if object_id('omop_staging.cds_line01') is not null begin truncate table omop_staging.cds_line01; end"
        };
}