using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlycf.Class;
namespace Quanlycf
{
    public partial class fStaff : Form
    {
        public fStaff()
        {
            InitializeComponent();
            Class.Function.Connect();
            LoadOrder();
            Class.Function.Disconnect();
        }
        #region Method

        void LoadOrder()
        {
            //List<Order> orderlist = Class.Function.GetDataToTable();
            //foreach (Order item in orderlist)
            //{
            //    Button btn = new Button() { Width = OrderDAO.OrderWidth, Height = OrderDAO.OrderHeight };

            //}

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
            //dvgOrder.size
            dvgOrder.Columns[4].Visible = false;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            
            btn.HeaderText = "";
            btn.Text = "Chi tiết";
            
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            btn.Tag = (Action<int>)ShowOrderDetail;
            dvgOrder.Columns.Add(btn);

            dvgOrder.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            
            dvgOrder.EditMode = DataGridViewEditMode.EditProgrammatically;
            

        }


        public void ShowOrderDetail(int id)
        {
            Class.Function.Connect();

            string sqlOrderDetail = "SELECT tblOrderDetail.*, tblProduct.title" + "\n" +
            "FROM tblOrderDetail LEFT JOIN tblProduct on tblProduct.id = tblOrderDetail.product_id" + "\n" +
            "WHERE tblOrderDetail.order_id = " + id.ToString();


            DataTable Product_show = Class.Function.GetDataToTable(sqlOrderDetail);
            dvgOrderDetail.DataSource = Product_show;

            dvgOrderDetail.Columns["id"].Visible = false;
            dvgOrderDetail.Columns["order_id"].Visible = false;
            dvgOrderDetail.Columns["product_id"].Visible = false;


            dvgOrderDetail.Columns["title"].HeaderText = "Món";
            dvgOrderDetail.Columns["title"].Width = 150;
            

            dvgOrderDetail.Columns["price"].HeaderText = "Thành tiền";
            dvgOrderDetail.Columns["price"].Width = 60;



            Class.Function.Disconnect();
            







            
           
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

       

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          var grid = (DataGridView)sender;

            if (e.RowIndex < 0)
            {
                //They clicked the header column, do nothing
                return;
            }

            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {

                var show_detailOrder = (Action<int>)grid.Columns[e.ColumnIndex].Tag;
                int ID = (int)dvgOrder.Rows[e.RowIndex].Cells[0].Value;

                show_detailOrder(ID); 
            }
        }
        private void dvgAddProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'managerCoffeeDataSet.tblOrders' table. You can move, or remove it, as needed.
            this.tblOrdersTableAdapter.Fill(this.managerCoffeeDataSet.tblOrders);

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dvgOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
