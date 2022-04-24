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
    public partial class fEditNV : Form
    {
        public fEditNV()
        {
            InitializeComponent();
        }

        private void fEditNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet5.tblRole' table. You can move, or remove it, as needed.
            this.tblRoleTableAdapter.Fill(this.masterDataSet5.tblRole);
            // TODO: This line of code loads data into the 'masterDataSet4.tblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.masterDataSet4.tblUser);

        }

        private void checkID_Click(object sender, EventArgs e)
        {
            if(IDbox.Text == "")
            {
                MessageBox.Show("Thiếu ID. Vui lòng nhập lại!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Class.Function.Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Class.Function.Con;
            cmd.CommandText = "SELECT * FROM [dbo].[tblUser] WHERE ID = " + IDbox.Text;
            SqlDataReader reader= cmd.ExecuteReader();
            if (reader.Read())
            {
                notifyID.Visible = false;
                inputNameNV.Text = reader["fullname"].ToString();
                if(reader["sex"].ToString() == "1")
                {
                    maleCheck.Checked = true;
                    femaleCheck.Checked = false;
                }
                else
                {
                    maleCheck.Checked = false;
                    femaleCheck.Checked = true;
                }
                jobList.SelectedValue = reader["role_id"];
                dateOfbirth.Text = reader["dob"].ToString();
                addressBox.Text = reader["addressU"].ToString();
                phoneBox.Text = reader["phone"].ToString();
                passBox.Text = reader["passwordNV"].ToString();
            }
            else
            {
                notifyID.Visible = true;
                notifyID.Text = "Không tồn tại ID = " + IDbox.Text;
                IDbox.Text = "";
            }
            Class.Function.Disconnect();

        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                passBox.UseSystemPasswordChar = false;
            }
            else
            {
                passBox.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "UPDATE [dbo].[tblUser] SET ";
            bool landau = true;
            if (changeName.Checked)
            {
                if(inputNameNV.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên để thay đổi", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                s += "fullname = '" + inputNameNV.Text + "'";
                landau = false;

            }
            if (changeSex.Checked)
            {
                if (maleCheck.Checked)
                {
                    if (!landau)
                    {
                        s += ",";
                    }
                    else
                    {
                        landau = false;
                    }
                    s += "sex = 1 ";
                }
                else
                {
                    if (!landau)
                    {
                        s += ",";
                    }
                    else
                    {
                        landau = false;
                    }
                    s += "sex = 0 ";
                }
            }
            if (changeDateOfBirth.Checked)
            {
                if (DateTime.Today.Year - dateOfbirth.Value.Year < 18 || DateTime.Today.Year - dateOfbirth.Value.Year > 60)
                {
                    MessageBox.Show("Nhân viên phải ở trong độ tuổi 18 - 60. Vui lòng kiêm tra lại", "Date of Birth Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!landau)
                {
                    s += ",";
                }
                else
                {
                    landau = false;
                }
                s += "dob = " + dateOfbirth.Value.Date.ToShortDateString();
            }
            if (changeJob.Checked)
            {
                if (!landau)
                {
                    s += ",";
                }
                else
                {
                    landau = false;
                }
                s += "role_id = " +jobList.SelectedValue.ToString();
            }
            if (changeAddress.Checked)
            {
                if (addressBox.Text == "")
                {
                    MessageBox.Show("Bạn chưa điền đầy đủ thông tin. Vui lòng kiểm tra lại!", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!landau)
                {
                    s += ",";
                }
                else
                {
                    landau = false;
                }
                s += "addressU = '" + addressBox.Text +"'";
            }
            if (changePhone.Checked)
            {
                if (phoneBox.Text == "")
                {
                    MessageBox.Show("Bạn chưa điền đầy đủ thông tin. Vui lòng kiểm tra lại!", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!landau)
                {
                    s += ",";
                }
                else
                {
                    landau = false;
                }
                s += "phone = '" + phoneBox.Text +"'";
            }
            if (changePass.Checked)
            {
                if (passBox.Text == "")
                {
                    MessageBox.Show("Bạn chưa điền đầy đủ thông tin. Vui lòng kiểm tra lại!", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!landau)
                {
                    s += ",";
                }
                else
                {
                    landau = false;
                }
                s += "passwordNV = '" + passBox.Text +"'";
            }
            s += " WHERE id = " + IDbox.Text.ToString() +";";
            Class.Function.Connect();
            Class.Function.interactQuery(s);
            Class.Function.Disconnect();
            this.Hide();

        }
    }
}
