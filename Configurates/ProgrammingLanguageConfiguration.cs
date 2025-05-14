using RSFRecomendations.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace RSFRecomendations.Configurations
{
    /// <summary>
    /// Конфигурация Языка 
    /// </summary>
    public class ProgrammingLanguageConfiguration : IEntityTypeConfiguration<ProgrammingLanguageModel>
    {
        /// <summary>
        /// Метод добавления конфигурации языка
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<ProgrammingLanguageModel> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .HasMany(p => p.UsersProgrammingLanguage)
                .WithOne(up => up.ProgrammingLanguage);

            builder
                .HasMany(p => p.Purposes)
                .WithMany(p => p.ProgrammingLanguages);
        }
    }
}
