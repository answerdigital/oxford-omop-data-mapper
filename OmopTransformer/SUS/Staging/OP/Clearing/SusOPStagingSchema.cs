﻿using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OmopTransformer.SUS.Staging.APC.Clearing;

namespace OmopTransformer.SUS.Staging.OP.Clearing;

internal class SusOPStagingSchema : StagingSchema, ISusOPStagingSchema
{
    public SusOPStagingSchema(IOptions<Configuration> configuration, ILogger<SusAPCStagingSchema> logger) : base(configuration, logger)
    {
    }

    protected override string[] ClearStagingSql =>
    [
        "if object_id('omop_staging.sus_OP_ICDDiagnosis') is not null begin delete oomop_staging.sus_OP_ICDDiagnosis end;",
        "if object_id('omop_staging.sus_OP_ReadDiagnosis') is not null begin delete oomop_staging.sus_OP_ReadDiagnosis end;",
        "if object_id('omop_staging.sus_OP_OPCSProcedure') is not null begin delete oomop_staging.sus_OP_OPCSProcedure end;",
        "if object_id('omop_staging.sus_OP_ReadProcedure') is not null begin delete oomop_staging.sus_OP_ReadProcedure end;",
        "if object_id('omop_staging.sus_OP') is not null begin delete oomop_staging.sus_OP end;",
    ];
}