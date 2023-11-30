using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OmopTransformer.COSD.Demographics;

namespace OmopTransformer.COSD;

internal class CosdTransformHostedService : FinalHostedService
{
    private readonly CosdLocationTransformer _transformer;

    public CosdTransformHostedService(IHostApplicationLifetime appLifetime, ILogger<FinalHostedService> logger, CosdLocationTransformer transformer) : base(appLifetime, logger)
    {
        _transformer = transformer;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _transformer.Transform(cancellationToken);
    }
}