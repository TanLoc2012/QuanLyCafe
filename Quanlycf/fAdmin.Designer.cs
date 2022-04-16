
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
            this.dvgUser = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mtbStaffPhone = new System.Windows.Forms.MaskedTextBox();
            this.id_staff = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.mskAddStaff = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkStaffMale = new System.Windows.Forms.CheckBox();
            this.chkStaffFemale = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFix = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUser)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgUser
            // 
            this.dvgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUser.Location = new System.Drawing.Point(1, 0);
            this.dvgUser.Name = "dvgUser";
            this.dvgUser.Size = new System.Drawing.Size(601, 368);
            this.dvgUser.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.txtStaffID);
            this.panel3.Controls.Add(this.mtbStaffPhone);
            this.panel3.Controls.Add(this.id_staff);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtStaffName);
            this.panel3.Controls.Add(this.mskAddStaff);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.chkStaffMale);
            this.panel3.Controls.Add(this.chkStaffFemale);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 155);
            this.panel3.TabIndex = 20;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(422, 44);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(120, 20);
            this.txtStaffID.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 366);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // mtbStaffPhone
            // 
            this.mtbStaffPhone.Location = new System.Drawing.Point(85, 123);
            this.mtbStaffPhone.Mask = "(999) 000-0000";
            this.mtbStaffPhone.Name = "mtbStaffPhone";
            this.mtbStaffPhone.Size = new System.Drawing.Size(149, 20);
            this.mtbStaffPhone.TabIndex = 9;
            // 
            // id_staff
            // 
            this.id_staff.AutoSize = true;
            this.id_staff.Location = new System.Drawing.Point(320, 49);
            this.id_staff.Name = "id_staff";
            this.id_staff.Size = new System.Drawing.Size(56, 13);
            this.id_staff.TabIndex = 14;
            this.id_staff.Text = "Mã Số NV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(25, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(83, 49);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(149, 20);
            this.txtStaffName.TabIndex = 3;
            this.txtStaffName.TextChanged += new System.EventHandler(this.txtStaffName_TextChanged_1);
            // 
            // mskAddStaff
            // 
            this.mskAddStaff.Location = new System.Drawing.Point(422, 123);
            this.mskAddStaff.Mask = "00000";
            this.mskAddStaff.Name = "mskAddStaff";
            this.mskAddStaff.Size = new System.Drawing.Size(120, 20);
            this.mskAddStaff.TabIndex = 17;
            this.mskAddStaff.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "SĐT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(25, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính";
            // 
            // chkStaffMale
            // 
            this.chkStaffMale.AutoSize = true;
            this.chkStaffMale.Location = new System.Drawing.Point(97, 91);
            this.chkStaffMale.Name = "chkStaffMale";
            this.chkStaffMale.Size = new System.Drawing.Size(46, 17);
            this.chkStaffMale.TabIndex = 6;
            this.chkStaffMale.Text = "nam";
            this.chkStaffMale.UseVisualStyleBackColor = true;
            // 
            // chkStaffFemale
            // 
            this.chkStaffFemale.AutoSize = true;
            this.chkStaffFemale.Location = new System.Drawing.Point(179, 91);
            this.chkStaffFemale.Name = "chkStaffFemale";
            this.chkStaffFemale.Size = new System.Drawing.Size(38, 17);
            this.chkStaffFemale.TabIndex = 7;
            this.chkStaffFemale.Text = "nữ";
            this.chkStaffFemale.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonClose);
            this.panel2.Controls.Add(this.buttonFix);
            this.panel2.Controls.Add(this.buttonContinue);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 45);
            this.panel2.TabIndex = 22;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(513, 10);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "&Đóng";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonFix
            // 
            this.buttonFix.Location = new System.Drawing.Point(142, 10);
            this.buttonFix.Name = "buttonFix";
            this.buttonFix.Size = new System.Drawing.Size(75, 23);
            this.buttonFix.TabIndex = 2;
            this.buttonFix.Text = "&Sửa";
            this.buttonFix.UseVisualStyleBackColor = true;
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(401, 10);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(75, 23);
            this.buttonContinue.TabIndex = 3;
            this.buttonContinue.Text = "&Bỏ qua";
            this.buttonContinue.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 10);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "&Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(265, 10);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "&Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dvgUser);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgUser)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.DataGridView dvgUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mtbStaffPhone;
        private System.Windows.Forms.Label id_staff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.MaskedTextBox mskAddStaff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkStaffMale;
        private System.Windows.Forms.CheckBox chkStaffFemale;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonFix;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
    }
}