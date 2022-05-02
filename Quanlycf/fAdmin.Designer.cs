namespace Quanlycf
{
    partial class fAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteNV = new System.Windows.Forms.Button();
            this.editNV = new System.Windows.Forms.Button();
            this.addNV = new System.Windows.Forms.Button();
            this.dvgUser = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Statistic = new System.Windows.Forms.Button();
            this.Filter = new System.Windows.Forms.Button();
            this.ViewOrderButton = new System.Windows.Forms.Button();
            this.DateDetail = new System.Windows.Forms.Label();
            this.TotalMoney = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUser)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(8, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1389, 709);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.dvgUser);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1381, 671);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý nhân viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.updateButton);
            this.panel3.Controls.Add(this.deleteNV);
            this.panel3.Controls.Add(this.editNV);
            this.panel3.Controls.Add(this.addNV);
            this.panel3.Location = new System.Drawing.Point(1195, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(177, 320);
            this.panel3.TabIndex = 3;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Tomato;
            this.updateButton.Location = new System.Drawing.Point(13, 158);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(141, 61);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Cập nhật";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteNV
            // 
            this.deleteNV.BackColor = System.Drawing.Color.Tomato;
            this.deleteNV.Location = new System.Drawing.Point(13, 235);
            this.deleteNV.Name = "deleteNV";
            this.deleteNV.Size = new System.Drawing.Size(141, 61);
            this.deleteNV.TabIndex = 2;
            this.deleteNV.Text = "Xóa nhân viên";
            this.deleteNV.UseVisualStyleBackColor = false;
            this.deleteNV.Click += new System.EventHandler(this.deleteNV_Click);
            // 
            // editNV
            // 
            this.editNV.BackColor = System.Drawing.Color.Tomato;
            this.editNV.Location = new System.Drawing.Point(13, 82);
            this.editNV.Name = "editNV";
            this.editNV.Size = new System.Drawing.Size(141, 61);
            this.editNV.TabIndex = 1;
            this.editNV.Text = "Chỉnh sửa thông tin";
            this.editNV.UseVisualStyleBackColor = false;
            this.editNV.Click += new System.EventHandler(this.editNV_Click);
            // 
            // addNV
            // 
            this.addNV.BackColor = System.Drawing.Color.Tomato;
            this.addNV.Location = new System.Drawing.Point(13, 3);
            this.addNV.Name = "addNV";
            this.addNV.Size = new System.Drawing.Size(141, 61);
            this.addNV.TabIndex = 0;
            this.addNV.Text = "Thêm nhân viên";
            this.addNV.UseVisualStyleBackColor = false;
            this.addNV.Click += new System.EventHandler(this.addNV_Click_1);
            // 
            // dvgUser
            // 
            this.dvgUser.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUser.Location = new System.Drawing.Point(0, 0);
            this.dvgUser.Name = "dvgUser";
            this.dvgUser.RowHeadersWidth = 51;
            this.dvgUser.Size = new System.Drawing.Size(1189, 677);
            this.dvgUser.TabIndex = 0;
            this.dvgUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1381, 671);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quản lý menu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.Statistic);
            this.tabPage2.Controls.Add(this.Filter);
            this.tabPage2.Controls.Add(this.ViewOrderButton);
            this.tabPage2.Controls.Add(this.DateDetail);
            this.tabPage2.Controls.Add(this.TotalMoney);
            this.tabPage2.Controls.Add(this.Count);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.OrderView);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(1381, 671);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý hóa đơn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1158, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 73);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Statistic
            // 
            this.Statistic.ForeColor = System.Drawing.Color.Black;
            this.Statistic.Location = new System.Drawing.Point(972, 119);
            this.Statistic.Name = "Statistic";
            this.Statistic.Size = new System.Drawing.Size(180, 73);
            this.Statistic.TabIndex = 12;
            this.Statistic.Text = "Biểu đồ";
            this.Statistic.UseVisualStyleBackColor = true;
            this.Statistic.Click += new System.EventHandler(this.Statistic_Click_1);
            // 
            // Filter
            // 
            this.Filter.ForeColor = System.Drawing.Color.Black;
            this.Filter.Location = new System.Drawing.Point(1158, 27);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(180, 73);
            this.Filter.TabIndex = 11;
            this.Filter.Text = "Lọc theo thời gian";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click_1);
            // 
            // ViewOrderButton
            // 
            this.ViewOrderButton.ForeColor = System.Drawing.Color.Black;
            this.ViewOrderButton.Location = new System.Drawing.Point(972, 27);
            this.ViewOrderButton.Name = "ViewOrderButton";
            this.ViewOrderButton.Size = new System.Drawing.Size(180, 73);
            this.ViewOrderButton.TabIndex = 10;
            this.ViewOrderButton.Text = "Xem đơn hàng";
            this.ViewOrderButton.UseVisualStyleBackColor = true;
            this.ViewOrderButton.Click += new System.EventHandler(this.ViewOrderButton_Click_1);
            // 
            // DateDetail
            // 
            this.DateDetail.AutoSize = true;
            this.DateDetail.ForeColor = System.Drawing.Color.Black;
            this.DateDetail.Location = new System.Drawing.Point(194, 614);
            this.DateDetail.Name = "DateDetail";
            this.DateDetail.Size = new System.Drawing.Size(42, 25);
            this.DateDetail.TabIndex = 5;
            this.DateDetail.Text = "Từ:";
            // 
            // TotalMoney
            // 
            this.TotalMoney.Location = new System.Drawing.Point(638, 555);
            this.TotalMoney.Name = "TotalMoney";
            this.TotalMoney.Size = new System.Drawing.Size(104, 30);
            this.TotalMoney.TabIndex = 4;
            this.TotalMoney.Text = "None";
            this.TotalMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(254, 555);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(104, 30);
            this.Count.TabIndex = 3;
            this.Count.Text = "None";
            this.Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(506, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng số tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(53, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số lượng hóa đơn:";
            // 
            // OrderView
            // 
            this.OrderView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderView.Location = new System.Drawing.Point(4, 3);
            this.OrderView.Name = "OrderView";
            this.OrderView.RowHeadersWidth = 51;
            this.OrderView.RowTemplate.Height = 24;
            this.OrderView.Size = new System.Drawing.Size(962, 522);
            this.OrderView.TabIndex = 0;
            this.OrderView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderView_CellContentClick);
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 725);
            this.Controls.Add(this.tabControl1);
            this.Name = "fAdmin";
            this.Text = "Quản lý";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgUser)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dvgUser;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Statistic;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Button ViewOrderButton;
        private System.Windows.Forms.Label DateDetail;
        private System.Windows.Forms.TextBox TotalMoney;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView OrderView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteNV;
        private System.Windows.Forms.Button editNV;
        private System.Windows.Forms.Button addNV;
    }
}