using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.SUS.OP;

internal class SusOPTransformHostedService : FinalHostedService
{
    private readonly SusOPTransformer _transformer;

    public SusOPTransformHostedService(IHostApplicationLifetime appLifetime, ILogger<FinalHostedService> logger, SusOPTransformer transformer) : base(appLifetime, logger)
    {
        _transformer = transformer;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _transformer.Transform(cancellationToken);
    }
}