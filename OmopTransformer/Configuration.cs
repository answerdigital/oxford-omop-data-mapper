namespace OmopTransformer;

internal class Configuration
{
    public string? ConnectionString { get; set; }
    public string? VocabularyDirectory { get; set; } = "/vocabulary";
    public int? BatchSize { get; set; }
}
