using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.SACT.Staging;

internal class SactClearStagingHostedService : FinalHostedService
{
    private readonly ISactStagingSchema _sactStagingSchema;

    public SactClearStagingHostedService(IHostApplicationLifetime appLifetime, ISactStagingSchema sactStagingSchema, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _sactStagingSchema = sactStagingSchema;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _sactStagingSchema.ClearStagingTables(cancellationToken);
    }
}