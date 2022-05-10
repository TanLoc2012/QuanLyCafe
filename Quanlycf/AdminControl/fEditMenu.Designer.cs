namespace Quanlycf
{
    partial class fEditMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.notifyID = new System.Windows.Forms.Label();
            this.checkID = new System.Windows.Forms.Button();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.changeThumbnail = new System.Windows.Forms.CheckBox();
            this.changeDiscount = new System.Windows.Forms.CheckBox();
            this.changeDescription = new System.Windows.Forms.CheckBox();
            this.changePrice = new System.Windows.Forms.CheckBox();
            this.changeTitle = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.thumbnailBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.discountBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputTitleMenu = new System.Windows.Forms.TextBox();
            this.tblProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerCoffeeDataSet3 = new Quanlycf.ManagerCoffeeDataSet3();
            this.tblProductTableAdapter = new Quanlycf.ManagerCoffeeDataSet3TableAdapters.tblProductTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerCoffeeDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.notifyID);
            this.panel1.Controls.Add(this.checkID);
            this.panel1.Controls.Add(this.IDbox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.changeThumbnail);
            this.panel1.Controls.Add(this.changeDiscount);
            this.panel1.Controls.Add(this.changeDescription);
            this.panel1.Controls.Add(this.changePrice);
            this.panel1.Controls.Add(this.changeTitle);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.thumbnailBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.discountBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.descriptionBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.priceBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inputTitleMenu);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 633);
            this.panel1.TabIndex = 3;
            this.panel1.TabStop = true;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // notifyID
            // 
            this.notifyID.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.notifyID.AutoSize = true;
            this.notifyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifyID.Location = new System.Drawing.Point(253, 196);
            this.notifyID.Name = "notifyID";
            this.notifyID.Size = new System.Drawing.Size(479, 18);
            this.notifyID.TabIndex = 32;
            this.notifyID.Text = "Vui lòng nhập chính xác ID thực đơn (không có khoảng trắng bất kỳ nào)";
            this.notifyID.Click += new System.EventHandler(this.notifyID_Click);
            // 
            // checkID
            // 
            this.checkID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkID.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkID.Location = new System.Drawing.Point(752, 145);
            this.checkID.Name = "checkID";
            this.checkID.Size = new System.Drawing.Size(55, 31);
            this.checkID.TabIndex = 31;
            this.checkID.Text = "Tìm";
            this.checkID.UseVisualStyleBackColor = false;
            this.checkID.Click += new System.EventHandler(this.checkID_Click);
            // 
            // IDbox
            // 
            this.IDbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDbox.Location = new System.Drawing.Point(267, 139);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(479, 41);
            this.IDbox.TabIndex = 30;
            this.IDbox.TextChanged += new System.EventHandler(this.IDbox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(198, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 27);
            this.label10.TabIndex = 29;
            this.label10.Text = "ID:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(267, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(448, 99);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = "1) Nhập ID thực đơn muốn chỉnh sửa\n2) Tại những vị trí cần thay đổi, tick vào \'th" +
    "ay đổi\'\n3) Thay đổi giá trị tại vị trí đó\n4) Để lưu thay đổi, nhấn ô màu hồng \"L" +
    "ưu thay đổi\"";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // changeThumbnail
            // 
            this.changeThumbnail.AutoSize = true;
            this.changeThumbnail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeThumbnail.Location = new System.Drawing.Point(752, 327);
            this.changeThumbnail.Name = "changeThumbnail";
            this.changeThumbnail.Size = new System.Drawing.Size(81, 22);
            this.changeThumbnail.TabIndex = 25;
            this.changeThumbnail.Text = "thay đổi";
            this.changeThumbnail.UseVisualStyleBackColor = true;
            this.changeThumbnail.CheckedChanged += new System.EventHandler(this.changeThumbnail_CheckedChanged);
            // 
            // changeDiscount
            // 
            this.changeDiscount.AutoSize = true;
            this.changeDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDiscount.Location = new System.Drawing.Point(754, 540);
            this.changeDiscount.Name = "changeDiscount";
            this.changeDiscount.Size = new System.Drawing.Size(81, 22);
            this.changeDiscount.TabIndex = 24;
            this.changeDiscount.Text = "thay đổi";
            this.changeDiscount.UseVisualStyleBackColor = true;
            this.changeDiscount.CheckedChanged += new System.EventHandler(this.changeDiscount_CheckedChanged);
            // 
            // changeDescription
            // 
            this.changeDescription.AutoSize = true;
            this.changeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDescription.Location = new System.Drawing.Point(754, 466);
            this.changeDescription.Name = "changeDescription";
            this.changeDescription.Size = new System.Drawing.Size(81, 22);
            this.changeDescription.TabIndex = 23;
            this.changeDescription.Text = "thay đổi";
            this.changeDescription.UseVisualStyleBackColor = true;
            this.changeDescription.CheckedChanged += new System.EventHandler(this.changeDescription_CheckedChanged);
            // 
            // changePrice
            // 
            this.changePrice.AutoSize = true;
            this.changePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePrice.Location = new System.Drawing.Point(754, 398);
            this.changePrice.Name = "changePrice";
            this.changePrice.Size = new System.Drawing.Size(81, 22);
            this.changePrice.TabIndex = 22;
            this.changePrice.Text = "thay đổi";
            this.changePrice.UseVisualStyleBackColor = true;
            this.changePrice.CheckedChanged += new System.EventHandler(this.changePrice_CheckedChanged);
            // 
            // changeTitle
            // 
            this.changeTitle.AutoSize = true;
            this.changeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeTitle.Location = new System.Drawing.Point(752, 253);
            this.changeTitle.Name = "changeTitle";
            this.changeTitle.Size = new System.Drawing.Size(81, 22);
            this.changeTitle.TabIndex = 20;
            this.changeTitle.Text = "thay đổi";
            this.changeTitle.UseVisualStyleBackColor = true;
            this.changeTitle.CheckedChanged += new System.EventHandler(this.changeTitle_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(813, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 77);
            this.button1.TabIndex = 17;
            this.button1.Text = "Lưu thay đổi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // thumbnailBox
            // 
            this.thumbnailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thumbnailBox.Location = new System.Drawing.Point(267, 311);
            this.thumbnailBox.Name = "thumbnailBox";
            this.thumbnailBox.Size = new System.Drawing.Size(481, 41);
            this.thumbnailBox.TabIndex = 13;
            this.thumbnailBox.UseSystemPasswordChar = true;
            this.thumbnailBox.TextChanged += new System.EventHandler(this.thumbnailBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 592);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 27);
            this.label7.TabIndex = 14;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // discountBox
            // 
            this.discountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountBox.Location = new System.Drawing.Point(267, 525);
            this.discountBox.Name = "discountBox";
            this.discountBox.Size = new System.Drawing.Size(481, 41);
            this.discountBox.TabIndex = 13;
            this.discountBox.TextChanged += new System.EventHandler(this.discountBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Giảm giá:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(267, 382);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(481, 41);
            this.descriptionBox.TabIndex = 11;
            this.descriptionBox.TextChanged += new System.EventHandler(this.descriptionBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(181, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giá:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.Location = new System.Drawing.Point(267, 451);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(481, 41);
            this.priceBox.TabIndex = 13;
            this.priceBox.TextChanged += new System.EventHandler(this.priceBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mô tả:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Thumbnail:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Thực đơn:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputTitleMenu
            // 
            this.inputTitleMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTitleMenu.Location = new System.Drawing.Point(267, 243);
            this.inputTitleMenu.Name = "inputTitleMenu";
            this.inputTitleMenu.Size = new System.Drawing.Size(479, 41);
            this.inputTitleMenu.TabIndex = 13;
            this.inputTitleMenu.TextChanged += new System.EventHandler(this.inputTitleMenu_TextChanged);
            // 
            // tblProductBindingSource
            // 
            this.tblProductBindingSource.DataMember = "tblProduct";
            this.tblProductBindingSource.DataSource = this.managerCoffeeDataSet3;
            this.tblProductBindingSource.CurrentChanged += new System.EventHandler(this.tblProductBindingSource_CurrentChanged);
            // 
            // managerCoffeeDataSet3
            // 
            this.managerCoffeeDataSet3.DataSetName = "ManagerCoffeeDataSet3";
            this.managerCoffeeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProductTableAdapter
            // 
            this.tblProductTableAdapter.ClearBeforeFill = true;
            // 
            // fEditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 647);
            this.Controls.Add(this.panel1);
            this.Name = "fEditMenu";
            this.Text = "Chỉnh sửa thông tin thực đơn";
            this.Load += new System.EventHandler(this.fEditMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerCoffeeDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label notifyID;
        private System.Windows.Forms.Button checkID;
        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox changeThumbnail;
        private System.Windows.Forms.CheckBox changeDiscount;
        private System.Windows.Forms.CheckBox changeDescription;
        private System.Windows.Forms.CheckBox changePrice;
        private System.Windows.Forms.CheckBox changeTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox thumbnailBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox discountBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTitleMenu;
        private ManagerCoffeeDataSet3 managerCoffeeDataSet3;
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private ManagerCoffeeDataSet3TableAdapters.tblProductTableAdapter tblProductTableAdapter;
    }
}