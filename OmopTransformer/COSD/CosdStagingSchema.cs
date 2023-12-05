using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.COSD;

internal class CosdStagingSchema : StagingSchema, ICosdStagingSchema
{
    public CosdStagingSchema(IOptions<Configuration> configuration, ILogger<CosdStagingSchema> logger) : base(configuration, logger)
    {
    }

    protected override string[] DropStagingSql =>
        new[]
        {
            "drop table cosd_staging"
        };

    protected override string TableNameForExistenceCheck => "cosd_staging";
    protected override string[] CreateStagingSql =>
        new[]
        {
            "create table cosd_staging                                                                      " +
            "(                                                                                              " +
            "    SubmissionName varchar(200) not null,                                                      " +
            "	FileName varchar(200) not null,                                                             " +
            "	Content xml not null,                                                                       " +
            "	constraint PK_cosd_staging_SubmissionName_FileName primary key(SubmissionName, FileName)    " +
            ");"
        };
}