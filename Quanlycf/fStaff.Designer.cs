
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dvgOrderDetail = new System.Windows.Forms.DataGridView();
            this.dvgOrder = new System.Windows.Forms.DataGridView();
            this.tblOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.managerCoffeeDataSet = new Quanlycf.ManagerCoffeeDataSet();
            this.tblOrdersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblOrdersTableAdapter = new Quanlycf.ManagerCoffeeDataSetTableAdapters.tblOrdersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalmoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerCoffeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // buttonThanhtoan
            // 
            this.buttonThanhtoan.Location = new System.Drawing.Point(205, 3);
            this.buttonThanhtoan.Name = "buttonThanhtoan";
            this.buttonThanhtoan.Size = new System.Drawing.Size(75, 44);
            this.buttonThanhtoan.TabIndex = 0;
            this.buttonThanhtoan.Text = "Thanh Toán";
            this.buttonThanhtoan.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.buttonThanhtoan);
            this.panel5.Location = new System.Drawing.Point(491, 344);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(289, 50);
            this.panel5.TabIndex = 2;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(70, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Sô lượng";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(70, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Món ăn";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(79, 31);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm món";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Controls.Add(this.textBox3);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Controls.Add(this.numericUpDown1);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.comboBox1);
            this.panel6.Location = new System.Drawing.Point(491, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(289, 65);
            this.panel6.TabIndex = 3;
            // 
            // dvgOrderDetail
            // 
            this.dvgOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgOrderDetail.Location = new System.Drawing.Point(491, 74);
            this.dvgOrderDetail.Name = "dvgOrderDetail";
            this.dvgOrderDetail.Size = new System.Drawing.Size(289, 267);
            this.dvgOrderDetail.TabIndex = 4;
            this.dvgOrderDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // dvgOrder
            // 
            this.dvgOrder.AutoGenerateColumns = false;
            this.dvgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idnvDataGridViewTextBoxColumn,
            this.totalmoneyDataGridViewTextBoxColumn,
            this.statusOrderDataGridViewTextBoxColumn,
            this.ngaybanDataGridViewTextBoxColumn,
            this.detail});
            this.dvgOrder.DataSource = this.tblOrdersBindingSource1;
            this.dvgOrder.Location = new System.Drawing.Point(3, 3);
            this.dvgOrder.Name = "dvgOrder";
            this.dvgOrder.Size = new System.Drawing.Size(411, 391);
            this.dvgOrder.TabIndex = 0;
            this.dvgOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgOrder_CellContentClick);
            // 
            // tblOrdersBindingSource
            // 
            this.tblOrdersBindingSource.DataMember = "tblOrders";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dvgOrderDetail);
            this.panel1.Controls.Add(this.dvgOrder);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 418);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 445);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 5);
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
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 445);
            this.panel3.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 1;
            // 
            // managerCoffeeDataSet
            // 
            this.managerCoffeeDataSet.DataSetName = "ManagerCoffeeDataSet";
            this.managerCoffeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOrdersBindingSource1
            // 
            this.tblOrdersBindingSource1.DataMember = "tblOrders";
            this.tblOrdersBindingSource1.DataSource = this.managerCoffeeDataSet;
            // 
            // tblOrdersTableAdapter
            // 
            this.tblOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // idnvDataGridViewTextBoxColumn
            // 
            this.idnvDataGridViewTextBoxColumn.DataPropertyName = "id_nv";
            this.idnvDataGridViewTextBoxColumn.HeaderText = "MSNV";
            this.idnvDataGridViewTextBoxColumn.Name = "idnvDataGridViewTextBoxColumn";
            this.idnvDataGridViewTextBoxColumn.Width = 40;
            // 
            // totalmoneyDataGridViewTextBoxColumn
            // 
            this.totalmoneyDataGridViewTextBoxColumn.DataPropertyName = "total_money";
            this.totalmoneyDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.totalmoneyDataGridViewTextBoxColumn.Name = "totalmoneyDataGridViewTextBoxColumn";
            // 
            // statusOrderDataGridViewTextBoxColumn
            // 
            this.statusOrderDataGridViewTextBoxColumn.DataPropertyName = "statusOrder";
            this.statusOrderDataGridViewTextBoxColumn.FillWeight = 50F;
            this.statusOrderDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            this.statusOrderDataGridViewTextBoxColumn.Name = "statusOrderDataGridViewTextBoxColumn";
            this.statusOrderDataGridViewTextBoxColumn.Width = 60;
            // 
            // ngaybanDataGridViewTextBoxColumn
            // 
            this.ngaybanDataGridViewTextBoxColumn.DataPropertyName = "ngay_ban";
            this.ngaybanDataGridViewTextBoxColumn.HeaderText = "ngay_ban";
            this.ngaybanDataGridViewTextBoxColumn.Name = "ngaybanDataGridViewTextBoxColumn";
            this.ngaybanDataGridViewTextBoxColumn.Visible = false;
            // 
            // detail
            // 
            this.detail.HeaderText = "";
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            this.detail.Text = "Chi tiết";
            // 
            // fStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Name = "fStaff";
            this.Text = "fStaff";
            this.Load += new System.EventHandler(this.fStaff_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerCoffeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.BindingSource tblOrdersBindingSource;
        private System.Windows.Forms.DataGridView dvgOrderDetail;
        private System.Windows.Forms.DataGridView dvgOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private ManagerCoffeeDataSet managerCoffeeDataSet;
        private System.Windows.Forms.BindingSource tblOrdersBindingSource1;
        private ManagerCoffeeDataSetTableAdapters.tblOrdersTableAdapter tblOrdersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalmoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn detail;
    }
}