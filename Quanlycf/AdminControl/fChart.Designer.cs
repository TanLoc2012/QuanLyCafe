namespace Quanlycf
{
    partial class fChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChart));
            this.label2 = new System.Windows.Forms.Label();
            this.ChooseItem = new System.Windows.Forms.ListBox();
            this.Title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CountOrder = new System.Windows.Forms.RadioButton();
            this.TotalMoney = new System.Windows.Forms.RadioButton();
            this.CountOrderChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TotalMoneyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CountOrderChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalMoneyChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lọc theo:";
            // 
            // ChooseItem
            // 
            this.ChooseItem.FormattingEnabled = true;
            this.ChooseItem.Items.AddRange(new object[] {
            "Default",
            "Month",
            "Quarter"});
            this.ChooseItem.Location = new System.Drawing.Point(646, 122);
            this.ChooseItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChooseItem.Name = "ChooseItem";
            this.ChooseItem.Size = new System.Drawing.Size(66, 30);
            this.ChooseItem.TabIndex = 2;
            this.ChooseItem.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(79, 46);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(75, 19);
            this.Title.TabIndex = 3;
            this.Title.Text = "Đúng rồi";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(580, 214);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Vẽ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Draw_Click);
            // 
            // CountOrder
            // 
            this.CountOrder.AutoSize = true;
            this.CountOrder.Location = new System.Drawing.Point(558, 176);
            this.CountOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CountOrder.Name = "CountOrder";
            this.CountOrder.Size = new System.Drawing.Size(72, 17);
            this.CountOrder.TabIndex = 6;
            this.CountOrder.TabStop = true;
            this.CountOrder.Text = "Tổng đơn";
            this.CountOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CountOrder.UseVisualStyleBackColor = true;
            this.CountOrder.CheckedChanged += new System.EventHandler(this.CountOrder_CheckedChanged);
            // 
            // TotalMoney
            // 
            this.TotalMoney.AutoSize = true;
            this.TotalMoney.Location = new System.Drawing.Point(646, 176);
            this.TotalMoney.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TotalMoney.Name = "TotalMoney";
            this.TotalMoney.Size = new System.Drawing.Size(71, 17);
            this.TotalMoney.TabIndex = 7;
            this.TotalMoney.TabStop = true;
            this.TotalMoney.Text = "Doanh số";
            this.TotalMoney.UseVisualStyleBackColor = true;
            this.TotalMoney.CheckedChanged += new System.EventHandler(this.TotalMoney_CheckedChanged);
            // 
            // CountOrderChart
            // 
            this.CountOrderChart.CausesValidation = false;
            chartArea1.Name = "ChartArea1";
            this.CountOrderChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CountOrderChart.Legends.Add(legend1);
            this.CountOrderChart.Location = new System.Drawing.Point(17, 93);
            this.CountOrderChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CountOrderChart.Name = "CountOrderChart";
            this.CountOrderChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Tổng đơn";
            this.CountOrderChart.Series.Add(series1);
            this.CountOrderChart.Size = new System.Drawing.Size(493, 362);
            this.CountOrderChart.TabIndex = 8;
            // 
            // TotalMoneyChart
            // 
            chartArea2.Name = "ChartArea1";
            this.TotalMoneyChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.TotalMoneyChart.Legends.Add(legend2);
            this.TotalMoneyChart.Location = new System.Drawing.Point(17, 93);
            this.TotalMoneyChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TotalMoneyChart.Name = "TotalMoneyChart";
            this.TotalMoneyChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Doanh số";
            this.TotalMoneyChart.Series.Add(series2);
            this.TotalMoneyChart.Size = new System.Drawing.Size(493, 362);
            this.TotalMoneyChart.TabIndex = 9;
            this.TotalMoneyChart.Text = "chart1";
            this.TotalMoneyChart.Click += new System.EventHandler(this.TotalMoneyChart_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(526, 307);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(259, 149);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // fChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 499);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.TotalMoneyChart);
            this.Controls.Add(this.CountOrderChart);
            this.Controls.Add(this.TotalMoney);
            this.Controls.Add(this.CountOrder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ChooseItem);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fChart";
            this.Text = "Biểu đồ";
            ((System.ComponentModel.ISupportInitialize)(this.CountOrderChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalMoneyChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ChooseItem;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton CountOrder;
        private System.Windows.Forms.RadioButton TotalMoney;
        private System.Windows.Forms.DataVisualization.Charting.Chart CountOrderChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart TotalMoneyChart;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}