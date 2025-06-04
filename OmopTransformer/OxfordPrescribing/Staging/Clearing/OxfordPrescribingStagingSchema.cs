using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.OxfordPrescribing.Staging.Clearing;

internal class OxfordPrescribingStagingSchema : StagingSchema, IOxfordPrescribingStagingSchema
{
    public OxfordPrescribingStagingSchema(IOptions<Configuration> configuration, ILogger<OxfordPrescribingStagingSchema> logger) : base(configuration, logger)
    {
    }

    protected override string[] ClearStagingSql =>
    [
        "if object_id('omop_staging.oxford_prescribing ') is not null begin delete omop_staging.oxford_prescribing  end;"
    ];
}