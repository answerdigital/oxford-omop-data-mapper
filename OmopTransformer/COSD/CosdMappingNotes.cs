namespace OmopTransformer.COSD;

internal class CosdMappingNotes
{
    public const string ConditionOccurrence = "### Assumptions\r\n" +
                                              "* For a given Diagnosis date, all valid combinations of Histology and Topography are added (thereby giving us an ICD-O-3 condition) as well as the ICD10 Diagnosis.\r\n" +
                                              "* Any changes in a Diagnosis that may occur in later submissions, for the same Diagnosis date, is taken to be an additional diagnosis as opposed to a change (hence removal of the original)\r\n" +
                                              "* If the same Diagnosis occurs but we have 2 separate `basis of diagnosis` values, then the first one will be taken only.				\r\n";
}