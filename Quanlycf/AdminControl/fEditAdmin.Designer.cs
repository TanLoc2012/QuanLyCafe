namespace Quanlycf
{
    partial class fEditAdmin
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
            this.changeSex = new System.Windows.Forms.CheckBox();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.notifyID = new System.Windows.Forms.Label();
            this.checkID = new System.Windows.Forms.Button();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.changePass = new System.Windows.Forms.CheckBox();
            this.changePhone = new System.Windows.Forms.CheckBox();
            this.changeAddress = new System.Windows.Forms.CheckBox();
            this.changeDateOfBirth = new System.Windows.Forms.CheckBox();
            this.changeJob = new System.Windows.Forms.CheckBox();
            this.changeName = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateOfbirth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.jobList = new System.Windows.Forms.ListBox();
            this.tblRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerCoffeeDataSet2 = new Quanlycf.ManagerCoffeeDataSet2();
            this.label2 = new System.Windows.Forms.Label();
            this.femaleCheck = new System.Windows.Forms.RadioButton();
            this.maleCheck = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputNameNV = new System.Windows.Forms.TextBox();
            this.tblRoleTableAdapter = new Quanlycf.ManagerCoffeeDataSet2TableAdapters.tblRoleTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerCoffeeDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.changeSex);
            this.panel1.Controls.Add(this.showPass);
            this.panel1.Controls.Add(this.notifyID);
            this.panel1.Controls.Add(this.checkID);
            this.panel1.Controls.Add(this.IDbox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.changePass);
            this.panel1.Controls.Add(this.changePhone);
            this.panel1.Controls.Add(this.changeAddress);
            this.panel1.Controls.Add(this.changeDateOfBirth);
            this.panel1.Controls.Add(this.changeJob);
            this.panel1.Controls.Add(this.changeName);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.passBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.phoneBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.addressBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateOfbirth);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.jobList);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.femaleCheck);
            this.panel1.Controls.Add(this.maleCheck);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inputNameNV);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 654);
            this.panel1.TabIndex = 3;
            this.panel1.TabStop = true;
            // 
            // changeSex
            // 
            this.changeSex.AutoSize = true;
            this.changeSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeSex.Location = new System.Drawing.Point(752, 300);
            this.changeSex.Name = "changeSex";
            this.changeSex.Size = new System.Drawing.Size(81, 22);
            this.changeSex.TabIndex = 34;
            this.changeSex.Text = "thay đổi";
            this.changeSex.UseVisualStyleBackColor = true;
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPass.Location = new System.Drawing.Point(858, 592);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(135, 22);
            this.showPass.TabIndex = 33;
            this.showPass.Text = "show password";
            this.showPass.UseVisualStyleBackColor = true;
            // 
            // notifyID
            // 
            this.notifyID.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.notifyID.AutoSize = true;
            this.notifyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifyID.Location = new System.Drawing.Point(253, 196);
            this.notifyID.Name = "notifyID";
            this.notifyID.Size = new System.Drawing.Size(484, 18);
            this.notifyID.TabIndex = 32;
            this.notifyID.Text = "Vui lòng nhập chính xác ID nhân viên (không có khoảng trắng bất kỳ nào)";
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
            this.richTextBox1.Text = "1) Nhập ID nhân viên muốn chỉnh sửa\n2) Tại những vị trí cần thay đổi, tick vào \'t" +
    "hay đổi\'\n3) Thay đổi giá trị tại vị trí đó\n4) Để lưu thay đổi, nhấn ô màu hồng \"" +
    "Lưu thay đổi\"";
            // 
            // changePass
            // 
            this.changePass.AutoSize = true;
            this.changePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePass.Location = new System.Drawing.Point(754, 592);
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(81, 22);
            this.changePass.TabIndex = 25;
            this.changePass.Text = "thay đổi";
            this.changePass.UseVisualStyleBackColor = true;
            // 
            // changePhone
            // 
            this.changePhone.AutoSize = true;
            this.changePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePhone.Location = new System.Drawing.Point(754, 541);
            this.changePhone.Name = "changePhone";
            this.changePhone.Size = new System.Drawing.Size(81, 22);
            this.changePhone.TabIndex = 24;
            this.changePhone.Text = "thay đổi";
            this.changePhone.UseVisualStyleBackColor = true;
            // 
            // changeAddress
            // 
            this.changeAddress.AutoSize = true;
            this.changeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeAddress.Location = new System.Drawing.Point(754, 471);
            this.changeAddress.Name = "changeAddress";
            this.changeAddress.Size = new System.Drawing.Size(81, 22);
            this.changeAddress.TabIndex = 23;
            this.changeAddress.Text = "thay đổi";
            this.changeAddress.UseVisualStyleBackColor = true;
            // 
            // changeDateOfBirth
            // 
            this.changeDateOfBirth.AutoSize = true;
            this.changeDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDateOfBirth.Location = new System.Drawing.Point(754, 418);
            this.changeDateOfBirth.Name = "changeDateOfBirth";
            this.changeDateOfBirth.Size = new System.Drawing.Size(81, 22);
            this.changeDateOfBirth.TabIndex = 22;
            this.changeDateOfBirth.Text = "thay đổi";
            this.changeDateOfBirth.UseVisualStyleBackColor = true;
            // 
            // changeJob
            // 
            this.changeJob.AutoSize = true;
            this.changeJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeJob.Location = new System.Drawing.Point(754, 352);
            this.changeJob.Name = "changeJob";
            this.changeJob.Size = new System.Drawing.Size(81, 22);
            this.changeJob.TabIndex = 21;
            this.changeJob.Text = "thay đổi";
            this.changeJob.UseVisualStyleBackColor = true;
            // 
            // changeName
            // 
            this.changeName.AutoSize = true;
            this.changeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeName.Location = new System.Drawing.Point(752, 253);
            this.changeName.Name = "changeName";
            this.changeName.Size = new System.Drawing.Size(81, 22);
            this.changeName.TabIndex = 20;
            this.changeName.Text = "thay đổi";
            this.changeName.UseVisualStyleBackColor = true;
            this.changeName.CheckedChanged += new System.EventHandler(this.changeName_CheckedChanged);
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
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.Location = new System.Drawing.Point(267, 582);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(481, 41);
            this.passBox.TabIndex = 15;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 592);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 27);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mật khẩu:";
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.Location = new System.Drawing.Point(267, 525);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(481, 41);
            this.phoneBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số điện thoại:";
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.Location = new System.Drawing.Point(267, 461);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(481, 41);
            this.addressBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Địa chỉ:";
            // 
            // dateOfbirth
            // 
            this.dateOfbirth.Location = new System.Drawing.Point(267, 418);
            this.dateOfbirth.Name = "dateOfbirth";
            this.dateOfbirth.Size = new System.Drawing.Size(481, 22);
            this.dateOfbirth.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày sinh:";
            // 
            // jobList
            // 
            this.jobList.DataSource = this.tblRoleBindingSource;
            this.jobList.DisplayMember = "role_name";
            this.jobList.FormattingEnabled = true;
            this.jobList.ItemHeight = 16;
            this.jobList.Location = new System.Drawing.Point(267, 341);
            this.jobList.Name = "jobList";
            this.jobList.Size = new System.Drawing.Size(481, 52);
            this.jobList.TabIndex = 7;
            this.jobList.ValueMember = "id";
            // 
            // tblRoleBindingSource
            // 
            this.tblRoleBindingSource.DataMember = "tblRole";
            this.tblRoleBindingSource.DataSource = this.managerCoffeeDataSet2;
            // 
            // managerCoffeeDataSet2
            // 
            this.managerCoffeeDataSet2.DataSetName = "ManagerCoffeeDataSet2";
            this.managerCoffeeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chức vụ:";
            // 
            // femaleCheck
            // 
            this.femaleCheck.AutoSize = true;
            this.femaleCheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleCheck.Location = new System.Drawing.Point(355, 295);
            this.femaleCheck.Name = "femaleCheck";
            this.femaleCheck.Size = new System.Drawing.Size(59, 28);
            this.femaleCheck.TabIndex = 5;
            this.femaleCheck.TabStop = true;
            this.femaleCheck.Text = "Nữ";
            this.femaleCheck.UseVisualStyleBackColor = true;
            // 
            // maleCheck
            // 
            this.maleCheck.AutoSize = true;
            this.maleCheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleCheck.Location = new System.Drawing.Point(267, 294);
            this.maleCheck.Name = "maleCheck";
            this.maleCheck.Size = new System.Drawing.Size(73, 28);
            this.maleCheck.TabIndex = 4;
            this.maleCheck.TabStop = true;
            this.maleCheck.Text = "Nam";
            this.maleCheck.UseVisualStyleBackColor = true;
            this.maleCheck.CheckedChanged += new System.EventHandler(this.maleCheck_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giới tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Nhân viên:";
            // 
            // inputNameNV
            // 
            this.inputNameNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNameNV.Location = new System.Drawing.Point(267, 243);
            this.inputNameNV.Name = "inputNameNV";
            this.inputNameNV.Size = new System.Drawing.Size(479, 41);
            this.inputNameNV.TabIndex = 1;
            // 
            // tblRoleTableAdapter
            // 
            this.tblRoleTableAdapter.ClearBeforeFill = true;
            // 
            // fEditAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 647);
            this.Controls.Add(this.panel1);
            this.Name = "fEditAdmin";
            this.Text = "fEditAdmin";
            this.Load += new System.EventHandler(this.fEditAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerCoffeeDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox changeSex;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.Label notifyID;
        private System.Windows.Forms.Button checkID;
        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox changePass;
        private System.Windows.Forms.CheckBox changePhone;
        private System.Windows.Forms.CheckBox changeAddress;
        private System.Windows.Forms.CheckBox changeDateOfBirth;
        private System.Windows.Forms.CheckBox changeJob;
        private System.Windows.Forms.CheckBox changeName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateOfbirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox jobList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton femaleCheck;
        private System.Windows.Forms.RadioButton maleCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNameNV;
        private ManagerCoffeeDataSet2 managerCoffeeDataSet2;
        private System.Windows.Forms.BindingSource tblRoleBindingSource;
        private ManagerCoffeeDataSet2TableAdapters.tblRoleTableAdapter tblRoleTableAdapter;
    }
}