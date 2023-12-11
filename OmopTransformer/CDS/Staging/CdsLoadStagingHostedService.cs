using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.CDS.Staging;

internal class CdsLoadStagingHostedService : FinalHostedService
{
    private readonly ICdsStagingSchema _cdsStagingSchema;
    private readonly ICdsStaging _cdsStaging;

    public CdsLoadStagingHostedService(IHostApplicationLifetime appLifetime, ICdsStagingSchema cdsStagingSchema, ICdsStaging cdsStaging, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _cdsStagingSchema = cdsStagingSchema;
        _cdsStaging = cdsStaging;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _cdsStagingSchema.CreateStagingTablesIfTheyDoNotExist(cancellationToken);
        await _cdsStaging.StageData(cancellationToken);
    }
}