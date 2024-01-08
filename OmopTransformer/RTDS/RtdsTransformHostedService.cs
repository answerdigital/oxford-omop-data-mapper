using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.RTDS;

internal class RtdsTransformHostedService : FinalHostedService
{
    private readonly RtdsTransformer _transformer;

    public RtdsTransformHostedService(IHostApplicationLifetime appLifetime, ILogger<FinalHostedService> logger, RtdsTransformer transformer) : base(appLifetime, logger)
    {
        _transformer = transformer;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _transformer.Transform(cancellationToken);
    }
}