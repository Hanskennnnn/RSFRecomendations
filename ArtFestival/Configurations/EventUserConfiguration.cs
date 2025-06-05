using ArtFestival.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class EventUserConfiguration : IEntityTypeConfiguration<EventUser>
{
    public void Configure(EntityTypeBuilder<EventUser> builder)
    {
        builder.HasKey(ep => new { ep.EventID, ep.UserID });
        builder.HasOne(ep => ep.Event)
               .WithMany(e => e.Users)
               .HasForeignKey(ep => ep.EventID);
        builder.HasOne(ep => ep.User)
               .WithMany(u => u.Events)
               .HasForeignKey(ep => ep.UserID);
    }
}
