using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RSFRecomendations.Models;

namespace RSFRecomendations.Configurates
{
    /// <summary>
    /// Конфигурация Пользователя языка
    /// </summary>
    public class UserProgrammingLanguageConfiguration : IEntityTypeConfiguration<UserProgrammingLanguageModel>
    {
        public void Configure(EntityTypeBuilder<UserProgrammingLanguageModel> builder)
        {
            builder.HasKey(up => new { up.UserId, up.ProgramminLanguageId } );

            builder
                .HasOne(up => up.User)
                .WithMany(u => u.UsersProgrammingLanguage);

            builder
                .HasOne(up => up.ProgrammingLanguage)
                .WithMany(p => p.UsersProgrammingLanguage);
        }
    }
}
