using ArtFestival.Model;

public class EventUser
{
    public int EventID { get; set; }
    public Event Event { get; set; } = null!;

    public int UserID { get; set; }
    public User User { get; set; } = null!;
}
