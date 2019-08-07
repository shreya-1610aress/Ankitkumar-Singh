using System.ComponentModel.DataAnnotations;
namespace AnkitSinghAssignments.Models
{
    /// <summary> Model class</summary>
    public class GuestResponse
    {
        [Key]
        public int GuestId { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
        ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public decimal Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}