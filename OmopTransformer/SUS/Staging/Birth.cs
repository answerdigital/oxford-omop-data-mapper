namespace OmopTransformer.SUS.Staging;

public class Birth
{
    public Guid MessageId { get; init; }

    public string? BirthOrderBaby { get; init; }
    public string? DeliveryMethodBaby { get; init; }
    public string? GestationLengthAssessmentBaby { get; init; }
    public string? ResuscitationMethodBaby { get; init; }
    public string? StatusOfPersonConductingDeliveryBaby { get; init; }
    public string? LocalPatientIdentifierBaby { get; init; }
    public string? OrganisationCodeLocalPatientIDBaby { get; init; }
    public string? OrganisationCodeTypeLocalPatientIDBaby { get; init; }
    public string? NHSNumberBaby { get; init; }
    public string? NHSNumberStatusIndicatorBaby { get; init; }
    public string? BirthDateBabyBaby { get; init; }
    public string? BirthWeightBaby { get; init; }
    public string? LiveOrStillBirthBaby { get; init; }
    public string? SexBaby { get; init; }
    public string? BirthLocationType { get; init; }
    public string? LocationClassDeliveryPlaceActual { get; init; }
    public string? DeliveryPlaceTypeActual { get; init; }

    public bool IsEmpty =>
        BirthOrderBaby == null &&
        DeliveryMethodBaby == null &&
        GestationLengthAssessmentBaby == null &&
        ResuscitationMethodBaby == null &&
        StatusOfPersonConductingDeliveryBaby == null &&
        LocalPatientIdentifierBaby == null &&
        OrganisationCodeLocalPatientIDBaby == null &&
        OrganisationCodeTypeLocalPatientIDBaby == null &&
        NHSNumberBaby == null &&
        NHSNumberStatusIndicatorBaby == null &&
        BirthDateBabyBaby == null &&
        BirthWeightBaby == null &&
        LiveOrStillBirthBaby == null &&
        SexBaby == null &&
        BirthLocationType == null &&
        LocationClassDeliveryPlaceActual == null &&
        DeliveryPlaceTypeActual == null;
}