using System.Data.Entity;

namespace AnkitSinghAssignments.Models
{
    /// <summary>Context class</summary>
    /// <seealso cref="System.Data.Entity.DbContext" />

    public class GuestListContext:DbContext
    {
        public DbSet<GuestList> guestList { get; set; }
    }
}