namespace OmopTransformer.CDS;

internal class CdsMappingNotes
{
    public const string VisitOccurrenceVisitDetailsNotes = 
           "### Assumptions\r\n" +
           "* `Emergency` covers a visit to A&E within the given Hospital Provider, and hence covers Admission Code 21 and 24 only\r\n" +
           "* `Location Class` ID 24 is a Consultant Clinic within the Health Care Provider.\r\n" +
           "* `Patient Classification` ID 1 is the only entry that covers 24 hours or more with the use of a bed, and whilst others may be a day/night only, they will be discounted because they are less than 24 hours. Also, maternity is also not taken as an \"\"Inpatient\"\" visit.\r\n" +
           "* No calculations to be made between Start and end visit date to try to calculate 24 hours, but instead the \"Patient Classification\" will be sufficient\r\n";
}