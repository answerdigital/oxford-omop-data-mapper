using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.COSD;

internal class CosdLoadStagingHostedService : FinalHostedService
{
    private readonly ICosdStagingSchema _cosdStagingSchema;
    private readonly ICosdStaging _cosdStaging;

    public CosdLoadStagingHostedService(IHostApplicationLifetime appLifetime, ICosdStagingSchema cosdStagingSchema, ICosdStaging cosdStaging, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _cosdStagingSchema = cosdStagingSchema;
        _cosdStaging = cosdStaging;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _cosdStagingSchema.CreateStagingTablesIfTheyDoNotExist(cancellationToken);
        await _cosdStaging.StageData(cancellationToken);
    }
}