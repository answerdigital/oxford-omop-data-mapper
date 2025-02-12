namespace OmopTransformer.SUS.Staging.Inpatient.APC;

internal class OverseasVisitor
{
    public Guid MessageId { get; init; }

    public string? OverseasVisitorStatusClassification { get; init; }
    public string? OverseasVisitorStatusStartDate { get; init; }

    public bool IsEmpty => OverseasVisitorStatusClassification == null && OverseasVisitorStatusStartDate == null;
}