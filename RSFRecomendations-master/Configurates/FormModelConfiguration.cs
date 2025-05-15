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
        /// <summary>
        /// Метод добавления конфигурации анкеты
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<FormModel> builder)
        {
            builder.HasKey(f => f.Id);

            builder
                .HasOne(f => f.User)
                .WithOne(u => u.FormModel)
                .HasForeignKey<FormModel>(f => f.UserId);

            builder
                .HasOne(f => f.PurposeForm)
                .WithMany(p => p.Forms)
                .HasForeignKey(f => f.PurposeId);
        }
    }
}
