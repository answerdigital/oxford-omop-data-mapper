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
    private readonly IConceptMapper _conceptMapper;
    private readonly IRunAnalysisRecorder _runAnalysisRecorder;

    private bool _isConceptMapRendered = false;

    private readonly string _dataSource;

    protected Transformer(IRecordTransformer recordTransformer, ILogger<IRecordTransformer> logger, TransformOptions transformOptions, IRecordProvider recordProvider, string dataSource, IConceptMapper conceptMapper, IRunAnalysisRecorder runAnalysisRecorder)
    {
        _recordTransformer = recordTransformer;
        _logger = logger;
        _transformOptions = transformOptions;
        _recordProvider = recordProvider;
        _dataSource = dataSource;
        _conceptMapper = conceptMapper;
        _runAnalysisRecorder = runAnalysisRecorder;
    }

    public async Task Transform<TSource, TTarget>(
        Func<IReadOnlyCollection<TTarget>, string, CancellationToken, Task> insertRecord,
        string name,
        Guid runId,
        CancellationToken cancellationToken)
        where TTarget : IOmopRecord<TSource>, new()
    {
        await EnsureConceptMapIsRendered(cancellationToken);

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
            await insertRecord(mappedRecords, _dataSource, cancellationToken);

            await 
                _runAnalysisRecorder
                .InsertRunAnalysis(
                    runId: runId,
                    tableType: _dataSource,
                    origin: typeof(TTarget).Name,
                    validCount: mappedRecords.Count(r => r.IsValid),
                    invalidCount: mappedRecords.Count(r => r.IsValid == false),
                    cancellationToken);
        }

        stopwatch.Stop();

        _logger.LogInformation("Transformation took {0}ms.", stopwatch.ElapsedMilliseconds);
    }

    private async Task EnsureConceptMapIsRendered(CancellationToken cancellationToken)
    {
        if (_isConceptMapRendered)
            return;

        await _conceptMapper.RenderConceptMap(cancellationToken);

        _isConceptMapRendered = true;
    }
}