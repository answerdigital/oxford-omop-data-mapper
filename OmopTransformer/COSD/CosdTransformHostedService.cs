using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.COSD;

internal class CosdTransformHostedService : FinalHostedService
{
    private readonly CosdTransformer _transformer;

    public CosdTransformHostedService(IHostApplicationLifetime appLifetime, ILogger<FinalHostedService> logger, CosdTransformer transformer) : base(appLifetime, logger)
    {
        _transformer = transformer;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _transformer.Transform(cancellationToken);
    }
}