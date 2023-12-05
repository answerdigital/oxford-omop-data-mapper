using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.SACT.Staging;

internal class SactLoadStagingHostedService : FinalHostedService
{
    private readonly ISactStagingSchema _sactStagingSchema;
    private readonly ISactStaging _sactStaging;

    public SactLoadStagingHostedService(IHostApplicationLifetime appLifetime, ISactStagingSchema sactStagingSchema, ISactStaging sactStaging, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _sactStagingSchema = sactStagingSchema;
        _sactStaging = sactStaging;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _sactStagingSchema.CreateStagingTablesIfTheyDoNotExist(cancellationToken);
        await _sactStaging.StageData(cancellationToken);
    }
}