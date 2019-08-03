using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AnkitSinghAssignments.Models
{
    public class GuestManagement
    {
        public DataTable getGuest() {
            DataTable dt = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["userManagementConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from GuestList", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;


        }
    }
}
