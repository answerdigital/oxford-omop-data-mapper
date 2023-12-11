using System.Diagnostics;
using Microsoft.Extensions.Logging;
using OmopTransformer.COSD.Staging;
using OmopTransformer.Omop.Location;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD.Demographics;

internal class CosdLocationTransformer
{
    private readonly CosdDemographicsProvider _cosdDemographicsProvider;
    private readonly ITransformer _transformer;
    private readonly ILocationRecorder _locationRecorder;
    private readonly ILogger<CosdLocationTransformer> _logger;
    private readonly TransformOptions _transformOptions;
    private readonly ICosdStagingSchema _cosdStagingSchema;

    public CosdLocationTransformer(CosdDemographicsProvider cosdDemographicsProvider, ITransformer transformer, ILogger<CosdLocationTransformer> logger, ILocationRecorder locationRecorder, TransformOptions transformOptions, ICosdStagingSchema cosdStagingSchema)
    {
        _cosdDemographicsProvider = cosdDemographicsProvider;
        _transformer = transformer;
        _logger = logger;
        _locationRecorder = locationRecorder;
        _transformOptions = transformOptions;
        _cosdStagingSchema = cosdStagingSchema;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Transforming COSD locations.");

        if (!await _cosdStagingSchema.StagingTablesExist(cancellationToken))
        {
            _logger.LogCritical("Data must be staged before it can be transformed.");
            return;
        }

        var getPatientDemographicsStopwatch = Stopwatch.StartNew();

        var patientDemographics = await _cosdDemographicsProvider.GetPatientDemographics(cancellationToken);

        getPatientDemographicsStopwatch.Stop();

        _logger.LogInformation("Extracted {0} locations in {1} seconds.", patientDemographics.Count, getPatientDemographicsStopwatch.ElapsedMilliseconds / 1000);

        var locations =
            patientDemographics
                .Select(demographics => new CosdLocation { Source = demographics })
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