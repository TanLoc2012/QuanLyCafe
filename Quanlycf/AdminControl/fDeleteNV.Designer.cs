namespace Quanlycf
{
    partial class fDeleteNV
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
            this.label1 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.checkID = new System.Windows.Forms.Button();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 14);
            this.label1.TabIndex = 41;
            this.label1.Text = "Vui lòng nhập chính xác ID (không có khoảng trắng)";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Yellow;
            this.delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delete.Location = new System.Drawing.Point(189, 130);
            this.delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(125, 50);
            this.delete.TabIndex = 40;
            this.delete.Text = "Xóa Nhân viên";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.UseWaitCursor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // checkID
            // 
            this.checkID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkID.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkID.Location = new System.Drawing.Point(445, 41);
            this.checkID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkID.Name = "checkID";
            this.checkID.Size = new System.Drawing.Size(41, 25);
            this.checkID.TabIndex = 39;
            this.checkID.Text = "Tìm";
            this.checkID.UseVisualStyleBackColor = false;
            this.checkID.Click += new System.EventHandler(this.checkID_Click);
            // 
            // IDbox
            // 
            this.IDbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDbox.Location = new System.Drawing.Point(71, 37);
            this.IDbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(360, 35);
            this.IDbox.TabIndex = 38;
            this.IDbox.TextChanged += new System.EventHandler(this.IDbox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 45);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 22);
            this.label10.TabIndex = 37;
            this.label10.Text = "ID:";
            // 
            // fDeleteNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 210);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.checkID);
            this.Controls.Add(this.IDbox);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fDeleteNV";
            this.Text = "Xóa nhân viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button checkID;
        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.Label label10;
    }
}