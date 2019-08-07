using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnkitSinghAssignments.Models
{
    public partial class GuestList
    {
        public int GuestId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Phone { get; set; }
        public bool WillAttend { get; set; }
    }
}