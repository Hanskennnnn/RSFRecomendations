
using ArtFestival.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.UserID);
        builder.Property(u => u.UserID)
            .ValueGeneratedOnAdd();
        builder.HasMany(u => u.Events)
            .WithOne(ue => ue.User)
            .HasForeignKey(ue => ue.UserID);
        builder.HasData(
        new User { UserID = 1, Name = "Иван Петров" },
        new User { UserID = 2, Name = "Мария Сидорова" },
        new User { UserID = 3, Name = "Алексей Иванов" },
        new User { UserID = 4, Name = "Елена Васильева" },
        new User { UserID = 5, Name = "Дмитрий Смирнов" }
    );

    }
}