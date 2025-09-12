using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.OxfordLab;

internal class OxfordLabTransformHostedService : FinalHostedService
{
    private readonly OxfordLabTransformer _transformer;

    public OxfordLabTransformHostedService(IHostApplicationLifetime appLifetime, ILogger<FinalHostedService> logger, OxfordLabTransformer transformer) : base(appLifetime, logger)
    {
        _transformer = transformer;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _transformer.Transform(cancellationToken);
    }
}