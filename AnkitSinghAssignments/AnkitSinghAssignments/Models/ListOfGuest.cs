using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnkitSinghAssignments.Models
{
    [Table("GuestList")]
    public class ListOfGuest
    {
        [Key]
        public int GuestId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Phone { get; set; }
        public bool WillAttend { get; set; }
    }
}