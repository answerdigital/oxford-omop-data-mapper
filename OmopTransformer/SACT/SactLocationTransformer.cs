using System.Diagnostics;
using Microsoft.Extensions.Logging;
using OmopTransformer.Omop.Location;
using OmopTransformer.SACT.Staging;
using OmopTransformer.Transformation;

namespace OmopTransformer.SACT;

internal class SactLocationTransformer
{
    private readonly ITransformer _transformer;
    private readonly ILocationRecorder _locationRecorder;
    private readonly ILogger<SactLocationTransformer> _logger;
    private readonly TransformOptions _transformOptions;
    private readonly ISactStagingSchema _sactStagingSchema;
    private readonly ISactProvider _sactProvider;

    public SactLocationTransformer(ITransformer transformer, ILogger<SactLocationTransformer> logger, ILocationRecorder locationRecorder, TransformOptions transformOptions, ISactProvider sactProvider, ISactStagingSchema sactStagingSchema)
    {
        _transformer = transformer;
        _logger = logger;
        _locationRecorder = locationRecorder;
        _transformOptions = transformOptions;
        _sactProvider = sactProvider;
        _sactStagingSchema = sactStagingSchema;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Transforming SACT locations.");

        if (!await _sactStagingSchema.StagingTablesExist(cancellationToken))
        {
            _logger.LogCritical("Data must be staged before it can be transformed.");
            return;
        }

        var recordStopwatch = Stopwatch.StartNew();

        var sactRecords = await _sactProvider.GetRecords(cancellationToken);

        recordStopwatch.Stop();

        _logger.LogInformation("Extracted {0} locations in {1} seconds.", sactRecords.Count, recordStopwatch.ElapsedMilliseconds / 1000);

        var locations =
            sactRecords
                .Select(record => new SactLocation { Source = record })
                .ToList();

        var stopwatch = Stopwatch.StartNew();

        Parallel.ForEach(locations, number =>
        {
            cancellationToken.ThrowIfCancellationRequested();
            _transformer.Transform(number);
        });

        if (_transformOptions.DryRun == false)
        {
            await _locationRecorder.InsertUpdateLocations(locations, cancellationToken);
        }

        stopwatch.Stop();

        _logger.LogInformation("Transformation took {0}ms.", stopwatch.ElapsedMilliseconds);
    }
}