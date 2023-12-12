using System.Diagnostics;
using Microsoft.Extensions.Logging;
using OmopTransformer.Omop;
using OmopTransformer.Transformation;

namespace OmopTransformer;

internal abstract class Transformer
{
    private readonly IRecordTransformer _recordTransformer;
    private readonly ILogger<IRecordTransformer> _logger;
    private readonly TransformOptions _transformOptions;
    private readonly IRecordProvider _recordProvider;

    protected Transformer(IRecordTransformer recordTransformer, ILogger<IRecordTransformer> logger, TransformOptions transformOptions, IRecordProvider recordProvider)
    {
        _recordTransformer = recordTransformer;
        _logger = logger;
        _transformOptions = transformOptions;
        _recordProvider = recordProvider;
    }

    public async Task Transform<TSource, TTarget>(
        Func<IReadOnlyCollection<TTarget>, CancellationToken, Task> insertRecord,
        string name,
        CancellationToken cancellationToken)
        where TTarget : IOmopRecord<TSource>, new()
    {
        _logger.LogInformation("Transforming {0}.", name);

        var getRecordsStopwatch = Stopwatch.StartNew();

        var records = await _recordProvider.GetRecords<TSource>(cancellationToken);

        getRecordsStopwatch.Stop();

        _logger.LogInformation("Extracted {0} {1} in {2} seconds.", records.Count, name, getRecordsStopwatch.ElapsedMilliseconds / 1000);

        var mappedRecords =
            records
                .Select(record => new TTarget { Source = record })
                .ToList();

        var stopwatch = Stopwatch.StartNew();

        Parallel.ForEach(mappedRecords, record =>
        {
            cancellationToken.ThrowIfCancellationRequested();
            _recordTransformer.Transform(record);
        });

        if (_transformOptions.DryRun == false)
        {
            await insertRecord(mappedRecords, cancellationToken);
        }

        stopwatch.Stop();

        _logger.LogInformation("Transformation took {0}ms.", stopwatch.ElapsedMilliseconds);
    }
}