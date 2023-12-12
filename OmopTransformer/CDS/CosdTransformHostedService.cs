using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.CDS;

internal class CdsTransformHostedService : FinalHostedService
{
    private readonly CdsLocationTransformer _transformer;

    public CdsTransformHostedService(IHostApplicationLifetime appLifetime, ILogger<FinalHostedService> logger, CdsLocationTransformer transformer) : base(appLifetime, logger)
    {
        _transformer = transformer;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _transformer.Transform(cancellationToken);
    }
}