using Microsoft.Extensions.Logging;

namespace OmopTransformer.Transformation;

internal class RecordTransformLookupLogger
{
    private readonly Dictionary<string, LookupMissCount> _missCountByLookup = new();
    private readonly object _lock = new();

    public void Reset()
    {
        lock (_lock)
        {
            _missCountByLookup.Clear();
        }
    }

    public void Hit(string lookupName)
    {
        lock (_lock)
        {
            var counter = GetOrCreateMissCount(lookupName);

            counter.Hit();
        }
    }

    public void Miss(string lookupName, string value)
    {
        lock (_lock)
        {
            var counter = GetOrCreateMissCount(lookupName);

            counter.Miss(value);
        }
    }

    private LookupMissCount GetOrCreateMissCount(string lookupName)
    {
        if (_missCountByLookup.TryGetValue(lookupName, out var counter))
        {
            return counter;
        }
        else
        {
            var lookupCounter = new LookupMissCount();

            _missCountByLookup.Add(lookupName, lookupCounter);

            return lookupCounter;
        }
    }

    public void PrintLog(ILoggerFactory loggerFactory)
    {
        lock (_lock)
        {
            if (ShouldPrintLog(_missCountByLookup) == false)
                return;

            var logger = loggerFactory.CreateLogger("LookupTransformer");

            logger.LogWarning("Missed lookups");

            foreach (var countByLookup in _missCountByLookup.OrderByDescending(count => count.Value.MissCount))
            {
                logger.LogWarning(" {0}", countByLookup.Key);

                var missRatePercentage = (countByLookup.Value.MissCount * 100d) / (countByLookup.Value.MissCount + countByLookup.Value.HitCount);

                logger
                    .LogWarning(
                        "     Total miss rate {0}% ({1} hits, {2} misses)",
                        Math.Round(missRatePercentage, 2),
                        countByLookup.Value.HitCount,
                        countByLookup.Value.MissCount);

                logger.LogWarning("       Misses");

                foreach (var missCount in countByLookup.Value.MissCountByValue.OrderByDescending(count => count.Value))
                {
                    logger
                        .LogWarning(
                            "       - \"{0}\" misses: {1}",
                            missCount.Key,
                            missCount.Value);
                }
            }
        }
    }

    private static bool ShouldPrintLog(Dictionary<string, LookupMissCount> lookupCounts) =>
        lookupCounts
            .Any(count => count.Value.MissCount > 0);

    private class LookupMissCount
    {
        public int HitCount { get; private set; }
        public int MissCount { get; private set; }

        public readonly Dictionary<string, int> MissCountByValue = new();

        public void Hit()
        {
            HitCount++;
        }

        public void Miss(string value)
        {
            MissCount++;

            if (MissCountByValue.TryGetValue(value, out int count))
            {
                MissCountByValue[value] = ++count;
            }
            else
            {
                MissCountByValue.Add(value, value: 1);
            }
        }
    }
}