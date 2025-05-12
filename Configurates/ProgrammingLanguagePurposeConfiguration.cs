using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RSFRecomendations.Models;

namespace RSFRecomendations.Configurates
{
    /// <summary>
    /// Конфигурация целей языка 
    /// </summary>
    public class ProgrammingLanguagePurposeConfiguration 
        : IEntityTypeConfiguration<ProgrammingLanguagePurposeModel>
    {
        public void Configure(EntityTypeBuilder<ProgrammingLanguagePurposeModel> builder)
        {
            builder.HasKey(p => new { p.ProgrammingLanguageId, p.Purpose });

            builder
                .HasOne(f => f.ProgrammingLanguage)
                .WithMany(u => u.Purposes);
        }
    }
}
