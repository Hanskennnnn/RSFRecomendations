using ArtFestival.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

public class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.HasKey(e => e.EventID);
        builder.Property(e => e.EventID)
            .ValueGeneratedOnAdd();
        builder.HasMany(e => e.Users)
            .WithOne(ue => ue.Event)
            .HasForeignKey(ue => ue.EventID);
        builder.Property(e => e.EventDate)
               .HasColumnType("timestamp with time zone");
    }
}