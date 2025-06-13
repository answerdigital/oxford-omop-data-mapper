    using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.OxfordGP.Staging.Clearing;

internal class OxfordGPStagingSchema : StagingSchema, IOxfordGPStagingSchema
{
    public OxfordGPStagingSchema(IOptions<Configuration> configuration, ILogger<OxfordGPStagingSchema> logger) : base(configuration, logger)
    {
    }

    protected override string[] ClearStagingSql =>
    [
        "if object_id('omop_staging.oxford_gp_medication') is not null begin delete omop_staging.oxford_gp_medication end",
        "if object_id('omop_staging.oxford_gp_event') is not null begin delete omop_staging.oxford_gp_event end",
        "if object_id('omop_staging.oxford_gp_demographic') is not null begin delete omop_staging.oxford_gp_demographic end",
        "if object_id('omop_staging.oxford_gp_appointment') is not null begin delete omop_staging.oxford_gp_appointment end",
    ];
}