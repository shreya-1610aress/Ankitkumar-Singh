using System.Data;
using System.Web.Mvc;
using AnkitSinghAssignments.Models;

namespace AnkitSinghAssignments.Controllers
{
    public class Assignment3Controller : Controller
    {
        // GET: Assignment3
        public ActionResult Index()
        {
            GuestManagement guestManagement = new GuestManagement();
            DataTable dt= guestManagement.getGuest();
            return View(dt);
        }
    }
}