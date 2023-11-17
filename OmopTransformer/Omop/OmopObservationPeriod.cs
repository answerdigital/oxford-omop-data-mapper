namespace OmopTransformer.Omop;

internal abstract class OmopObservationPeriod : IOmopTarget
{
    public virtual DateTime observation_period_start_date { get; }
    public virtual DateTime observation_period_end_date { get; }
    public virtual DateTime period_type_concept_id { get; }
    public string OmopTargetTypeDescription => "Observation Period";
}