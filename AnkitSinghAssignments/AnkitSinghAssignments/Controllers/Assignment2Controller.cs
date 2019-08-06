using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AnkitSinghAssignments.Models;
namespace AnkitSinghAssignments.Controllers
{
    public class Assignment2Controller : Controller
    {
        // To show (list) all guest on index view.
        public ActionResult Index()
        {
            GuestListContext guestListContext = new GuestListContext();
            List <GuestList> guests = guestListContext.guestList.ToList();
            return View(guests);
        }

        //To show specific guest deatils with selected id.
        public ActionResult Guestshow(int id)
        {
            GuestListContext guestListContext = new GuestListContext();
            GuestList guest = guestListContext.guestList.Single(x => x.GuestId == id);
            return View(guest);
        }

    }
}
