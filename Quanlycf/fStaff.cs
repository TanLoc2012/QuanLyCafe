using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlycf.DAO;
using Quanlycf.DTO;
namespace Quanlycf
{
    public partial class fStaff : Form
    {
        public fStaff()
        {
            InitializeComponent();
            LoadOrder();
        }
        #region Method

        void LoadOrder()
        {
            //List<Order> orderlist = Class.Function.GetDataToTable();
            //foreach (Order item in orderlist)
            //{
            //    Button btn = new Button() { Width = OrderDAO.OrderWidth, Height = OrderDAO.OrderHeight };

            //}
            Class.Function.Connect();
            DataGridViewColumn newCol = new DataGridViewColumn();
            string sql = "SELECT * FROM dbo.tblOrders";
            DataTable tblCL = Class.Function.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dvgOrder.DataSource = tblCL; //Nguồn dữ liệu            
            dvgOrder.Columns[0].Width = 50;
            dvgOrder.Columns[0].HeaderText = "Mã số";
            
            dvgOrder.Columns[1].Width = 50;
            dvgOrder.Columns[1].HeaderText = "MSNV";

            dvgOrder.Columns[2].Width = 70;
            dvgOrder.Columns[2].HeaderText = "Thành tiền";

            dvgOrder.Columns[3].Width = 50;
            dvgOrder.Columns[3].HeaderText = "Trạng thái";

            dvgOrder.Columns[4].Visible = false;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dvgOrder.Columns.Add(btn);
            btn.HeaderText = "Click Data";
            btn.Text = "Chi tiết";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            dvgOrder.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            
            dvgOrder.EditMode = DataGridViewEditMode.EditProgrammatically;
            Class.Function.Disconnect();

        }
    
        
        void ShowOrderDetail(int id)
        {
            
        }
    

    #endregion

    #region Event
   
        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        #endregion

        private void dvgOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Class.Function.Connect();
            string sql = "SELECT * FROM dbo.tblOrders";
            DataTable tblCL = Class.Function.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dvgOrder.DataSource = tblCL; //Nguồn dữ liệu            
            dvgOrder.Columns[0].Width = 100;
            dvgOrder.Columns[1].Width = 300;
            dvgOrder.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dvgOrder.EditMode = DataGridViewEditMode.EditProgrammatically;
            Class.Function.Disconnect();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
