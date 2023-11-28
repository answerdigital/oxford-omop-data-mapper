using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.Documentation;

internal sealed class DocumentationGenerationHostedService : FinalHostedService
{
    private readonly IDocumentationWriter _documentationWriter;

    public DocumentationGenerationHostedService(IHostApplicationLifetime appLifetime, IDocumentationWriter documentationWriter, ILogger<FinalHostedService> logger) : base(appLifetime, logger)
    {
        _documentationWriter = documentationWriter;
    }

    protected override async Task RunTask(CancellationToken cancellationToken)
    {
        await _documentationWriter.WriteToPath(cancellationToken);
    }
}