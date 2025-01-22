using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.SUS.Staging.AE.Clearing;

internal class SusAEClearStagingHostedService : FinalHostedService
{
    private readonly ISusAEStagingSchema _stagingSchema;

    public SusAEClearStagingHostedService(IHostApplicationLifetime appLifetime, ISusAEStagingSchema stagingSchema, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _stagingSchema = stagingSchema;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _stagingSchema.ClearStagingTables(cancellationToken);
    }
}