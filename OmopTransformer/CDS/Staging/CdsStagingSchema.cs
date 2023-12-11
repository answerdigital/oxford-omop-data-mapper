using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.CDS.Staging;

internal class CdsStagingSchema : StagingSchema, ICdsStagingSchema
{
    private readonly string _baseDirectory = "CDS\\Staging";

    public CdsStagingSchema(IOptions<Configuration> configuration, ILogger<CdsStagingSchema> logger) : base(configuration, logger)
    {
    }

    protected override string[] DropStagingSql => 
        new[]
        {
            File.ReadAllText(Path.Combine(_baseDirectory, "delete_staging.sql"))
        };

    protected override string TableNameForExistenceCheck => "cds_line01";
    protected override string[] CreateStagingSql =>
        new[]
        {
            File.ReadAllText(Path.Combine(_baseDirectory, "create", "create_staging_table.sql")),
            File.ReadAllText(Path.Combine(_baseDirectory, "create", "create_staging_dto.sql")),
            File.ReadAllText(Path.Combine(_baseDirectory, "create", "insert_procedure.sql"))
        };
}