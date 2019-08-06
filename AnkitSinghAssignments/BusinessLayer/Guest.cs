using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    /// <summary>Model class </summary>
    public class Guest
    {
        public int GuestId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public decimal Phone { get; set; }
        [Required]
        public bool? WillAttend { get; set; }
    }
}
