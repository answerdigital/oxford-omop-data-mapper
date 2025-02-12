using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.SUS.Staging.Inpatient.Clearing;

internal class SusInpatientClearStagingHostedService : FinalHostedService
{
    private readonly ISusInpatientStagingSchema _stagingSchema;

    public SusInpatientClearStagingHostedService(IHostApplicationLifetime appLifetime, ISusInpatientStagingSchema stagingSchema, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _stagingSchema = stagingSchema;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _stagingSchema.ClearStagingTables(cancellationToken);
    }
}