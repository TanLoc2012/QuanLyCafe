namespace Quanlycf
{
    partial class fAddMenu
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
            this.createBox = new System.Windows.Forms.Button();
            this.categoryBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.thumbnailBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.Textbox();
            this.label3 = new System.Windows.Forms.Label();
            this.discountBox = new System.Windows.Forms.Textbox();
            this.label2 = new System.Windows.Forms.Label();
            this.tblProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerCoffeeDataSet1 = new Quanlycf.ManagerCoffeeDataSet1();
            this.tblProductTableAdapter = new Quanlycf.ManagerCoffeeDataSet1TableAdapters.tblProductTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerCoffeeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.createBox);
            this.panel1.Controls.Add(this.categoryBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.titleBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.priceBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.thumbnailBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.descriptionBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 651);
            this.panel1.TabIndex = 2;
            // 
            // createBox
            // 
            this.createBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.createBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBox.Location = new System.Drawing.Point(800, 93);
            this.createBox.Name = "createBox";
            this.createBox.Size = new System.Drawing.Size(126, 107);
            this.createBox.TabIndex = 16;
            this.createBox.Text = "Tạo mới";
            this.createBox.UseVisualStyleBackColor = false;
            this.createBox.Click += new System.EventHandler(this.createBox_Click);
            // 
            // categoryBox
            // 
            this.categoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBox.Location = new System.Drawing.Point(243, 552);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(481, 41);
            this.categoryBox.TabIndex = 14;
            this.categoryBox.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(94, 561);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "Danh mục:";
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(243, 473);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(481, 41);
            this.titleBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tên:";
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.Location = new System.Drawing.Point(243, 403);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(481, 41);
            this.priceBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giá:";
            // 
            // thumbnailBox
            // 
            this.thumbnailBox.Location = new System.Drawing.Point(243, 334);
            this.thumbnailBox.Name = "thumbnailBox";
            this.thumbnailBox.Size = new System.Drawing.Size(481, 22);
            this.thumbnailBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thumbnail:";
            // 
            // descriptionBox
            //
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(243, 403);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(481, 41);
            this.descriptionBox.TabIndex = 6;
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mô tả:";
            // 
            // discountBox
            //
            this.discountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountBox.Location = new System.Drawing.Point(243, 403);
            this.discountBox.Name = "discountBox";
            this.discountBox.Size = new System.Drawing.Size(481, 41);
            this.discountBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giảm giá:";
            // 
            // tblProductBindingSource
            // 
            this.tblProductBindingSource.DataMember = "tblProduct";
            this.tblProductBindingSource.DataSource = this.managerCoffeeDataSet1;
            // 
            // managerCoffeeDataSet1
            // 
            this.managerCoffeeDataSet1.DataSetName = "ManagerCoffeeDataSet1";
            this.managerCoffeeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProductTableAdapter
            // 
            this.tblProductTableAdapter.ClearBeforeFill = true;
            // 
            // fAddMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 650);
            this.Controls.Add(this.panel1);
            this.Name = "fAddMenu";
            this.Text = "Biểu mẫu thêm món ăn";
            this.Load += new System.EventHandler(this.fAddMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerCoffeeDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button createBox;
        private System.Windows.Forms.TextBox categoryBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox thumbnailBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox discountBox;
        private System.Windows.Forms.Label label2;
        private ManagerCoffeeDataSet1 managerCoffeeDataSet1;
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private ManagerCoffeeDataSet1TableAdapters.tblProductTableAdapter tblProductTableAdapter;
    }
}