using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace OmopTransformer;

internal abstract class FinalHostedService : IHostedService
{
    protected readonly IHostApplicationLifetime AppLifetime;
    protected readonly ILogger<FinalHostedService> Logger;

    protected FinalHostedService(IHostApplicationLifetime appLifetime, ILogger<FinalHostedService> logger)
    {
        AppLifetime = appLifetime;
        Logger = logger;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        var _ = Task.Run(RunThenShutdown, cancellationToken);

        return Task.CompletedTask;
    }

    protected abstract Task RunTask(CancellationToken cancellationToken);

    private async Task RunThenShutdown()
    {
        try
        {
            await RunTask(AppLifetime.ApplicationStopping);
        }
        catch (Exception exception)
        {
            Logger.LogCritical("Critical error: {0}", exception);

            Environment.ExitCode = (int)ExitCodes.UnknownError;
        }
        finally
        {
            AppLifetime.StopApplication();
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}