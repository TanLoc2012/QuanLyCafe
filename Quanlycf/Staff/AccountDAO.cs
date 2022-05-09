using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlycf.Staff
{
    class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO() { }

        public int Login(string username, string password)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = @"Data Source=DESKTOP-6VUOC5Q\MYSERVER_SQL;Initial Catalog=ManagerCoffee;Integrated Security=True";
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "authentication";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@passwordNV", password);
                cmd.Connection = conn;
                object kq = cmd.ExecuteScalar();
                int code = Convert.ToInt32(kq);
                conn.Close();
                return code;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 3;
        }
    }
}
