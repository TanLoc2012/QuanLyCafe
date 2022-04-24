using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Sử dụng thư viện để làm việc SQL server

namespace Quanlycf
{
    
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet1.tblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter1.Fill(this.masterDataSet1.tblUser);
            // TODO: This line of code loads data into the 'masterDataSet.tblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.masterDataSet.tblUser);
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            Class.Function.Connect();
            string sql;
            sql = "SELECT * FROM tblUser";
            DataTable tblCL = Class.Function.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            
            dvgUser.DataSource = tblCL; //Nguồn dữ liệu            
            //dvgUser.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);


            dvgUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //dvgUser.AllowUserToOrderColumns = true;
            //dvgUser.AllowUserToResizeColumns = true;
            // dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
            dvgUser.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dvgUser.EditMode = DataGridViewEditMode.EditProgrammatically;
            dvgUser.AllowUserToResizeColumns = true;
            Class.Function.Disconnect();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dvgUser.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void addNV_Click(object sender, EventArgs e)
        {
            fAddNV temp = new fAddNV();

            temp.ShowDialog();
        }

        private void editNV_Click(object sender, EventArgs e)
        {
            fEditNV temp = new fEditNV();
            temp.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dvgUser.Update();
            MessageBox.Show("Cập nhật thành công", "Update", MessageBoxButtons.OK);
            dvgUser.DataSource = null;
            LoadDataGridView();
        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void deleteNV_Click(object sender, EventArgs e)
        {
            deleteNV temp = new deleteNV();
            temp.ShowDialog();

        }
    }
}
