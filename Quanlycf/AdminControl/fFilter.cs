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
    public partial class fFilter : Form
    {
        public string sql = "";
        public fFilter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(startTime.Value.Date, endTime.Value.Date) >= 0 || DateTime.Compare(startTime.Value.Date, DateTime.Now) > 0)
            {
                MessageBox.Show("Thời gian phải là khoảng từ quá khứ đến thời điểm hiện tại", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sql = "SELECT [dbo].[tblOrders].id, [dbo].[tblOrders].id_nv, [dbo].[tblUser].fullname, [dbo].[tblOrders].total_money, [dbo].[tblOrders].statusOrder, [dbo].[tblOrders].ngay_ban " +
                "FROM[dbo].[tblOrders], [dbo].[tblUser] " +
    "WHERE[dbo].[tblOrders].id_nv = [dbo].[tblUser].id AND [dbo].[tblOrders].ngay_ban >= '" + startTime.Value.Date.ToString("yyyy/MM/dd") + "' AND [dbo].[tblOrders].ngay_ban <= '" + endTime.Value.Date.ToString("yyyy/MM/dd") + "' ;";
            this.Hide();
        }
    }
}
