using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RSFRecomendations.Models;

namespace RSFRecomendations.Configurates
{
    /// <summary>
    /// Кофигурация Пользователя
    /// </summary>
    public class UserConfiguration : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .HasOne(u => u.FormModel)
                .WithOne(f => f.User);

            builder
                .HasMany(u => u.UsersProgrammingLanguage)
                .WithOne(up => up.User);
        }
    }
}
