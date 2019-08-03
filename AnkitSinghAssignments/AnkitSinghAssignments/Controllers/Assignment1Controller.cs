using System;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using AnkitSinghAssignments.Models;

namespace AnkitSinghAssignments.Controllers
{
    public class Assignment1Controller : Controller
    {
        // GET: Assignment1 View.
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                //TODO: Email response to the party organizer
                //SmtpClient smtpClient = new SmtpClient();
                //smtpClient.EnableSsl = true;

                //MailMessage msg = new MailMessage("wcyber23@gmail.com", guestResponse.Email);
                //msg.Subject = "Hey, welcome.";
                //msg.Body = "You are invited for the party";

                //smtpClient.Send(msg);
                return View("Thanks", guestResponse);
            }
            else
            {
                // there is a validation error
                return View();
            }



        }
    }
}