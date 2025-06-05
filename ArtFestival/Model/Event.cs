using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ArtFestival.Model
{
    public class Event
    {
        public int EventID { get; set; }
        public DateTime EventDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string? ImagePath { get; set; }

        public List<EventUser> Users { get; set; } 
    }
}
