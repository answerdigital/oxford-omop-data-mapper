using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.SUS.Staging.APC.Clearing;

internal class SusAPCClearStagingHostedService : FinalHostedService
{
    private readonly ISusAPCStagingSchema _stagingSchema;

    public SusAPCClearStagingHostedService(IHostApplicationLifetime appLifetime, ISusAPCStagingSchema stagingSchema, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _stagingSchema = stagingSchema;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _stagingSchema.ClearStagingTables(cancellationToken);
    }
}