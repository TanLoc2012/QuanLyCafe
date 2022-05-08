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
using Quanlycf.Staff;
using System.Globalization; 
namespace Quanlycf
{
    public partial class fStaff : Form
    {
        static DataTable tblCL;
        int ID_order=-1;
        public DateTime startTime;
        public DateTime endTime;
        public fStaff()
        {
            InitializeComponent();
            Class.Function.Connect();
            LoadOrder();
            LoadCategory();
            startTime = DateTime.Now;
            endTime = startTime;
            Class.Function.Disconnect();
        }
        #region Method

        void LoadOrder()
        {
            

           string sql = "SELECT * FROM dbo.tblOrders" + "\n"+
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

            dvgOrder.Columns["statusOrder"].Visible=false;


            
           



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
            string sql_complete= "UPDATE dbo.tblOrders \n SET statusOrder = 1 \n WHERE id = " + id.ToString() + ";";
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

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            comboBox1_ChooseCategory.DataSource = listCategory;
            comboBox1_ChooseCategory.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Product> listFood = ProductDAO.Instance.GetFoodByCategoryID(id);
            ComboBox_MonAn.DataSource = listFood;
            ComboBox_MonAn.DisplayMember = "Name";
        }
        void ShowBill()
        {
            lsvBill.Items.Clear();
            List<Quanlycf.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable();
            float totalPrice = 0;
            foreach (Quanlycf.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            //Thread.CurrentThread.CurrentCulture = culture;

            txbTotalPrice.Text = totalPrice.ToString("c", culture);
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
                int ID = (int)grid[1,e.RowIndex].Value;
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
           // this.tblOrdersTableAdapter.Fill(this.managerCoffeeDataSet.tblOrders);

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e) // Them mon
        {
            // int idBill = OrderDAO.Instance.GetUncheckBillIDByTableID(0);
            int foodID = (ComboBox_MonAn.SelectedItem as Product).ID;
            int count = (int)SL_monAn_upDown.Value;
            OrderDAO.Instance.InsertBill();
            OrderDetailDAO.Instance.InsertBillInfo(1, foodID, count);
            ShowBill();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { // Chọn loai mon an 

            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListByCategoryID(id);

        }

        private void buttonThanhtoan_Click(object sender, EventArgs e)
        {
            //Table table = lsvBill.Tag as Table;

          int idBill = 1;


            double totalPrice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0]);


            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\nTổng tiền - (Tổng tiền / 100) x Giảm giá\n=> {1} - ({1} / 100) x {2} = {3}", "test Table.name", totalPrice, 0, totalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    OrderDAO.Instance.CheckOut(idBill, 0, (float)totalPrice);
                    ShowBill();

                    // LoadTable();
                }
            }
        }
    }

}
