using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.OxfordPrescribing.Staging.Clearing;

internal class OxfordPrescribingClearStagingHostedService : FinalHostedService
{
    private readonly IOxfordPrescribingStagingSchema _stagingSchema;

    public OxfordPrescribingClearStagingHostedService(IHostApplicationLifetime appLifetime, IOxfordPrescribingStagingSchema stagingSchema, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _stagingSchema = stagingSchema;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _stagingSchema.ClearStagingTables(cancellationToken);
    }
}