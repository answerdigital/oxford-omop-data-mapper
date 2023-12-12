namespace OmopTransformer.Omop;

internal interface IOmopRecord<T> : IOmopTarget
{
    T? Source { get; set;  }
}