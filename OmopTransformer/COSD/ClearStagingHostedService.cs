using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.COSD;

internal class ClearStagingHostedService : FinalHostedService
{
    private readonly ICosdStagingSchema _cosdStagingSchema;

    public ClearStagingHostedService(IHostApplicationLifetime appLifetime, ICosdStagingSchema cosdStagingSchema, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _cosdStagingSchema = cosdStagingSchema;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _cosdStagingSchema.DropStagingTables(cancellationToken);
    }
}