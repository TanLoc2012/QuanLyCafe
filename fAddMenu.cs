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

            if (categoryBox.Text == "" || titleBox.Text == "" || priceBox.Text == "" || thumbnailBox.Text == "" || descriptionBox.Text == "" || discountBox.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin. Vui lòng kiểm tra lại!", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            s = "INSERT INTO [dbo].[tblProduct] VALUES (" + categoryBox.Text + ",'" + titleBox.Text + "','" + priceBox.Text + "','" + thumbnailBox.Text + "','" + descriptionBox.Text + "','" + discountBox.Text + "');";
            //INSERT INTO [dbo].[tblUser] VALUES (1,0,'HOLA','Vu Dang Khoa', 1,'1988-05-22','Tay Ninh','0937811504');
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
            // TODO: This line of code loads data into the 'managerCoffeeDataSet1.tblRole' table. You can move, or remove it, as needed.
            this.tblProductTableAdapter.Fill(this.managerCoffeeDataSet1.tblProduct);

        }
    }
}
