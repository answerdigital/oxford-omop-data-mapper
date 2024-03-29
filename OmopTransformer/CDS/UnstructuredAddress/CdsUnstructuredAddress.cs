﻿using OmopTransformer.Annotations;

namespace OmopTransformer.CDS.UnstructuredAddress;

[DataOrigin("CDS")]
[Description("CDS UnstructuredAddress")]
[SourceQuery("CdsUnstructuredAddress.xml")]
internal class CdsUnstructuredAddress
{
    public string? PatientUnstructuredAddress { get; set; }
    public string? Postcode { get; set; }
}