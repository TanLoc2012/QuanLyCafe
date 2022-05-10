namespace Quanlycf
{
    partial class fAddNV
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
            this.showPass = new System.Windows.Forms.CheckBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeBox = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.jobBox = new System.Windows.Forms.ListBox();
            this.tblRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerCoffeeDataSet1 = new Quanlycf.ManagerCoffeeDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.femaleBox = new System.Windows.Forms.RadioButton();
            this.maleBox = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.tblRoleTableAdapter = new Quanlycf.ManagerCoffeeDataSet1TableAdapters.tblRoleTableAdapter();
            this.managerCoffeeDataSet3 = new Quanlycf.ManagerCoffeeDataSet3();
            this.tblRoleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblRoleTableAdapter1 = new Quanlycf.ManagerCoffeeDataSet3TableAdapters.tblRoleTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerCoffeeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerCoffeeDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoleBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.createBox);
            this.panel1.Controls.Add(this.showPass);
            this.panel1.Controls.Add(this.passBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.phoneBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.addressBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateTimeBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.jobBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.femaleBox);
            this.panel1.Controls.Add(this.maleBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 529);
            this.panel1.TabIndex = 2;
            // 
            // createBox
            // 
            this.createBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.createBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBox.Location = new System.Drawing.Point(600, 76);
            this.createBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createBox.Name = "createBox";
            this.createBox.Size = new System.Drawing.Size(94, 87);
            this.createBox.TabIndex = 16;
            this.createBox.Text = "Tạo mới";
            this.createBox.UseVisualStyleBackColor = false;
            this.createBox.Click += new System.EventHandler(this.createBox_Click);
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Location = new System.Drawing.Point(554, 458);
            this.showPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(101, 17);
            this.showPass.TabIndex = 15;
            this.showPass.Text = "Show password";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.Location = new System.Drawing.Point(182, 448);
            this.passBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(362, 35);
            this.passBox.TabIndex = 14;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 456);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mật khẩu:";
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.Location = new System.Drawing.Point(182, 384);
            this.phoneBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(362, 35);
            this.phoneBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 392);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số điện thoại:";
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.Location = new System.Drawing.Point(182, 327);
            this.addressBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(362, 35);
            this.addressBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 327);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Địa chỉ:";
            // 
            // dateTimeBox
            // 
            this.dateTimeBox.Location = new System.Drawing.Point(182, 271);
            this.dateTimeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeBox.Name = "dateTimeBox";
            this.dateTimeBox.Size = new System.Drawing.Size(362, 20);
            this.dateTimeBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày sinh:";
            // 
            // jobBox
            // 
            this.jobBox.DataSource = this.tblRoleBindingSource1;
            this.jobBox.DisplayMember = "role_name";
            this.jobBox.FormattingEnabled = true;
            this.jobBox.Location = new System.Drawing.Point(182, 191);
            this.jobBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jobBox.Name = "jobBox";
            this.jobBox.Size = new System.Drawing.Size(362, 43);
            this.jobBox.TabIndex = 6;
            this.jobBox.ValueMember = "id";
            // 
            // tblRoleBindingSource
            // 
            this.tblRoleBindingSource.DataMember = "tblRole";
            this.tblRoleBindingSource.DataSource = this.managerCoffeeDataSet1;
            // 
            // managerCoffeeDataSet1
            // 
            this.managerCoffeeDataSet1.DataSetName = "ManagerCoffeeDataSet1";
            this.managerCoffeeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chức vụ:";
            // 
            // femaleBox
            // 
            this.femaleBox.AutoSize = true;
            this.femaleBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleBox.Location = new System.Drawing.Point(253, 148);
            this.femaleBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.femaleBox.Name = "femaleBox";
            this.femaleBox.Size = new System.Drawing.Size(51, 23);
            this.femaleBox.TabIndex = 4;
            this.femaleBox.TabStop = true;
            this.femaleBox.Text = "Nữ";
            this.femaleBox.UseVisualStyleBackColor = true;
            // 
            // maleBox
            // 
            this.maleBox.AutoSize = true;
            this.maleBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleBox.Location = new System.Drawing.Point(182, 148);
            this.maleBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maleBox.Name = "maleBox";
            this.maleBox.Size = new System.Drawing.Size(62, 23);
            this.maleBox.TabIndex = 3;
            this.maleBox.TabStop = true;
            this.maleBox.Text = "Nam";
            this.maleBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Nhân viên:";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(184, 76);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(360, 35);
            this.nameBox.TabIndex = 1;
            // 
            // tblRoleTableAdapter
            // 
            this.tblRoleTableAdapter.ClearBeforeFill = true;
            // 
            // managerCoffeeDataSet3
            // 
            this.managerCoffeeDataSet3.DataSetName = "ManagerCoffeeDataSet3";
            this.managerCoffeeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRoleBindingSource1
            // 
            this.tblRoleBindingSource1.DataMember = "tblRole";
            this.tblRoleBindingSource1.DataSource = this.managerCoffeeDataSet3;
            // 
            // tblRoleTableAdapter1
            // 
            this.tblRoleTableAdapter1.ClearBeforeFill = true;
            // 
            // fAddNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 528);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fAddNV";
            this.Text = "Biểu mẫu thêm nhân viên";
            this.Load += new System.EventHandler(this.fAddNV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerCoffeeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerCoffeeDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoleBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button createBox;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox jobBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton femaleBox;
        private System.Windows.Forms.RadioButton maleBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private ManagerCoffeeDataSet1 managerCoffeeDataSet1;
        private System.Windows.Forms.BindingSource tblRoleBindingSource;
        private ManagerCoffeeDataSet1TableAdapters.tblRoleTableAdapter tblRoleTableAdapter;
        private ManagerCoffeeDataSet3 managerCoffeeDataSet3;
        private System.Windows.Forms.BindingSource tblRoleBindingSource1;
        private ManagerCoffeeDataSet3TableAdapters.tblRoleTableAdapter tblRoleTableAdapter1;
    }
}