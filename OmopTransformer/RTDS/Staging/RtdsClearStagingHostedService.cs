using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OmopTransformer.RTDS.Staging;

namespace OmopTransformer.Rtds.Staging;

internal class RtdsClearStagingHostedService : FinalHostedService
{
    private readonly IRtdsStagingSchema _rtdsStagingSchema;

    public RtdsClearStagingHostedService(IHostApplicationLifetime appLifetime, IRtdsStagingSchema rtdsStagingSchema, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _rtdsStagingSchema = rtdsStagingSchema;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _rtdsStagingSchema.ClearStagingTables(cancellationToken);
    }
}