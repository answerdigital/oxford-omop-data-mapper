﻿namespace OmopTransformer.SUS.Staging;

internal class OverseasVisitor
{
    public Guid MessageId { get; init; }

    public string? OverseasVisitorStatusClassification { get; init; }
    public string? OverseasVisitorStatusStartDate { get; init; }

    public bool IsEmpty => OverseasVisitorStatusClassification == null && OverseasVisitorStatusStartDate == null;
}