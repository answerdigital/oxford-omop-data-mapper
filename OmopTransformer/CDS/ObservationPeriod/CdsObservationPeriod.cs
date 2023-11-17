using OmopTransformer.Annotations;
using OmopTransformer.Omop;

namespace OmopTransformer.CDS.ObservationPeriod;

[AggregateTransform("CDSObservationPeriod.xml")]
internal class CdsObservationPeriod : OmopObservationPeriod
{
}