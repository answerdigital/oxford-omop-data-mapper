using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer;

internal sealed class DocumentationGenerationHostedService : IHostedService
{
    private readonly ILogger _logger;
    private readonly IHostApplicationLifetime _appLifetime;
    private readonly IDocumentationWriter _documentationWriter;

    public DocumentationGenerationHostedService(
        ILogger<DocumentationGenerationHostedService> logger,
        IHostApplicationLifetime appLifetime, 
        IDocumentationWriter documentationWriter)
    {
        _logger = logger;
        _appLifetime = appLifetime;
        _documentationWriter = documentationWriter;

        appLifetime.ApplicationStopping.Register(OnStopping);
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("1. StartAsync has been called.");

        var _ = Task.Run(GenerateDocumentationAsync, cancellationToken);

        return Task.CompletedTask;
    }

    private async Task GenerateDocumentationAsync()
    {
        try
        {
            _logger.LogInformation("Generating documentation.");
            await _documentationWriter.WriteToPath(_appLifetime.ApplicationStopping);
        }
        finally
        {
            _appLifetime.StopApplication();
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("4. StopAsync has been called.");

        return Task.CompletedTask;
    }

    private void OnStopping()
    {
        _logger.LogInformation("3. OnStopping has been called.");
    }
}