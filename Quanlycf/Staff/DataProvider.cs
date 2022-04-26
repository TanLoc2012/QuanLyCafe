using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlycf.DAO
{
    class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }


        private string connectionString = @"Data Source=desktop-5bjtq7n\sqlexpress;Initial Catalog=ManageCoffee;Integrated Security=True";
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using(SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if(parameter != null)
                {
                    string[] listParam = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParam)
                    {
                        cmd.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.Fill(data);
                con.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter)
        {
            int data = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameter != null)
                {
                    string[] listParam = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParam)
                    {
                        cmd.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
                data = cmd.ExecuteNonQuery();
                con.Close();
            }
            return data;
        }

        public object ExecuteScala(string query, object[] parameter)
        {
            object data = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameter != null)
                {
                    string[] listParam = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParam)
                    {
                        cmd.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
                data = cmd.ExecuteScalar();
                con.Close();
            }
            return data;
        }
    }
}
