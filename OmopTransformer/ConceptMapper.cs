using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Data.SqlClient;
using Dapper;

namespace OmopTransformer;

internal class ConceptMapper : IConceptMapper
{
    private readonly Configuration _configuration;
    private readonly ILogger<ConceptMapper> _logger;

    public ConceptMapper(IOptions<Configuration> configuration, ILogger<ConceptMapper> logger)
    {
        _configuration = configuration.Value;
        _logger = logger;
    }

    public async Task RenderConceptMap(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Rendering non standard to standard concept map.");

        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        await connection.ExecuteAsync("omop_staging.generate_concept_code_map");
    }
}