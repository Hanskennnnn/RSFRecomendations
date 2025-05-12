using RSFRecomendations.Models;

public class ProgrammingLanguagePurposeModel
{
    public Guid ProgrammingLanguageId { get; set; }
    public ProgrammingLanguageModel ProgrammingLanguage { get; set; }
    public Purpose Purpose { get; set; }
}
