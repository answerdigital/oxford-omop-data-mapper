using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.CDS.Staging;

internal class CdsClearStagingHostedService : FinalHostedService
{
    private readonly ICdsStagingSchema _cdsStagingSchema;

    public CdsClearStagingHostedService(IHostApplicationLifetime appLifetime, ICdsStagingSchema cdsStagingSchema, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _cdsStagingSchema = cdsStagingSchema;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _cdsStagingSchema.DropStagingTables(cancellationToken);
    }
}