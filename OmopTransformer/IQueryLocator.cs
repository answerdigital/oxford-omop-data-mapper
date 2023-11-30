using OmopTransformer.Transformation;

namespace OmopTransformer;

internal interface IQueryLocator
{
    Query GetQuery(string queryName);
}