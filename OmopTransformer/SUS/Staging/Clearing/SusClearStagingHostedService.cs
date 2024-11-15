using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.SUS.Staging.Clearing;

internal class SusClearStagingHostedService : FinalHostedService
{
    private readonly ISusStagingSchema _stagingSchema;

    public SusClearStagingHostedService(IHostApplicationLifetime appLifetime, ISusStagingSchema stagingSchema, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _stagingSchema = stagingSchema;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _stagingSchema.ClearStagingTables(cancellationToken);
    }
}