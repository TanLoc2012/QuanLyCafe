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
    public partial class fStaff : Form
    {
        public fStaff()
        {
            InitializeComponent();
            DAO.Function.Connect();
            LoadOrder();
            DAO.Function.Disconnect();
        }
        #region Method

        void LoadOrder()
        {
            //List<Order> orderlist = Class.Function.GetDataToTable();
            //foreach (Order item in orderlist)
            //{
            //    Button btn = new Button() { Width = OrderDAO.OrderWidth, Height = OrderDAO.OrderHeight };

            //}
            
            //string sql = "SELECT * FROM dbo.tblOrders";
            //DataTable tblCL = Class.Function.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            //dvgOrder.DataSource = tblCL; //Nguồn dữ liệu            
            //dvgOrder.Columns[0].Width = 50;
            //dvgOrder.Columns[0].HeaderText = "Mã số";

            //dvgOrder.Columns[1].Width = 50;
            //dvgOrder.Columns[1].HeaderText = "MSNV";

            //dvgOrder.Columns[2].Width = 70;
            //dvgOrder.Columns[2].HeaderText = "Thành tiền";

            //dvgOrder.Columns[3].Width = 50;
            //dvgOrder.Columns[3].HeaderText = "Trạng thái";
            ////dvgOrder.size
            //dvgOrder.Columns[4].Visible = false;
            //DataGridViewLinkColumn btn = new DataGridViewLinkColumn();
            //dvgOrder.Columns.Add(btn);
            //btn.HeaderText = "Click Data";
            //btn.Text = "Chi tiết";
            //btn.Name = "btn";
            //btn.UseColumnTextForLinkValue = true;

            dvgOrder.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dvgOrder.Columns["detail"].Tag = (Action<int>)ShowOrderDetail;  //gán tag cho sự kiện click
            dvgOrder.EditMode = DataGridViewEditMode.EditProgrammatically;
            

        }


        public void ShowOrderDetail(int id)
        {
            DAO.Function.Connect();
            
            string sqlOrderDetail = "SELECT * FROM tblOrderDetail" + "\n"+
            "WHERE tblOrderDetail.order_id = "+id.ToString();
            string sqlProduct = "SELECT * FROM tblProduct";
            DataTable tblDetail = DAO.Function.GetDataToTable(sqlOrderDetail);
            DataTable tblProduct = DAO.Function.GetDataToTable(sqlProduct);
            DataTable Product_show = new DataTable();
            Product_show.Columns.Add("id");
            Product_show.Columns.Add("category_id");
            Product_show.Columns.Add("title");
            Product_show.Columns.Add("thumbnail");
            Product_show.Columns.Add("descriptionP");
            Product_show.Columns.Add("deleted");
            Product_show.Columns.Add("discount");

            foreach (DataRow row_orderdetail in tblDetail.Rows)
            {
                foreach(DataRow row_product in tblProduct.Rows )
                {
                    if ((int)row_orderdetail["product_id"] ==(int)row_product["id"])
                    {
                        Product_show.Rows.Add(row_product);
                    }    
                }
                
            }
            dvgOrderDetail.DataSource = Product_show;
            DAO.Function.Disconnect();
            







            //    string sqlProducts = "SELECT * FROM tblProduct" +
            //    "WHERE tblOrder.id="+
            //DataTable tblProducts = DAO.Function.GetDataToTable(sqlProducts);
            //dvgOrderDetail.DataSource = tblDetail;
           
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

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
    }

}
