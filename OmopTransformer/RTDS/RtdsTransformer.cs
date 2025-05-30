﻿using Microsoft.Extensions.Logging;
using OmopTransformer.Omop;
using OmopTransformer.Omop.Location;
using OmopTransformer.Omop.Person;
using OmopTransformer.RTDS.Demographics;
using OmopTransformer.Transformation;

namespace OmopTransformer.RTDS;

internal class RtdsTransformer : Transformer
{
    private readonly ILocationRecorder _locationRecorder;
    private readonly IPersonRecorder _personRecorder;
    
    public RtdsTransformer(
        IRecordTransformer recordTransformer, 
        TransformOptions transformOptions, 
        IRecordProvider recordProvider, 
        ILocationRecorder locationRecorder, 
        IPersonRecorder personRecorder, 
        IConceptMapper conceptMapper,
        IRunAnalysisRecorder runAnalysisRecorder,
        ILoggerFactory loggerFactory) 
        : base(
            recordTransformer, 
            transformOptions, 
            recordProvider, 
            "RTDS",
            conceptMapper,
            runAnalysisRecorder,
            loggerFactory)
    {
        _locationRecorder = locationRecorder;
        _personRecorder = personRecorder;
    }

    public async Task Transform(CancellationToken cancellationToken)
    {
        Guid runId = Guid.NewGuid();

        await Transform<RtdsDemographics, RtdsPerson>(
            _personRecorder.InsertUpdatePersons,
            "Rtds Person",
            runId,
            cancellationToken);
        
        await Transform<RtdsPasLocation, RtdsLocation>(
            _locationRecorder.InsertUpdateLocations,
            "Rtds Location",
            runId,
            cancellationToken);
    }
}