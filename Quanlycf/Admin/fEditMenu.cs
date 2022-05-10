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
    public partial class fEditMenu : Form
    {
        public fEditMenu()
        {
            InitializeComponent();
        }

	  private void fEditMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'managerCoffeeDataSet2.tblRole' table. You can move, or remove it, as needed.
            this.tblProductTableAdapter.Fill(this.managerCoffeeDataSet3.tblProduct);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "UPDATE [dbo].[tblProduct] SET ";
            bool landau = true;
            if (changeTitle.Checked)
            {
                if (inputTitleMenu.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên để thay đổi", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                s += "title = '" + inputTitleMenu.Text + "'";
                landau = false;

            }
            if (changePrice.Checked)
            {
                if (int.Parse(priceBox.Text)<=0)
                {
                    MessageBox.Show("Giá phải lớn hơn 0. Vui lòng kiêm tra lại", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                s += "price = " + int.Parse(priceBox.Text);
            }
            if (changeDescription.Checked)
            {
                if (descriptionBox.Text == "")
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
                s += "descriptionP = '" + descriptionBox.Text + "'";
            }
            if (changeDiscount.Checked)
            {
                if (int.Parse(discountBox.Text)<0 || int.Parse(discountBox.Text)>=100)
                {
                    MessageBox.Show("Mức giảm sai. Vui lòng kiểm tra lại!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                s += "discount = '" + int.Parse(discountBox.Text) + "'";
            }
            if (changeThumbnail.Checked)
            {
                if (thumbnailBox.Text == "")
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
                s += "thumbnail = '" + thumbnailBox.Text + "'";
            }
            s += " WHERE id = " + IDbox.Text.ToString() + ";";
            Class.Function.Connect();
            Class.Function.updateData(s);
            Class.Function.Disconnect();
            this.Hide();
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
                inputTitleMenu.Text = reader["title"].ToString();
                thumbnailBox.Text = reader["thumbnail"].ToString();
                priceBox.Text = reader["price"].ToString();
                descriptionBox.Text = reader["descriptionP"].ToString();
                discountBox.Text = reader["discount"].ToString();
            }
            else
            {
                notifyID.Visible = true;
                notifyID.Text = "Không tồn tại ID = " + IDbox.Text;
                IDbox.Text = "";
            }
            Class.Function.Disconnect();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
