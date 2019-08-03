using System.Data.Entity;

namespace AnkitSinghAssignments.Models
{
    public class GuestListContext:DbContext
    {
        public DbSet<GuestList> guestList { get; set; }
    }
}