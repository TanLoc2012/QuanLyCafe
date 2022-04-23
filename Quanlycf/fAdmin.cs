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
using Quanlycf.DAO;

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
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblUser";
            DataTable tblCL = DAO.Function.GetDataToTable(sql);
            dvgUser.DataSource = tblCL; //Nguồn dữ liệu            
            dvgUser.Columns[0].Width = 100;
            dvgUser.Columns[1].Width = 300;
            dvgUser.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dvgUser.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
    }
}
