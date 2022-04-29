namespace Quanlycf
{
    partial class fViewDetail
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
            this.notifyID = new System.Windows.Forms.Label();
            this.OrderDetail = new System.Windows.Forms.DataGridView();
            this.checkID = new System.Windows.Forms.Button();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyID
            // 
            this.notifyID.AutoSize = true;
            this.notifyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifyID.Location = new System.Drawing.Point(48, 114);
            this.notifyID.Name = "notifyID";
            this.notifyID.Size = new System.Drawing.Size(594, 20);
            this.notifyID.TabIndex = 41;
            this.notifyID.Text = "Nhập chính xác ID nằm trong cột ID xuất hiện đầu tiên ở bảng liệt kê đơn hàng!";
            // 
            // OrderDetail
            // 
            this.OrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDetail.Location = new System.Drawing.Point(52, 137);
            this.OrderDetail.Name = "OrderDetail";
            this.OrderDetail.RowHeadersWidth = 51;
            this.OrderDetail.RowTemplate.Height = 24;
            this.OrderDetail.Size = new System.Drawing.Size(708, 331);
            this.OrderDetail.TabIndex = 40;
            // 
            // checkID
            // 
            this.checkID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkID.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkID.Location = new System.Drawing.Point(620, 47);
            this.checkID.Name = "checkID";
            this.checkID.Size = new System.Drawing.Size(55, 31);
            this.checkID.TabIndex = 39;
            this.checkID.Text = "Tìm";
            this.checkID.UseVisualStyleBackColor = false;
            this.checkID.Click += new System.EventHandler(this.checkID_Click);
            // 
            // IDbox
            // 
            this.IDbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDbox.Location = new System.Drawing.Point(135, 41);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(479, 41);
            this.IDbox.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(66, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 27);
            this.label10.TabIndex = 37;
            this.label10.Text = "ID:";
            // 
            // fViewDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 496);
            this.Controls.Add(this.notifyID);
            this.Controls.Add(this.OrderDetail);
            this.Controls.Add(this.checkID);
            this.Controls.Add(this.IDbox);
            this.Controls.Add(this.label10);
            this.Name = "fViewDetail";
            this.Text = "fViewDetail";
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label notifyID;
        private System.Windows.Forms.DataGridView OrderDetail;
        private System.Windows.Forms.Button checkID;
        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.Label label10;
    }
}