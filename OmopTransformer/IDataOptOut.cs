namespace OmopTransformer;

internal interface IDataOptOut
{
    bool PatientAllowed(string? nhsNumber);
    void PrintStats();
}