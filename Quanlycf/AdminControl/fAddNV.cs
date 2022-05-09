using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlycf
{
    public partial class fAddNV : Form
    {
        public fAddNV()
        {
            InitializeComponent();
        }

        private void createBox_Click(object sender, EventArgs e)
        {

            if (nameBox.Text == "" || (!maleBox.Checked && !femaleBox.Checked) || addressBox.Text == "" || phoneBox.Text == "" || passBox.Text == "" || userNameBox.Text == "")
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
            s = "INSERT INTO [dbo].[tblUser] VALUES (" + jobBox.SelectedValue.ToString() + ",0,'" + passBox.Text + "','" + nameBox.Text + "'," + temp.ToString() + ",'" + dateTimeBox.Value.Date.ToString() + "','" + addressBox.Text + "','" + phoneBox.Text + "','" + userNameBox.Text + "');";
            //INSERT INTO [dbo].[tblUser] VALUES (1,0,'HOLA','Vu Dang Khoa', 1,'1988-05-22','Tay Ninh','0937811504');
            Class.Function.Connect();
            if (Class.Function.updateData(s))
            {
                Class.Function.Disconnect();
                this.Hide();

            }
            //Class.Function.Disconnect();
        }

        private void fAddNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'managerCoffeeDataSet1.tblRole' table. You can move, or remove it, as needed.
            this.tblRoleTableAdapter.Fill(this.managerCoffeeDataSet1.tblRole);

        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
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
    }
}
