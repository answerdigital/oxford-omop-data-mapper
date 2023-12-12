using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.COSD.Staging;

internal class CosdClearStagingHostedService : FinalHostedService
{
    private readonly ICosdStagingSchema _cosdStagingSchema;

    public CosdClearStagingHostedService(IHostApplicationLifetime appLifetime, ICosdStagingSchema cosdStagingSchema, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _cosdStagingSchema = cosdStagingSchema;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _cosdStagingSchema.ClearStagingTables(cancellationToken);
    }
}