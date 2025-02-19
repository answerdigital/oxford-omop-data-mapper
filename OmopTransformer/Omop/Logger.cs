using Microsoft.Extensions.Logging;

namespace OmopTransformer.Omop;

internal class Logger
{
    public static void LogNonValid<T, TF>(ILogger<T> logger, IReadOnlyCollection<IOmopRecord<TF>> records)
    {
        int nonValidCount = records.Count(r => r.IsValid == false);

        if (nonValidCount > 0)
        {
            logger.LogInformation($"{nonValidCount} records are considered invalid. ({Math.Round(nonValidCount * 100d / records.Count, 2)}%) invalid.");
        }
    }
}