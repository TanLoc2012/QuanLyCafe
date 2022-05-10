using Quanlycf.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlycf
{
    public partial class fLogin : Form
    {
        public static string ID;

        public fLogin()
        {
            InitializeComponent();
        }

        string getId()
        {
            return ID;
        }

        public string getID(string username, string pass)
        {
            string id = "";
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = @"Data Source=DESKTOP-KPRJ34J;Initial Catalog=ManagerCoffee;Integrated Security=True";
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[tblUser] WHERE username ='" + username + "' and passwordNV='" + pass + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["id_user"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                conn.Close();
            }
            return id;
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            Class.Function.Connect();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (Login(username, password) == 1)
            {
                ID = getID(username, password);
                fStaff f = new fStaff();
                this.Hide();
                f.ShowDialog();
                Application.Exit();

            }
            else if (Login(username, password) == 2)
            {
                ID = getID(username, password);
                fAdmin f = new fAdmin();
                this.Hide();
                f.ShowDialog();
                Application.Exit();
            }
            else
            {
                ID = "";
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Class.Function.Disconnect();
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
