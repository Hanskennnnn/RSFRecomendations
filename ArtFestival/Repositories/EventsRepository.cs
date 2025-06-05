using ArtFestival.Model;
using Microsoft.EntityFrameworkCore;
namespace ArtFestival.Repositories
{
    public class EventsRepository
    {
        private readonly ArtFestivalDbContext _dbContext;

        public EventsRepository(ArtFestivalDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Event>> Get()
        {
            return await _dbContext.Events
                .AsNoTracking()
                .OrderBy(e => e.EventID)
                .ToListAsync();
        }
        public async Task Add(int eventId, DateTime eventDate, string title, string description, string category, string path)
        {
            var eff = new Event 
            { 
                EventID = eventId, 
                EventDate = eventDate, 
                Title = title, 
                Description = description, 
                Category = category ,
                ImagePath = path
            };
            await _dbContext.AddAsync(eff);
            await _dbContext.SaveChangesAsync();
        }


    }
}
