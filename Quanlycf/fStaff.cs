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
        DataTable tblCL;
        static DataTable tblProduct;
        static DataTable tblAddProduct;
        int ID_order = -1; // lưu id của order được chọn

        public DateTime startTime;
        public DateTime endTime;
        long total_money_new = 0;
        public fStaff()
        {

            InitializeComponent();

            LoadOrder();
            AddOrder();
            startTime = DateTime.Now;
            endTime = startTime;

        }
        #region Method

        void LoadOrder()
        {
            if (tblCL != null)
                tblCL.Clear();
            dvgOrder.Columns.Clear();
            // dvgOrder.Refresh();
            Class.Function.Connect();
            string sql = "SELECT * FROM dbo.tblOrders" + "\n" +
                "WHERE statusOrder = 0 OR statusOrder=1 ORDER BY statusOrder";
            tblCL = Class.Function.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            Class.Function.Disconnect();



            tblCL.Columns.Add("status_str", typeof(String));



            dvgOrder.DataSource = tblCL; //Nguồn dữ liệu


            dvgOrder.Columns[0].Width = 50;
            dvgOrder.Columns[0].HeaderText = "Mã số";

            dvgOrder.Columns[1].Width = 40;
            dvgOrder.Columns[1].HeaderText = "MSNV";

            dvgOrder.Columns[2].Width = 60;
            dvgOrder.Columns[2].HeaderText = "Thành tiền";

            dvgOrder.Columns["statusOrder"].Visible = false;







            //dvgOrder.size
            dvgOrder.Columns[4].Visible = false;

            for (int i = 0; i < tblCL.Rows.Count; i++)
            {
                if ((int)tblCL.Rows[i][3] == 1)
                {
                    tblCL.Rows[i][5] = "Đã xong";
                    dvgOrder.Rows[i].Cells[5].Style.BackColor = Color.Green;
                }
                else
                {
                    tblCL.Rows[i][5] = "Đang chờ";
                    dvgOrder.Rows[i].Cells[5].Style.BackColor = Color.Red;
                }
            }
            dvgOrder.Columns["status_str"].HeaderText = "Trạng thái";

            dvgOrder.Columns["status_str"].Width = 90;
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
            // MessageBox.Show(id.ToString());
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
            LoadOrder();

        }
        private void DeleteOrder(int id)
        {

            string sql_delete = "UPDATE dbo.tblOrders \n SET statusOrder = 2 \n WHERE id = " + id.ToString() + ";";
            Class.Function.Connect();
            Class.Function.updateData(sql_delete);
            Class.Function.Disconnect();


            LoadOrder();
        }
        #endregion
        //phần bên phải
        public void AddOrderDetail()
        {



            int index = combo_MonAn.SelectedIndex;
            int id_product = (int)tblProduct.Rows[index][0];
            string name_product = tblProduct.Rows[index][1].ToString();
            long price_product = (int)tblProduct.Rows[index][2];
            int num = (int)numerSoLuong.Value;

            total_money_new += num * price_product;
            DataRow new_row = tblAddProduct.NewRow();
            new_row[0] = id_product;
            new_row[1] = name_product.ToString();
            new_row[2] = price_product;
            new_row[3] = num;
            tblAddProduct.Rows.Add(new_row);

        }
        public void CreatOrderDetail()
        {

        }
        public void DeleteProductInNewOrder(int row_index)
        {
            if (row_index < 0 || row_index >= tblAddProduct.Rows.Count)
                return;
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dvgAddProduct.DataSource];
            currencyManager1.SuspendBinding();
            tblAddProduct.Rows[row_index].Delete();
        }
        public void AddOrderToSql()
        {
            if (tblAddProduct.Rows.Count < 1)
            {
                MessageBox.Show("Chưa có món ăn được thêm!");
                return;
            }
            Class.Function.Connect();

            DialogResult dialogResult = MessageBox.Show("Tổng tiền là " + total_money_new.ToString() +" VNĐ", "Xác nhận thanh toán !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No)
                return;

            string sql = "INSERT INTO dbo.tblOrders(id_nv, ngay_ban, statusOrder, total_money)"
                    + "VALUES(1, \'20220421 2:25:00 PM\', 0," + total_money_new.ToString() + ")";
            Class.Function.updateData_nomesses(sql);

            string sql_getID_order = "SELECT MAX(id)" +
                                    "FROM tblOrders";
            //   "WHERE statusOrder = 0";
            DataTable tblMaxID = Class.Function.GetDataToTable(sql_getID_order);
            int id_order_new = Int32.Parse(tblMaxID.Rows[0][0].ToString());



            for (int i = 0; i < tblAddProduct.Rows.Count; i++)
            {

                int id_product = Int32.Parse(tblAddProduct.Rows[i][0].ToString());
                int price_product = Int32.Parse(tblAddProduct.Rows[i][2].ToString());
                int num_product = Int32.Parse(tblAddProduct.Rows[i][3].ToString());
                string sql_orderdetail = "INSERT INTO dbo.tblOrderDetail( order_id, product_id, price,num, total_money) \n"
                + "VALUES(" + id_order_new.ToString() + "," + id_product.ToString() + ","
                    + price_product.ToString() + "," + num_product.ToString() + "," +
                    (price_product * num_product).ToString() + ")";
                Class.Function.updateData_nomesses(sql_orderdetail);
            }
            Class.Function.Disconnect();
            tblAddProduct.Clear();


            total_money_new = 0;  //trả về 0 

            LoadOrder();
        }
        public void AddOrder()
        {

            tblAddProduct = new DataTable();
            tblAddProduct.Columns.Add("id");

            tblAddProduct.Columns.Add("name");



            tblAddProduct.Columns.Add("price");
            tblAddProduct.Columns.Add("number");
            dvgAddProduct.DataSource = tblAddProduct;

            dvgAddProduct.Columns["id"].Visible = false;
            dvgAddProduct.Columns["name"].HeaderText = "Tên Món";

            dvgAddProduct.Columns["price"].HeaderText = "Giá";
            dvgAddProduct.Columns["price"].Width = 70;

            dvgAddProduct.Columns["number"].HeaderText = "Số lượng";
            dvgAddProduct.Columns["number"].Width = 40;

            numerSoLuong.Minimum = 1;

            Class.Function.Connect();
            string sql_product = "SELECT id,title,price FROM dbo.tblProduct";
            tblProduct = Class.Function.GetDataToTable(sql_product);
            combo_MonAn.DataSource = tblProduct;

            combo_MonAn.DisplayMember = "title";

            button_addProduct.Tag = (Action)AddOrderDetail;
            buttonThanhtoan.Tag = (Action)AddOrderToSql;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

            btn.HeaderText = "";
            btn.Text = "Xóa";

            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            btn.Tag = (Action<int>)DeleteProductInNewOrder;
            dvgAddProduct.Columns.Add(btn);
        }



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
                int ID = Int32.Parse(tblCL.Rows[e.RowIndex][0].ToString());
                ID_order = ID;

                show_detailOrder(ID);
            }
        }
        private void dvgAddProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (e.RowIndex < 0)
            {
                //They clicked the header column, do nothing
                return;
            }

            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {

                var Delete_product_new_order = (Action<int>)grid.Columns[e.ColumnIndex].Tag;
                int ID = 1;
                //MessageBox.Show(grid[1, e.RowIndex].Value.ToString());


                Delete_product_new_order(e.RowIndex);
            }
        }

        private void fStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'managerCoffeeDataSet.tblOrders' table. You can move, or remove it, as needed.
            //this.tblOrdersTableAdapter.Fill(this.managerCoffeeDataSet.tblOrders);

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

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button_addProduct_Click(object sender, EventArgs e)
        {
            AddOrderDetail();
        }

        private void buttonThanhtoan_Click(object sender, EventArgs e)
        {
            AddOrderToSql();
        }

        private void numerSoLuong_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
