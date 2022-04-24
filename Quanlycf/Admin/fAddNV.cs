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
// This library use for manipulate digit like phone number
using System.Linq;

namespace Quanlycf
{
    public partial class fAddNV : Form
    {
        public fAddNV()
        {
            InitializeComponent();
        }

        private void fAddNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet3.tblRole' table. You can move, or remove it, as needed.
            this.tblRoleTableAdapter.Fill(this.masterDataSet3.tblRole);
            // TODO: This line of code loads data into the 'masterDataSet2.tblCategory' table. You can move, or remove it, as needed.
            this.tblCategoryTableAdapter.Fill(this.masterDataSet2.tblCategory);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (nameBox.Text== "" || (!maleBox.Checked && !femaleBox.Checked) || addressBox.Text == "" || phoneBox.Text == "" || passBox.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin. Vui lòng kiểm tra lại!", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DateTime.Today.Year - dateTimeBox.Value.Year < 18 || DateTime.Today.Year - dateTimeBox.Value.Year > 60)
            {
                MessageBox.Show("Nhân viên phải ở trong độ tuổi 18 - 60. Vui lòng kiêm tra lại", "Date of Birth Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string s = phoneBox.Text;
            if (s[0] < '0' || s[0] > '9' || !s.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại nhập vào không hợp lệ!", "failed Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int temp = 0;
            if (maleBox.Checked)
                temp = 1;
            s = "INSERT INTO [dbo].[tblUser] VALUES (" + jobBox.SelectedValue.ToString() + ",0,'" + passBox.Text + "','" + nameBox.Text + "'," + temp.ToString() + ",'" + dateTimeBox.Value.Date.ToString() + "','" + addressBox.Text + "','" + phoneBox.Text + "');";
            //INSERT INTO [dbo].[tblUser] VALUES (1,0,'HOLA','Vu Dang Khoa', 1,'1988-05-22','Tay Ninh','0937811504');
            Class.Function.Connect();
            if (Class.Function.interactQuery(s))
            {
                Class.Function.Disconnect();
                this.Hide();
         
            }
            //Class.Function.Disconnect();
            

            





        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.showPass.Checked == true)
            {
                this.passBox.UseSystemPasswordChar = false;
            }
            else if (this.showPass.Checked == false)
            {
                this.passBox.UseSystemPasswordChar = true;
            }
        }

        private void jobBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
