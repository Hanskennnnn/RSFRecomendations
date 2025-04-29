using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RSFRecomendations.Models;

namespace RSFRecomendations.Configurates
{
    /// <summary>
    /// Конфигурация Анкеты
    /// </summary>
    public class FormModelConfiguration : IEntityTypeConfiguration<FormModel>
    {
        public void Configure(EntityTypeBuilder<FormModel> builder)
        {
            builder.HasKey(f => f.Id);

            builder
                .HasOne(f => f.User)
                .WithOne(u => u.FormModel)
                .HasForeignKey<FormModel>(f => f.UserId);
        }
    }
}
