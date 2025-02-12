using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.SUS.Staging.Inpatient;

internal class SusInpatientLoadStagingHostedService : FinalHostedService
{
    private readonly ISusInpatientStaging _susInpatientStaging;

    public SusInpatientLoadStagingHostedService(IHostApplicationLifetime appLifetime, ISusInpatientStaging susInpatientStaging, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _susInpatientStaging = susInpatientStaging;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _susInpatientStaging.StageData(cancellationToken);
    }
}