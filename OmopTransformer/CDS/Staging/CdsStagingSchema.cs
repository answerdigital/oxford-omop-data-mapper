using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.CDS.Staging;

internal class CdsStagingSchema : StagingSchema, ICdsStagingSchema
{
    public CdsStagingSchema(IOptions<Configuration> configuration, ILogger<CdsStagingSchema> logger) : base(configuration, logger)
    {
    }

    protected override string[] ClearStagingSql =>
    [
        "if object_id('omop_staging.cds_overseas_visitors') is not null begin delete omop_staging.cds_overseas_visitors; end",
        "if object_id('omop_staging.cds_procedure') is not null begin delete omop_staging.cds_procedure; end",
        "if object_id('omop_staging.cds_secondary_investigations') is not null begin delete omop_staging.cds_secondary_investigations; end",
        "if object_id('omop_staging.cds_birth_details') is not null begin delete omop_staging.cds_birth_details; end",
        "if object_id('omop_staging.cds_critial_care_activity_codes') is not null begin delete omop_staging.cds_critial_care_activity_codes; end",
        "if object_id('omop_staging.cds_diagnosis') is not null begin delete omop_staging.cds_diagnosis; end",
        "if object_id('omop_staging.cds_high_cost_drugs') is not null begin delete omop_staging.cds_high_cost_drugs; end",
        "if object_id('omop_staging.cds_line02') is not null begin delete omop_staging.cds_line02; end",
        "if object_id('omop_staging.cds_line03') is not null begin delete omop_staging.cds_line03; end",
        "if object_id('omop_staging.cds_line04') is not null begin delete omop_staging.cds_line04; end",
        "if object_id('omop_staging.cds_line05') is not null begin delete omop_staging.cds_line05; end",
        "if object_id('omop_staging.cds_line06') is not null begin delete omop_staging.cds_line06; end",
        "if object_id('omop_staging.cds_line07') is not null begin delete omop_staging.cds_line07; end",
        "if object_id('omop_staging.cds_line08') is not null begin delete omop_staging.cds_line08; end",
        "if object_id('omop_staging.cds_line09') is not null begin delete omop_staging.cds_line09; end",
        "if object_id('omop_staging.cds_line10') is not null begin delete omop_staging.cds_line10; end",
        "if object_id('omop_staging.cds_line11') is not null begin delete omop_staging.cds_line11; end",
        "if object_id('omop_staging.cds_line12') is not null begin delete omop_staging.cds_line12; end",
        "if object_id('omop_staging.cds_line01') is not null begin delete omop_staging.cds_line01; end"
    ];
}