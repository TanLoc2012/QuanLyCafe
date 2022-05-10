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
    public partial class fViewDetail : Form
    {
        public fViewDetail()
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
            try
            {


                Class.Function.Connect();
                string sql = "SELECT[dbo].[tblOrderDetail].product_id, [dbo].[tblProduct].title, [dbo].[tblOrderDetail].price, [dbo].[tblOrderDetail].num, [dbo].[tblOrderDetail].total_money" +
                    " FROM[dbo].[tblOrderDetail], [dbo].[tblProduct] " +
                    "WHERE [dbo].[tblOrderDetail].product_id = [dbo].[tblProduct].id AND [dbo].[tblOrderDetail].order_id = " + IDbox.Text + ";";
                DataTable tblCL = Class.Function.GetDataToTable(sql);
                OrderDetail.DataSource = tblCL;
                OrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                //dvgUser.AllowUserToOrderColumns = true;
                //dvgUser.AllowUserToResizeColumns = true;
                // dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
                OrderDetail.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
                OrderDetail.EditMode = DataGridViewEditMode.EditProgrammatically;
                OrderDetail.AllowUserToResizeColumns = true;

                Class.Function.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nào đó đã xảy ra! Vui lòng kiểm tra ID đã nhập hoặc đường truyền Server", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
