namespace Quanlycf
{
    partial class deleteNV
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
            this.checkID = new System.Windows.Forms.Button();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkID
            // 
            this.checkID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkID.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkID.Location = new System.Drawing.Point(588, 88);
            this.checkID.Name = "checkID";
            this.checkID.Size = new System.Drawing.Size(55, 31);
            this.checkID.TabIndex = 34;
            this.checkID.Text = "Tìm";
            this.checkID.UseVisualStyleBackColor = false;
            this.checkID.Click += new System.EventHandler(this.checkID_Click);
            // 
            // IDbox
            // 
            this.IDbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDbox.Location = new System.Drawing.Point(90, 82);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(479, 41);
            this.IDbox.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 27);
            this.label10.TabIndex = 32;
            this.label10.Text = "ID:";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Yellow;
            this.delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delete.Location = new System.Drawing.Point(247, 197);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(167, 61);
            this.delete.TabIndex = 35;
            this.delete.Text = "Xóa Nhân viên";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.UseWaitCursor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Vui lòng nhập chính xác ID (không có khoảng trắng)";
            // 
            // deleteNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.checkID);
            this.Controls.Add(this.IDbox);
            this.Controls.Add(this.label10);
            this.Name = "deleteNV";
            this.Text = "deleteNV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkID;
        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
    }
}