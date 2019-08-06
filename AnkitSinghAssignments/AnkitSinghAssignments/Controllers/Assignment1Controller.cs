using AnkitSinghAssignments.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Web.Mvc;

namespace AnkitSinghAssignments.Controllers
{
    public class Assignment1Controller : Controller
    {
        // View Page call.
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        //Post form data to database and sent mail to the user.
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                // Email response to the party organizer
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.EnableSsl = true;

                MailMessage msg = new MailMessage("wcyber23@gmail.com", guestResponse.Email);
                msg.Subject = "Hey, welcome.";
                msg.Body = "You are invited for the party";
                smtpClient.Send(msg);

                // Insert form data to database.
                string connectionString = ConfigurationManager.ConnectionStrings["GuestListContext"].ConnectionString;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO GuestList(Name, Email, Phone, WillAttend) VALUES(@name, @email, @phone, @willAttend)", con))
                    {
                        cmd.Parameters.AddWithValue("@name", guestResponse.Name);
                        cmd.Parameters.AddWithValue("@email", guestResponse.Email);
                        cmd.Parameters.AddWithValue("@phone", guestResponse.Phone);
                        cmd.Parameters.AddWithValue("@willAttend", guestResponse.WillAttend);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        return View("Thanks", guestResponse);
                    }
                }           
            }
            else
            {
                // To show validation errors.
                return View();
            }
        }
    }
}