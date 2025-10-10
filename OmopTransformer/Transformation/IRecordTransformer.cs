using Microsoft.Extensions.Logging;
using OmopTransformer.Omop;

namespace OmopTransformer.Transformation;

internal interface IRecordTransformer
{
    void Transform<T>(IOmopRecord<T> record, TransformPlan transformPlan);
    void PrintLogsAndResetLogger(ILoggerFactory loggerFactory);
}