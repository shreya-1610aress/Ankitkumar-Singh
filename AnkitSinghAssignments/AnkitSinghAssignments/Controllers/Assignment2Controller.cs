using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AnkitSinghAssignments.Models;
namespace AnkitSinghAssignments.Controllers
{
    public class Assignment2Controller : Controller
    {
        // GET: Assignment2
        public ActionResult Index()
        {
            GuestListContext guestListContext = new GuestListContext();
            List <GuestList> guests = guestListContext.guestList.ToList();
            return View(guests);
        }

        public ActionResult Guestshow(int id)
        {
            GuestListContext guestListContext = new GuestListContext();
            GuestList guest = guestListContext.guestList.Single(x => x.GueastId == id);
            return View(guest);
        }

    }
}
