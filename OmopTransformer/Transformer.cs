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

        var overallStopwatch = Stopwatch.StartNew();
        var computeStopwatch = new Stopwatch();
        var getRecordsStopwatch = Stopwatch.StartNew();
        var insertRecordsStopwatch = new Stopwatch();

        int validRowCount = 0;
        int invalidRowCount = 0;
        int mappedRecordsCount = 0;

        await foreach (var records in _recordProvider.GetRecordsBatched<TSource>(cancellationToken))
        {
            getRecordsStopwatch.Stop();

            var mappedRecords =
                records
                    .Select(record => new TTarget { Source = record })
                    .ToList();

            computeStopwatch.Start();

            Parallel.ForEach(mappedRecords, record =>
            {
                cancellationToken.ThrowIfCancellationRequested();
                _recordTransformer.Transform(record);
            });

            computeStopwatch.Stop();

            validRowCount += mappedRecords.Count(r => r.IsValid);
            invalidRowCount += mappedRecords.Count(r => r.IsValid == false);

            insertRecordsStopwatch.Start();

            if (_transformOptions.DryRun == false)
            {
                await insertRecord(mappedRecords, $"{_dataSource}:{name}", cancellationToken);
            }

            mappedRecordsCount += mappedRecords.Count;

            insertRecordsStopwatch.Stop();
            getRecordsStopwatch.Start();
        }

        if (_transformOptions.DryRun == false)
        {
            await
                _runAnalysisRecorder
                    .InsertRunAnalysis(
                        runId: runId,
                        tableType: _dataSource,
                        origin: $"{typeof(TTarget).Name}:{name}",
                        validCount: validRowCount,
                        invalidCount: invalidRowCount,
                        cancellationToken);
        }

        overallStopwatch.Stop();

        string text =
            "--------------------------------" + Environment.NewLine +
            $"Transformation: {name}" + Environment.NewLine +
            $"Valid rows: {validRowCount}" + Environment.NewLine +
            $"Invalid rows: {invalidRowCount}" + Environment.NewLine +
            $"Overall time: {overallStopwatch}. {PerSecond(overallStopwatch, mappedRecordsCount)} per second" + Environment.NewLine +
            $"Read time: {getRecordsStopwatch}. {PerSecond(getRecordsStopwatch, mappedRecordsCount)} per second" + Environment.NewLine +
            $"Write time: {insertRecordsStopwatch}. {PerSecond(insertRecordsStopwatch, validRowCount)} per second" + Environment.NewLine +
            $"CPU time : {computeStopwatch}. {PerSecond(computeStopwatch, mappedRecordsCount)} per second" + Environment.NewLine +
            "--------------------------------" + Environment.NewLine;

        _logger.LogInformation(text);
    }

    private static string PerSecond(Stopwatch stopwatch, int total)
    {
        const int lowSampleThreshold = 20000;

        if (stopwatch.Elapsed.TotalSeconds == 0 || total < lowSampleThreshold)
            return "n/a";
        
        return ((int)(total / stopwatch.Elapsed.TotalSeconds)).ToString();
    }

    private async Task EnsureConceptMapIsRendered(CancellationToken cancellationToken)
    {
        if (_isConceptMapRendered)
            return;

        await _conceptMapper.RenderConceptMap(cancellationToken);

        _isConceptMapRendered = true;
    }
}