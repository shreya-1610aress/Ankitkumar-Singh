using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class GuestBusinessLayer
    {
        #region "Global Declaration"
        /// <summary>The connection string</summary>
        public string connectionString = ConfigurationManager.ConnectionStrings["GuestListContext"].ConnectionString;
        #endregion

        #region "Get Guests from Database"
        /// <summary>Gets the Guests details.</summary>
        /// <value>The Guests.</value>
        public IEnumerable<Guest> Guests
        {
            get
            {
                List<Guest> guests = new List<Guest>();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM GuestList", con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Guest guest = new Guest();
                        guest.GuestId = Convert.ToInt32(rdr["GuestId"]);
                        guest.Name = rdr["Name"].ToString();
                        guest.Email = rdr["Email"].ToString();
                        guest.Phone = Convert.ToDecimal(rdr["Phone"]);
                        guest.WillAttend = Convert.ToBoolean(rdr["WillAttend"]);

                        guests.Add(guest);
                    }
                }

                return guests;
            }
        }
        #endregion


        #region "Update Guest"
        /// <summary>Updates the guest.</summary>
        /// <param name="guest">The guest.</param>
        public void UpdateGuest(Guest guest)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE GuestList SET [Name] = @Name, [Email] = @Email, [Phone] = @Phone, [WillAttend] = @WillAttend  WHERE GuestId = @GuestId; ", con))
                {
                    cmd.Parameters.AddWithValue("@GuestId", guest.GuestId);
                    cmd.Parameters.AddWithValue("@Name", guest.Name);
                    cmd.Parameters.AddWithValue("@Email", guest.Email);
                    cmd.Parameters.AddWithValue("@Phone", guest.Phone);
                    cmd.Parameters.AddWithValue("@WillAttend", guest.WillAttend);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        public void DeleteGuest(int GuestId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM GuestList WHERE GuestId = @GuestId", con))
                {
                    cmd.Parameters.AddWithValue("@GuestId", GuestId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
