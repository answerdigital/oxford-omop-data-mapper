using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.SACT;

internal class SactTransformHostedService : FinalHostedService
{
    private readonly SactLocationTransformer _transformer;

    public SactTransformHostedService(IHostApplicationLifetime appLifetime, ILogger<FinalHostedService> logger, SactLocationTransformer transformer) : base(appLifetime, logger)
    {
        _transformer = transformer;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _transformer.Transform(cancellationToken);
    }
}