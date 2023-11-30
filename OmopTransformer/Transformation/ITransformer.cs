using OmopTransformer.Omop;

namespace OmopTransformer.Transformation;

internal interface ITransformer
{
    void Transform<T>(IOmopRecord<T> record);
}