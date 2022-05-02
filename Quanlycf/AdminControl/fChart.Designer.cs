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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label2.Location = new System.Drawing.Point(739, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lọc theo:";
            // 
            // ChooseItem
            // 
            this.ChooseItem.FormattingEnabled = true;
            this.ChooseItem.ItemHeight = 16;
            this.ChooseItem.Items.AddRange(new object[] {
            "Default",
            "Month",
            "Quarter"});
            this.ChooseItem.Location = new System.Drawing.Point(861, 150);
            this.ChooseItem.Name = "ChooseItem";
            this.ChooseItem.Size = new System.Drawing.Size(87, 36);
            this.ChooseItem.TabIndex = 2;
            this.ChooseItem.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(105, 56);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(91, 24);
            this.Title.TabIndex = 3;
            this.Title.Text = "Đúng rồi";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(774, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 72);
            this.button1.TabIndex = 4;
            this.button1.Text = "Vẽ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Draw_Click);
            // 
            // CountOrder
            // 
            this.CountOrder.AutoSize = true;
            this.CountOrder.Location = new System.Drawing.Point(744, 217);
            this.CountOrder.Name = "CountOrder";
            this.CountOrder.Size = new System.Drawing.Size(86, 20);
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
            this.TotalMoney.Location = new System.Drawing.Point(861, 217);
            this.TotalMoney.Name = "TotalMoney";
            this.TotalMoney.Size = new System.Drawing.Size(86, 20);
            this.TotalMoney.TabIndex = 7;
            this.TotalMoney.TabStop = true;
            this.TotalMoney.Text = "Doanh số";
            this.TotalMoney.UseVisualStyleBackColor = true;
            this.TotalMoney.CheckedChanged += new System.EventHandler(this.TotalMoney_CheckedChanged);
            // 
            // CountOrderChart
            // 
            this.CountOrderChart.CausesValidation = false;
            chartArea7.Name = "ChartArea1";
            this.CountOrderChart.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.CountOrderChart.Legends.Add(legend7);
            this.CountOrderChart.Location = new System.Drawing.Point(23, 115);
            this.CountOrderChart.Name = "CountOrderChart";
            this.CountOrderChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Tổng đơn";
            this.CountOrderChart.Series.Add(series7);
            this.CountOrderChart.Size = new System.Drawing.Size(657, 446);
            this.CountOrderChart.TabIndex = 8;
            // 
            // TotalMoneyChart
            // 
            chartArea8.Name = "ChartArea1";
            this.TotalMoneyChart.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.TotalMoneyChart.Legends.Add(legend8);
            this.TotalMoneyChart.Location = new System.Drawing.Point(23, 115);
            this.TotalMoneyChart.Name = "TotalMoneyChart";
            this.TotalMoneyChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Doanh số";
            this.TotalMoneyChart.Series.Add(series8);
            this.TotalMoneyChart.Size = new System.Drawing.Size(657, 446);
            this.TotalMoneyChart.TabIndex = 9;
            this.TotalMoneyChart.Text = "chart1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(701, 378);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(344, 183);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // fChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 614);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.TotalMoneyChart);
            this.Controls.Add(this.CountOrderChart);
            this.Controls.Add(this.TotalMoney);
            this.Controls.Add(this.CountOrder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ChooseItem);
            this.Controls.Add(this.label2);
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