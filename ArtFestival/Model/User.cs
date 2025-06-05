using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ArtFestival.Model
{
    public class User
    {

        public int UserID { get; set; }
        public string Name { get; set; }
        public List<EventUser> Events { get; set; }
    }
}
