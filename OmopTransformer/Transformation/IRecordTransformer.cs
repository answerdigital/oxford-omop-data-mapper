using Microsoft.Extensions.Logging;
using OmopTransformer.Omop;

namespace OmopTransformer.Transformation;

internal interface IRecordTransformer
{
    void Transform<T>(IOmopRecord<T> record);
    void PrintLogsAndResetLogger(ILoggerFactory loggerFactory);
}