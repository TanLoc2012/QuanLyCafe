
namespace Quanlycf
{
    partial class fStaff
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
            this.components = new System.ComponentModel.Container();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonThanhtoan = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dvgOrder = new System.Windows.Forms.DataGridView();
            this.tblOrdersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.managerCoffeeDataSet = new Quanlycf.ManagerCoffeeDataSet();
            this.tblOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonComplete = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dvgOrderDetail = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tblOrdersTableAdapter = new Quanlycf.ManagerCoffeeDataSetTableAdapters.tblOrdersTableAdapter();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1_ChooseCategory = new System.Windows.Forms.ComboBox();
            this.ComboBox_MonAn = new System.Windows.Forms.ComboBox();
            this.SL_monAn_upDown = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerCoffeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SL_monAn_upDown)).BeginInit();
            this.SuspendLayout();
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1072, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // buttonThanhtoan
            // 
            this.buttonThanhtoan.Location = new System.Drawing.Point(273, 4);
            this.buttonThanhtoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonThanhtoan.Name = "buttonThanhtoan";
            this.buttonThanhtoan.Size = new System.Drawing.Size(100, 54);
            this.buttonThanhtoan.TabIndex = 0;
            this.buttonThanhtoan.Text = "Thanh Toán";
            this.buttonThanhtoan.UseVisualStyleBackColor = true;
            this.buttonThanhtoan.Click += new System.EventHandler(this.buttonThanhtoan_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.textBox4);
            this.panel5.Controls.Add(this.txbTotalPrice);
            this.panel5.Controls.Add(this.buttonThanhtoan);
            this.panel5.Location = new System.Drawing.Point(655, 423);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(385, 62);
            this.panel5.TabIndex = 2;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(4, 38);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(64, 22);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Tên món";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(4, 6);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(33, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Loại";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm món";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Controls.Add(this.SL_monAn_upDown);
            this.panel6.Controls.Add(this.ComboBox_MonAn);
            this.panel6.Controls.Add(this.comboBox1_ChooseCategory);
            this.panel6.Controls.Add(this.textBox3);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Location = new System.Drawing.Point(629, 4);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(411, 80);
            this.panel6.TabIndex = 3;
            // 
            // dvgOrder
            // 
            this.dvgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgOrder.Location = new System.Drawing.Point(4, 4);
            this.dvgOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvgOrder.Name = "dvgOrder";
            this.dvgOrder.RowHeadersWidth = 51;
            this.dvgOrder.Size = new System.Drawing.Size(548, 229);
            this.dvgOrder.TabIndex = 0;
            this.dvgOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgOrder_CellContentClick);
            // 
            // tblOrdersBindingSource1
            // 
            this.tblOrdersBindingSource1.DataMember = "tblOrders";
            this.tblOrdersBindingSource1.DataSource = this.managerCoffeeDataSet;
            // 
            // managerCoffeeDataSet
            // 
            this.managerCoffeeDataSet.DataSetName = "ManagerCoffeeDataSet";
            this.managerCoffeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOrdersBindingSource
            // 
            this.tblOrdersBindingSource.DataMember = "tblOrders";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvBill);
            this.panel1.Controls.Add(this.buttonComplete);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.dvgOrderDetail);
            this.panel1.Controls.Add(this.dvgOrder);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(16, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 558);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonComplete
            // 
            this.buttonComplete.Location = new System.Drawing.Point(316, 517);
            this.buttonComplete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonComplete.Name = "buttonComplete";
            this.buttonComplete.Size = new System.Drawing.Size(111, 32);
            this.buttonComplete.TabIndex = 7;
            this.buttonComplete.Text = "Hoàn thành";
            this.buttonComplete.UseVisualStyleBackColor = true;
            this.buttonComplete.Click += new System.EventHandler(this.buttonComplete_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(435, 517);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(103, 32);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dvgOrderDetail
            // 
            this.dvgOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgOrderDetail.Location = new System.Drawing.Point(4, 240);
            this.dvgOrderDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvgOrderDetail.Name = "dvgOrderDetail";
            this.dvgOrderDetail.RowHeadersWidth = 51;
            this.dvgOrderDetail.Size = new System.Drawing.Size(548, 270);
            this.dvgOrderDetail.TabIndex = 5;
            this.dvgOrderDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgOrderDetail_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 644);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1072, 0);
            this.dataGridView1.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1072, 644);
            this.panel3.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 1;
            // 
            // tblOrdersTableAdapter
            // 
            this.tblOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Location = new System.Drawing.Point(146, 20);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Size = new System.Drawing.Size(92, 22);
            this.txbTotalPrice.TabIndex = 5;
            this.txbTotalPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(46, 20);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(92, 22);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Tổng cộng";
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(629, 100);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(398, 307);
            this.lsvBill.TabIndex = 8;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 67;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 96;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 160;
            // 
            // comboBox1_ChooseCategory
            // 
            this.comboBox1_ChooseCategory.FormattingEnabled = true;
            this.comboBox1_ChooseCategory.Location = new System.Drawing.Point(75, 8);
            this.comboBox1_ChooseCategory.Name = "comboBox1_ChooseCategory";
            this.comboBox1_ChooseCategory.Size = new System.Drawing.Size(173, 24);
            this.comboBox1_ChooseCategory.TabIndex = 5;
            this.comboBox1_ChooseCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ComboBox_MonAn
            // 
            this.ComboBox_MonAn.FormattingEnabled = true;
            this.ComboBox_MonAn.Location = new System.Drawing.Point(75, 38);
            this.ComboBox_MonAn.Name = "ComboBox_MonAn";
            this.ComboBox_MonAn.Size = new System.Drawing.Size(173, 24);
            this.ComboBox_MonAn.TabIndex = 6;
            // 
            // SL_monAn_upDown
            // 
            this.SL_monAn_upDown.Location = new System.Drawing.Point(359, 47);
            this.SL_monAn_upDown.Name = "SL_monAn_upDown";
            this.SL_monAn_upDown.Size = new System.Drawing.Size(49, 22);
            this.SL_monAn_upDown.TabIndex = 7;
            // 
            // fStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 582);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fStaff";
            this.Text = "fStaff";
            this.Load += new System.EventHandler(this.fStaff_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerCoffeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SL_monAn_upDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.Button buttonThanhtoan;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.BindingSource tblOrdersBindingSource;
        private System.Windows.Forms.DataGridView dvgOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private ManagerCoffeeDataSet managerCoffeeDataSet;
        private System.Windows.Forms.BindingSource tblOrdersBindingSource1;
        private ManagerCoffeeDataSetTableAdapters.tblOrdersTableAdapter tblOrdersTableAdapter;
        private System.Windows.Forms.Button buttonComplete;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dvgOrderDetail;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListView lsvBill;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.NumericUpDown SL_monAn_upDown;
        private System.Windows.Forms.ComboBox ComboBox_MonAn;
        private System.Windows.Forms.ComboBox comboBox1_ChooseCategory;
    }
}
