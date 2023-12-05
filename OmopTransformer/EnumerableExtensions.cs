namespace OmopTransformer;

public static class EnumerableExtensions
{
    public static IEnumerable<IEnumerable<T>> Batch<T>(this IEnumerable<T> source, int batchSize)
    {
        if (source == null) throw new ArgumentNullException(nameof(source));
        using var enumerator = source.GetEnumerator();
        while (enumerator.MoveNext())
        {
            yield return GetBatch(enumerator, batchSize);
        }
    }

    private static IEnumerable<T> GetBatch<T>(IEnumerator<T> source, int batchSize)
    {
        do
        {
            yield return source.Current;
        }
        while (--batchSize > 0 && source.MoveNext());
    }
}