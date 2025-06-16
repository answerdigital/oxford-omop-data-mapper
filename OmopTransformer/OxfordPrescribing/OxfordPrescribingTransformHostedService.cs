using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OmopTransformer.OxfordPrescribing;

namespace OmopTransformer.OxfordGP;

internal class OxfordPrescribingTransformHostedService : FinalHostedService
{
    private readonly OxfordPrescribingTransformer _transformer;

    public OxfordPrescribingTransformHostedService(IHostApplicationLifetime appLifetime, ILogger<FinalHostedService> logger, OxfordPrescribingTransformer transformer) : base(appLifetime, logger)
    {
        _transformer = transformer;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _transformer.Transform(cancellationToken);
    }
}