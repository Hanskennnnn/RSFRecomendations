using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

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
            builder.HasKey(p => p.Id);

            builder
                .HasMany(p => p.Forms)
                .WithOne(f => f.PurposeForm)
                .HasForeignKey(f => f.PurposeId);
        }
    }
}
