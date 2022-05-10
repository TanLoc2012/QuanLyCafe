using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quanlycf
{
    public partial class fDeleteMenu : Form
    {
        public fDeleteMenu()
        {
            InitializeComponent();
        }

        private void checkID_Click(object sender, EventArgs e)
        {
            if (IDbox.Text == "")
            {
                MessageBox.Show("Thiếu ID. Vui lòng nhập lại!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Class.Function.Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Class.Function.Con;
            cmd.CommandText = "SELECT * FROM [dbo].[tblProduct] WHERE ID = " + IDbox.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                IDbox.Text = reader["ID"].ToString();
                label1.Text = "Đã tìm thấy ID = " + IDbox.Text;
                label1.Visible = true;
            }
            else
            {
                label1.Visible = true;
                label1.Text = "Không tồn tại ID = " + IDbox.Text;
                IDbox.Text = "";
            }
            Class.Function.Disconnect();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (IDbox.Text == "")
            {
                MessageBox.Show("Thiếu ID. Vui lòng nhập lại!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string s = "UPDATE [dbo].[tblProduct] SET deleted = 1 WHERE id = " + IDbox.Text + ";";
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa ID = " + IDbox.Text + " không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                Class.Function.Connect();
                Class.Function.updateData(s);
                Class.Function.Disconnect();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void fDeleteMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
