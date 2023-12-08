namespace OmopTransformer.CDS.Parser;

internal class BirthDetails
{
    private BirthDetails()
    {
    }


    public string? BirthOrder { get; set; }
    public string? DeliveryMethod { get; set; }
    public string? GestationLengthAssessment { get; set; }
    public string? ResuscitationMethod { get; set; }
    public string? StatusofPersonConductingDelivery { get; set; }
    public string? LocationClass { get; set; }
    public string? DeliveryPlaceTypeActual { get; set; }
    public string? ActivityLocationType { get; set; }
    public string? LocalPatientID { get; set; }
    public string? OrganisationCodeLocalPatientID { get; set; }
    public string? NHSNumber { get; set; }
    public string? NHSNumberStatusIndicator { get; set; }
    public string? WithheldFlag { get; set; }
    public string? WithheldIdentityReason { get; set; }
    public string? BabyBirthDate { get; set; }
    public string? BirthWeight { get; set; }
    public string? LiveStillBirth { get; set; }
    public string? PersonGenderCurrent { get; set; }
    public string? OverseasVisitorStatusClassificationAtCDSActivityDate { get; set; }

    public static BirthDetails? FromText(string text)
    {
        if (text == null) throw new ArgumentNullException(nameof(text));

        if (text.IsEmpty())
            return null;

        var index = 0;

        var birthDetails = new BirthDetails();

        birthDetails.BirthOrder = text.SubstringOrNull(index, 1);
        index += 1;
        birthDetails.DeliveryMethod = text.SubstringOrNull(index, 1);
        index += 1;
        birthDetails.GestationLengthAssessment = text.SubstringOrNull(index, 2);
        index += 2;
        birthDetails.ResuscitationMethod = text.SubstringOrNull(index, 1);
        index += 1;
        birthDetails.StatusofPersonConductingDelivery = text.SubstringOrNull(index, 1);
        index += 1;
        birthDetails.LocationClass = text.SubstringOrNull(index, 2);
        index += 2;
        birthDetails.DeliveryPlaceTypeActual = text.SubstringOrNull(index, 1);
        index += 1;
        birthDetails.ActivityLocationType = text.SubstringOrNull(index, 3);
        index += 3;
        birthDetails.LocalPatientID = text.SubstringOrNull(index, 1);
        index += 1;
        birthDetails.OrganisationCodeLocalPatientID = text.SubstringOrNull(index, 1);
        index += 1;
        birthDetails.NHSNumber = text.SubstringOrNull(index, 1);
        index += 1;
        birthDetails.NHSNumberStatusIndicator = text.SubstringOrNull(index, 2);
        index += 2;
        birthDetails.WithheldFlag = text.SubstringOrNull(index, 1);
        index += 1;
        birthDetails.WithheldIdentityReason = text.SubstringOrNull(index, 2);
        index += 2;
        birthDetails.BabyBirthDate = text.SubstringOrNull(index, 8);
        index += 8;
        birthDetails.BirthWeight = text.SubstringOrNull(index, 4);
        index += 4;
        birthDetails.LiveStillBirth = text.SubstringOrNull(index, 1);
        index += 1;
        birthDetails.PersonGenderCurrent = text.SubstringOrNull(index, 1);
        index += 1;
        birthDetails.OverseasVisitorStatusClassificationAtCDSActivityDate = text.SubstringOrNull(index, 1);
        index += 1;

        return birthDetails;
    }
}