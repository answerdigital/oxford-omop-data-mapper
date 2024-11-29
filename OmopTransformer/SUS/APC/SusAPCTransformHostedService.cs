using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.SUS.APC;

internal class SusAPCTransformHostedService : FinalHostedService
{
    private readonly SusAPCTransformer _transformer;

    public SusAPCTransformHostedService(IHostApplicationLifetime appLifetime, ILogger<FinalHostedService> logger, SusAPCTransformer transformer) : base(appLifetime, logger)
    {
        _transformer = transformer;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _transformer.Transform(cancellationToken);
    }
}