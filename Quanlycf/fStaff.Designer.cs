
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buttonThanhtoan = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numerSoLuong = new System.Windows.Forms.NumericUpDown();
            this.button_addProduct = new System.Windows.Forms.Button();
            this.combo_MonAn = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dvgAddProduct = new System.Windows.Forms.DataGridView();
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
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numerSoLuong)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAddProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerCoffeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buttonThanhtoan
            // 
            this.buttonThanhtoan.Location = new System.Drawing.Point(205, 3);
            this.buttonThanhtoan.Name = "buttonThanhtoan";
            this.buttonThanhtoan.Size = new System.Drawing.Size(75, 44);
            this.buttonThanhtoan.TabIndex = 0;
            this.buttonThanhtoan.Text = "Thanh Toán";
            this.buttonThanhtoan.UseVisualStyleBackColor = true;
            this.buttonThanhtoan.Click += new System.EventHandler(this.buttonThanhtoan_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.buttonThanhtoan);
            this.panel5.Location = new System.Drawing.Point(420, 344);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(360, 50);
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
            this.textBox2.Location = new System.Drawing.Point(0, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Món ăn";
            // 
            // numerSoLuong
            // 
            this.numerSoLuong.Location = new System.Drawing.Point(79, 31);
            this.numerSoLuong.Name = "numerSoLuong";
            this.numerSoLuong.Size = new System.Drawing.Size(120, 20);
            this.numerSoLuong.TabIndex = 2;
            this.numerSoLuong.ValueChanged += new System.EventHandler(this.numerSoLuong_ValueChanged);
            // 
            // button_addProduct
            // 
            this.button_addProduct.Location = new System.Drawing.Point(205, 5);
            this.button_addProduct.Name = "button_addProduct";
            this.button_addProduct.Size = new System.Drawing.Size(75, 56);
            this.button_addProduct.TabIndex = 1;
            this.button_addProduct.Text = "Thêm món";
            this.button_addProduct.UseVisualStyleBackColor = true;
            this.button_addProduct.Click += new System.EventHandler(this.button_addProduct_Click);
            // 
            // combo_MonAn
            // 
            this.combo_MonAn.FormattingEnabled = true;
            this.combo_MonAn.Location = new System.Drawing.Point(79, 4);
            this.combo_MonAn.Name = "combo_MonAn";
            this.combo_MonAn.Size = new System.Drawing.Size(120, 21);
            this.combo_MonAn.TabIndex = 0;
            this.combo_MonAn.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Controls.Add(this.textBox3);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Controls.Add(this.numerSoLuong);
            this.panel6.Controls.Add(this.button_addProduct);
            this.panel6.Controls.Add(this.combo_MonAn);
            this.panel6.Location = new System.Drawing.Point(420, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(360, 65);
            this.panel6.TabIndex = 3;
            // 
            // dvgAddProduct
            // 
            this.dvgAddProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAddProduct.Location = new System.Drawing.Point(420, 70);
            this.dvgAddProduct.Name = "dvgAddProduct";
            this.dvgAddProduct.RowHeadersWidth = 51;
            this.dvgAddProduct.Size = new System.Drawing.Size(360, 267);
            this.dvgAddProduct.TabIndex = 4;
            this.dvgAddProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgAddProduct_CellContentClick);
            // 
            // dvgOrder
            // 
            this.dvgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgOrder.Location = new System.Drawing.Point(3, 3);
            this.dvgOrder.Name = "dvgOrder";
            this.dvgOrder.RowHeadersWidth = 51;
            this.dvgOrder.Size = new System.Drawing.Size(411, 186);
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
            this.panel1.Controls.Add(this.buttonComplete);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.dvgOrderDetail);
            this.panel1.Controls.Add(this.dvgAddProduct);
            this.panel1.Controls.Add(this.dvgOrder);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 418);
            this.panel1.TabIndex = 4;
            // 
            // buttonComplete
            // 
            this.buttonComplete.Location = new System.Drawing.Point(225, 383);
            this.buttonComplete.Name = "buttonComplete";
            this.buttonComplete.Size = new System.Drawing.Size(75, 23);
            this.buttonComplete.TabIndex = 7;
            this.buttonComplete.Text = "Hoàn thành";
            this.buttonComplete.UseVisualStyleBackColor = true;
            this.buttonComplete.Click += new System.EventHandler(this.buttonComplete_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(323, 383);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 21);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dvgOrderDetail
            // 
            this.dvgOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgOrderDetail.Location = new System.Drawing.Point(3, 195);
            this.dvgOrderDetail.Name = "dvgOrderDetail";
            this.dvgOrderDetail.RowHeadersWidth = 51;
            this.dvgOrderDetail.Size = new System.Drawing.Size(411, 182);
            this.dvgOrderDetail.TabIndex = 5;
            this.dvgOrderDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgOrderDetail_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 445);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
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
            // tblOrdersTableAdapter
            // 
            this.tblOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // fStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Name = "fStaff";
            this.Text = "Phần mềm quản lý Cafe";
            this.Load += new System.EventHandler(this.fStaff_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numerSoLuong)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAddProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerCoffeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button buttonThanhtoan;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numerSoLuong;
        private System.Windows.Forms.Button button_addProduct;
        private System.Windows.Forms.ComboBox combo_MonAn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.BindingSource tblOrdersBindingSource;
        private System.Windows.Forms.DataGridView dvgAddProduct;
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}