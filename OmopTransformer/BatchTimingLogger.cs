using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace OmopTransformer;

internal class BatchTimingLogger<T>(int batchSize, int itemCount, string stageName, ILogger<T> logger)
{
    private readonly Stopwatch _batchStopwatch = Stopwatch.StartNew();
    private readonly Stopwatch _stopwatch = Stopwatch.StartNew();

    private int _count;

    public int BatchSize { get; } = batchSize;

    public void LogNext()
    {
        _count++;

        logger.LogInformation($"Batch {_count} of {Math.Ceiling(itemCount / (decimal)BatchSize)} completed in {_batchStopwatch.ElapsedMilliseconds}ms.");

        _batchStopwatch.Restart();
    }

    public void LogSummary()
    {
        logger.LogInformation($"{stageName} completed in {_stopwatch.Elapsed.TotalSeconds} seconds.");
    }
}