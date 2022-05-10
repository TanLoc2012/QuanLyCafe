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
    public partial class fChart : Form
    {
        private DateTime start;
        private DateTime end;
        private string selected = "";
        public fChart(DateTime startTime, DateTime endTime)
        {
            InitializeComponent();
            start = startTime;
            end = endTime;
            ChooseItem.SelectedItem = "Default";
            Title.Text = "Thống kê hoạt động: " + start.Date.ToString("dd/MM/yyyy") + " - " + end.Date.ToString("dd/MM/yyyy");
            Title.Visible = true;
            if (DateTime.Compare(start, end) >= 0 || DateTime.Compare(start, DateTime.Now) >= 0)
            {
                MessageBox.Show("Để sử dụng biểu đồ, hãy chọn thời gian hợp lệ!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else
            {
                string sql = " SELECT [dbo].[tblOrders].ngay_ban AS date, COUNT([dbo].[tblOrders].ngay_ban) AS tong_don, SUM([dbo].[tblOrders].total_money) AS tong_tien"
                           + " FROM[dbo].[tblOrders]"
                           + " WHERE[dbo].[tblOrders].ngay_ban >= '" + start.Date.ToString("yyyy/MM/dd") + "' AND[dbo].[tblOrders].ngay_ban <= '" + endTime.ToString("yyyy/MM/dd") + "'"
                           + " GROUP BY[dbo].[tblOrders].ngay_ban;";
                updateChart(sql);
            }

        }
        void updateChart(string sql, bool context = false)
        {
            CountOrder.Checked = true;
            TotalMoney.Checked = false;
            CountOrderChart.Visible = true;
            TotalMoneyChart.Visible = false;
            Class.Function.Connect();
            DataTable tblc = Class.Function.GetDataToTable(sql);



            //DataTable tbll = tblc.Clone();
            CountOrderChart.DataSource = tblc;
            TotalMoneyChart.DataSource = tblc;
            if (context)
            {
                //tbll.Columns[0].DataType = 
                CountOrderChart.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                TotalMoneyChart.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            }
            else
            {
                CountOrderChart.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
                TotalMoneyChart.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            }
            
            CountOrderChart.Series[0].XValueMember = "date";
            CountOrderChart.Series[0].YValueMembers = "tong_don";
            CountOrderChart.Series[0].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            

            TotalMoneyChart.Series[0].XValueMember = "date";
            TotalMoneyChart.Series[0].YValueMembers = "tong_tien";
            TotalMoneyChart.Series[0].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            

            Title.Text = "Thống kê hoạt động: " + start.Date.ToString("dd/MM/yyyy") + " - " + end.Date.ToString("dd/MM/yyyy");

            CountOrderChart.Visible = true;
            TotalMoneyChart.Visible = false;
            Class.Function.Disconnect();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = ChooseItem.SelectedItem.ToString();

        }

        private void Draw_Click(object sender, EventArgs e)
        {
            selected = ChooseItem.SelectedItem.ToString();

            switch (selected)
            {
                case "Mặc định":
                    MessageBox.Show("Biểu đồ đang hiển thị chế độ mặc định. Nếu thời gian không hợp lệ biểu đồ sẽ không hiển thị. Vui lòng kiểm tra lại", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "Month":
                    // Biểu đồ được chia thành các tháng trong năm

                    start = new DateTime(start.Year, 1, 1);
                    end = start.AddYears(1);
                    end = end.AddDays(-1);
                    string sql = "SELECT DATENAME(month, [dbo].[tblOrders].ngay_ban) AS date, COUNT(*) AS tong_don, SUM([dbo].[tblOrders].total_money) AS tong_tien "
                               + "FROM [dbo].[tblOrders]"
                               + "WHERE [dbo].[tblOrders].ngay_ban >= '" + start.Date.ToString("yyyy/MM/dd") + "' AND[dbo].[tblOrders].ngay_ban <= '" + end.ToString("yyyy/MM/dd") + "'"
                               + "GROUP BY DATENAME(month, [dbo].[tblOrders].ngay_ban);";
                    updateChart(sql, true);
                    MessageBox.Show("Cập nhật thành công", "message", MessageBoxButtons.OK);
                    Title.Text = "Thống kê hoạt động theo tháng từ " + start.Date.ToString("dd/MM/yyyy") + " - " + end.Date.ToString("dd/MM/yyyy");
                    break;
                case "Quarter":
                    start = new DateTime(start.Year, 1, 1);
                    end = start.AddYears(1);
                    end = end.AddDays(-1);
                    sql = "SELECT CONVERT(varchar(1), DATEPART(QUARTER, [dbo].[tblOrders].ngay_ban)) AS date, COUNT(*) AS tong_don, SUM([dbo].[tblOrders].total_money) AS tong_tien "
                        + "FROM [dbo].[tblOrders] "
                        + "WHERE [dbo].[tblOrders].ngay_ban >= '" + start.Date.ToString("yyyy/MM/dd") + "' AND[dbo].[tblOrders].ngay_ban <= '" + end.ToString("yyyy/MM/dd") + "'"
                        + "GROUP BY CONVERT(varchar(1), DATEPART(QUARTER, [dbo].[tblOrders].ngay_ban));";


                    updateChart(sql, true);
                    MessageBox.Show("Cập nhật thành công", "message", MessageBoxButtons.OK);
                    Title.Text = "Thống kê hoạt động theo quý từ " + start.Date.ToString("dd/MM/yyyy") + " - " + end.Date.ToString("dd/MM/yyyy");
                    break;
            }
        }

        private void TotalMoney_CheckedChanged(object sender, EventArgs e)
        {
            CountOrderChart.Visible = false;
            TotalMoneyChart.Visible = true;
        }

        private void CountOrder_CheckedChanged(object sender, EventArgs e)
        {
            TotalMoneyChart.Visible = false;
            CountOrderChart.Visible = true;
        }

        private void TotalMoneyChart_Click(object sender, EventArgs e)
        {

        }
    }
}
