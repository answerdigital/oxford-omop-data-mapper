using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.SUS.Staging.OP.Clearing;

internal class SusOPClearStagingHostedService : FinalHostedService
{
    private readonly ISusOPStagingSchema _stagingSchema;

    public SusOPClearStagingHostedService(IHostApplicationLifetime appLifetime, ISusOPStagingSchema stagingSchema, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _stagingSchema = stagingSchema;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _stagingSchema.ClearStagingTables(cancellationToken);
    }
}