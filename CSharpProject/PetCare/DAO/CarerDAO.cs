using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;

namespace DAO
{
    public class CarerDAO
    {
        public static bool checkLogin(string username, string password)
        {
            bool result = false;
            SqlConnection con = new SqlConnection("server=.;database=Fall2017;uid=sa;pwd=123");
            string sql = "select CarerID, Password from Carer where CarerID=@ID and Password=@Pass";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ID", username);
            cmd.Parameters.AddWithValue("@Pass", password);
            SqlDataReader dr;
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                result = dr.HasRows;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }
    }
}
