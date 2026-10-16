using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.OxfordDemographics;

internal class OxfordDemographicsTransformHostedService : FinalHostedService
{
    private readonly OxfordDemographicsTransformer _transformer;

    public OxfordDemographicsTransformHostedService(
        IHostApplicationLifetime appLifetime,
        ILogger<FinalHostedService> logger,
        OxfordDemographicsTransformer transformer) : base(appLifetime, logger)
    {
        _transformer = transformer;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _transformer.Transform(cancellationToken);
    }
}
