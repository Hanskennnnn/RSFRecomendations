using ArtFestival.Model;
using ArtFestival;
using Microsoft.EntityFrameworkCore;

public class EventUserRepository
{
    private readonly ArtFestivalDbContext _context;

    public EventUserRepository(ArtFestivalDbContext context)
    {
        _context = context;
    }
    public async Task AddUserToEvent(int userId, int eventId)
    {
        bool exists = await _context.EventUsers
            .AnyAsync(ep => ep.UserID == userId && ep.EventID == eventId);

        if (!exists)
        {
            var EventUser = new EventUser { UserID = userId, EventID = eventId };
            _context.EventUsers.Add(EventUser);
            await _context.SaveChangesAsync();
        }
    }

    public async Task RemoveUserFromEvent(int userId, int eventId)
    {
        var EventUser = await _context.EventUsers
            .FirstOrDefaultAsync(ep => ep.UserID == userId && ep.EventID == eventId);

        if (EventUser != null)
        {
            _context.EventUsers.Remove(EventUser);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<List<User>> GetUsersByEventId(int eventId)
    {
        return await _context.EventUsers
            .Where(ep => ep.EventID == eventId)
            .Select(ep => ep.User)
            .ToListAsync();
    }
}

