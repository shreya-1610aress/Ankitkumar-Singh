using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AnkitSinghAssignments.Models
{
    public class GuestManagement
    {
        /// <summary>Gets the guest list from database.</summary>
        /// <returns> Guest list to view page.</returns>
        public DataTable getGuest() {
            DataTable dt = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["GuestListContext"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from GuestList", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }
    }
}
