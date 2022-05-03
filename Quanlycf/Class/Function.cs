using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quanlycf.Class
{
    class Function
    {
        public static SqlConnection Con;  //Khai báo đối tượng kết nối        

        public static void Connect()
        {
            Con = new SqlConnection();   //Khởi tạo đối tượng
            //Con.ConnectionString = @"Data Source=DESKTOP-6VUOC5Q\MYSERVER_SQL;Initial Catalog=ManagerCoffee;Integrated Security=True";
            Con.ConnectionString = @"Data Source=DESKTOP-KPRJ34J;Initial Catalog=ManagerCoffee;Integrated Security=True";
            Con.Open();                  //Mở kết nối
            //Kiểm tra kết nối
            if (!(Con.State == ConnectionState.Open))
                MessageBox.Show("Không thể kết nối với dữ liệu");

        }

        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            dap.Fill(table); //Đổ kết quả từ câu lệnh sql vào table
            return table;
        }

        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();   	//Đóng kết nối
                Con.Dispose(); 	//Giải phóng tài nguyên
                Con = null;
            }
        }
        public static bool updateData(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                switch (sqlEx.Number)
                {
                    case 273:
                        MessageBox.Show("Các giá trị nhập vào không hợp lệ, vui lòng kiểm tra lại!");
                        break;

                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Saved successfully!", "Message", MessageBoxButtons.OK);
            return true;
        }
        public static void stopConnect()
        {
            Con.Close();
        }

    }
}
