
namespace QLShop_QA
{
    partial class FormNhanVien
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
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnQuanLyHoaDon = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQLKH
            // 
            this.btnQLKH.Location = new System.Drawing.Point(49, 59);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(117, 73);
            this.btnQLKH.TabIndex = 2;
            this.btnQLKH.Text = "Quản lý khách hàng";
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnQuanLyHoaDon
            // 
            this.btnQuanLyHoaDon.Location = new System.Drawing.Point(239, 59);
            this.btnQuanLyHoaDon.Name = "btnQuanLyHoaDon";
            this.btnQuanLyHoaDon.Size = new System.Drawing.Size(117, 73);
            this.btnQuanLyHoaDon.TabIndex = 3;
            this.btnQuanLyHoaDon.Text = "Quản lý hóa đơn";
            this.btnQuanLyHoaDon.UseVisualStyleBackColor = true;
            this.btnQuanLyHoaDon.Click += new System.EventHandler(this.btnQuanLyHoaDon_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(152, 162);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(104, 39);
            this.btnDangXuat.TabIndex = 4;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 237);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnQuanLyHoaDon);
            this.Controls.Add(this.btnQLKH);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnQuanLyHoaDon;
        private System.Windows.Forms.Button btnDangXuat;
    }
}