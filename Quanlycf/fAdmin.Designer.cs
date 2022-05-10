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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dvgUser = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteNV = new System.Windows.Forms.Button();
            this.editNV = new System.Windows.Forms.Button();
            this.addNV = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dvgUser)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(6, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1212, 576);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dvgUser);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(1204, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý nhân viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dvgUser
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dvgUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dvgUser.BackgroundColor = System.Drawing.Color.White;
            this.dvgUser.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dvgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUser.Location = new System.Drawing.Point(0, 0);
            this.dvgUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dvgUser.Name = "dvgUser";
            this.dvgUser.RowHeadersWidth = 51;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.dvgUser.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dvgUser.Size = new System.Drawing.Size(1034, 550);
            this.dvgUser.TabIndex = 0;
            this.dvgUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.updateButton);
            this.panel3.Controls.Add(this.deleteNV);
            this.panel3.Controls.Add(this.editNV);
            this.panel3.Controls.Add(this.addNV);
            this.panel3.Location = new System.Drawing.Point(1030, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 260);
            this.panel3.TabIndex = 3;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Tomato;
            this.updateButton.Location = new System.Drawing.Point(10, 128);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(91, 50);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Cập nhật";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteNV
            // 
            this.deleteNV.BackColor = System.Drawing.Color.Tomato;
            this.deleteNV.Location = new System.Drawing.Point(10, 191);
            this.deleteNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteNV.Name = "deleteNV";
            this.deleteNV.Size = new System.Drawing.Size(93, 50);
            this.deleteNV.TabIndex = 2;
            this.deleteNV.Text = "Xóa nhân viên";
            this.deleteNV.UseVisualStyleBackColor = false;
            this.deleteNV.Click += new System.EventHandler(this.deleteNV_Click);
            // 
            // editNV
            // 
            this.editNV.BackColor = System.Drawing.Color.Tomato;
            this.editNV.Location = new System.Drawing.Point(10, 67);
            this.editNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editNV.Name = "editNV";
            this.editNV.Size = new System.Drawing.Size(91, 50);
            this.editNV.TabIndex = 1;
            this.editNV.Text = "Chỉnh sửa thông tin";
            this.editNV.UseVisualStyleBackColor = false;
            this.editNV.Click += new System.EventHandler(this.editNV_Click);
            // 
            // addNV
            // 
            this.addNV.BackColor = System.Drawing.Color.Tomato;
            this.addNV.Location = new System.Drawing.Point(10, 2);
            this.addNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addNV.Name = "addNV";
            this.addNV.Size = new System.Drawing.Size(93, 50);
            this.addNV.TabIndex = 0;
            this.addNV.Text = "Thêm nhân viên";
            this.addNV.UseVisualStyleBackColor = false;
            this.addNV.Click += new System.EventHandler(this.addNV_Click_1);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(1204, 543);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý hóa đơn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(990, 97);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 59);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Statistic
            // 
            this.Statistic.ForeColor = System.Drawing.Color.Black;
            this.Statistic.Location = new System.Drawing.Point(842, 97);
            this.Statistic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Statistic.Name = "Statistic";
            this.Statistic.Size = new System.Drawing.Size(135, 59);
            this.Statistic.TabIndex = 12;
            this.Statistic.Text = "Biểu đồ";
            this.Statistic.UseVisualStyleBackColor = true;
            this.Statistic.Click += new System.EventHandler(this.Statistic_Click_1);
            // 
            // Filter
            // 
            this.Filter.ForeColor = System.Drawing.Color.Black;
            this.Filter.Location = new System.Drawing.Point(990, 22);
            this.Filter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(143, 59);
            this.Filter.TabIndex = 11;
            this.Filter.Text = "Lọc theo thời gian";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click_1);
            // 
            // ViewOrderButton
            // 
            this.ViewOrderButton.ForeColor = System.Drawing.Color.Black;
            this.ViewOrderButton.Location = new System.Drawing.Point(842, 22);
            this.ViewOrderButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewOrderButton.Name = "ViewOrderButton";
            this.ViewOrderButton.Size = new System.Drawing.Size(135, 59);
            this.ViewOrderButton.TabIndex = 10;
            this.ViewOrderButton.Text = "Xem đơn hàng";
            this.ViewOrderButton.UseVisualStyleBackColor = true;
            this.ViewOrderButton.Click += new System.EventHandler(this.ViewOrderButton_Click_1);
            // 
            // DateDetail
            // 
            this.DateDetail.AutoSize = true;
            this.DateDetail.ForeColor = System.Drawing.Color.Black;
            this.DateDetail.Location = new System.Drawing.Point(146, 499);
            this.DateDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateDetail.Name = "DateDetail";
            this.DateDetail.Size = new System.Drawing.Size(31, 20);
            this.DateDetail.TabIndex = 5;
            this.DateDetail.Text = "Từ:";
            // 
            // TotalMoney
            // 
            this.TotalMoney.Location = new System.Drawing.Point(478, 451);
            this.TotalMoney.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TotalMoney.Name = "TotalMoney";
            this.TotalMoney.Size = new System.Drawing.Size(110, 26);
            this.TotalMoney.TabIndex = 4;
            this.TotalMoney.Text = "None";
            this.TotalMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(190, 451);
            this.Count.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(90, 26);
            this.Count.TabIndex = 3;
            this.Count.Text = "None";
            this.Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(380, 453);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng số tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 453);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số lượng hóa đơn:";
            // 
            // OrderView
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.OrderView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.OrderView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.OrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderView.DefaultCellStyle = dataGridViewCellStyle14;
            this.OrderView.Location = new System.Drawing.Point(3, 2);
            this.OrderView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrderView.Name = "OrderView";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderView.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.OrderView.RowHeadersWidth = 51;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.OrderView.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.OrderView.RowTemplate.Height = 24;
            this.OrderView.Size = new System.Drawing.Size(834, 424);
            this.OrderView.TabIndex = 0;
            this.OrderView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderView_CellContentClick);
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 589);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fAdmin";
            this.Text = "Quản lý";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgUser)).EndInit();
            this.panel3.ResumeLayout(false);
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