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
        static DataTable tblCL;
        int ID_order = -1;
        public DateTime startTime;
        public DateTime endTime;
        public fStaff()
        {
            InitializeComponent();
            Class.Function.Connect();
            LoadOrder();
            startTime = DateTime.Now;
            endTime = startTime;
            Class.Function.Disconnect();
        }
        #region Method

        void LoadOrder()
        {
            string sql = "SELECT * FROM dbo.tblOrders" + "\n" +
                "WHERE statusOrder = 0 OR statusOrder=1";
            tblCL = Class.Function.GetDataToTable(sql); //Đọc dữ liệu từ bảng

            tblCL.Columns.Add("status_str", typeof(String));



            dvgOrder.DataSource = tblCL; //Nguồn dữ liệu


            dvgOrder.Columns[0].Width = 50;
            dvgOrder.Columns[0].HeaderText = "Mã số";

            dvgOrder.Columns[1].Width = 50;
            dvgOrder.Columns[1].HeaderText = "MSNV";

            dvgOrder.Columns[2].Width = 70;
            dvgOrder.Columns[2].HeaderText = "Thành tiền";

            dvgOrder.Columns["statusOrder"].Visible = false;







            //dvgOrder.size
            dvgOrder.Columns[4].Visible = false;

            for (int i = 0; i < tblCL.Rows.Count; i++)
            {
                if ((int)tblCL.Rows[i][3] == 1)
                {
                    tblCL.Rows[i][5] = "Đã xong";
                }
                else
                {
                    tblCL.Rows[i][5] = "Đang chờ";
                }
            }
            dvgOrder.Columns["status_str"].HeaderText = "Trạng thái";


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
            "WHERE   tblOrderDetail.order_id = " + id.ToString();


            DataTable Product_show = Class.Function.GetDataToTable(sqlOrderDetail);

            dvgOrderDetail.DataSource = Product_show;

            dvgOrderDetail.Columns["id"].Visible = false;
            dvgOrderDetail.Columns["order_id"].Visible = false;
            dvgOrderDetail.Columns["product_id"].Visible = false;


            dvgOrderDetail.Columns["title"].HeaderText = "Món";
            dvgOrderDetail.Columns["title"].Width = 150;
            dvgOrderDetail.Columns["title"].DisplayIndex = 1;

            dvgOrderDetail.Columns["num"].HeaderText = "Số Lượng";
            dvgOrderDetail.Columns["num"].Width = 50;
            dvgOrderDetail.Columns["num"].DisplayIndex = 2;


            dvgOrderDetail.Columns["price"].HeaderText = "Giá";
            dvgOrderDetail.Columns["price"].Width = 85;

            dvgOrderDetail.Columns["total_money"].HeaderText = "Thành tiền";
            dvgOrderDetail.Columns["total_money"].Width = 85;


            buttonDelete.Visible = true;
            buttonDelete.Tag = (Action<int>)DeleteOrder;
            buttonComplete.Visible = true;
            buttonComplete.Tag = (Action<int>)CompleteOrder;
            Class.Function.Disconnect();





        }
        private void CompleteOrder(int id)
        {
            string sql_complete = "UPDATE dbo.tblOrders \n SET statusOrder = 1 \n WHERE id = " + id.ToString() + ";";
            Class.Function.Connect();
            Class.Function.updateData(sql_complete);
            Class.Function.Disconnect();
            for (int i = 0; i < tblCL.Rows.Count; i++)
            {
                if ((int)tblCL.Rows[i][0] == id)
                {
                    tblCL.Rows[i][5] = "Đã xong";
                    tblCL.Rows[i][3] = 1;
                    return;
                }

            }
        }
        private void DeleteOrder(int id)
        {

            string sql_delete = "UPDATE dbo.tblOrders \n SET statusOrder = 2 \n WHERE id = " + id.ToString() + ";";
            Class.Function.Connect();
            Class.Function.updateData(sql_delete);
            Class.Function.Disconnect();
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dvgOrder.DataSource];
            currencyManager1.SuspendBinding();


            for (int i = 0; i < tblCL.Rows.Count; i++)
            {
                if ((int)tblCL.Rows[i][0] == id)
                {

                    dvgOrder.Rows[i].Visible = false;
                    currencyManager1.ResumeBinding();
                    dvgOrderDetail.DataSource = null;
                    return;
                }

            }
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
                int ID = (int)grid[1, e.RowIndex].Value;
                ID_order = ID;

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

        private void buttonComplete_Click(object sender, EventArgs e)
        {

            if (ID_order >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn hóa đơn đã hoàn thành ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                    CompleteOrder(ID_order);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (ID_order >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn  không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)

                    DeleteOrder(ID_order);
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Run(new fAdmin());
        }
    }

}
