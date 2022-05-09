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
    public partial class fAddMenu : Form
    {
        public fAddMenu()
        {
            InitializeComponent();
        }

        private void createBox_Click(object sender, EventArgs e)
        {

            if (categoryBox.Text == "" || titleBox.Text == "" || int.Parse(priceBox.Text) <= 0 || thumbnailBox.Text == "" || descriptionBox.Text == "" || (int.Parse(discountBox.Text) <0 || int.Parse(discountBox.Text) >= 100))
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin. Vui lòng kiểm tra lại!", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string s = "INSERT INTO [dbo].[tblProduct] VALUES (" + categoryBox.Text + ",'" + titleBox.Text + "','" + priceBox.Text + "','" + thumbnailBox.Text + "','" + descriptionBox.Text + "','" + discountBox.Text + "');";

            Class.Function.Connect();
            if (Class.Function.updateData(s))
            {
                Class.Function.Disconnect();
                this.Hide();
            }
            //Class.Function.Disconnect();
        }

        private void fAddMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'managerCoffeeDataSet3.tblProduct' table. You can move, or remove it, as needed.
            this.tblProductTableAdapter.Fill(this.managerCoffeeDataSet3.tblProduct);
        }

        private void tblProductBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
