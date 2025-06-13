using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.OxfordGP.Staging.Clearing;

internal class OxfordGPClearStagingHostedService : FinalHostedService
{
    private readonly IOxfordGPStagingSchema _stagingSchema;

    public OxfordGPClearStagingHostedService(IHostApplicationLifetime appLifetime, IOxfordGPStagingSchema stagingSchema, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _stagingSchema = stagingSchema;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _stagingSchema.ClearStagingTables(cancellationToken);
    }
}