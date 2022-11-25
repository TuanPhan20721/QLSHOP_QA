
namespace QLShop_QA
{
    partial class FormAdmin
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
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnQLSP = new System.Windows.Forms.Button();
            this.btnQLHD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQLKH
            // 
            this.btnQLKH.Location = new System.Drawing.Point(170, 75);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(453, 39);
            this.btnQLKH.TabIndex = 1;
            this.btnQLKH.Text = "Quản lý khách hàng";
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Location = new System.Drawing.Point(170, 156);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(453, 39);
            this.btnQLNV.TabIndex = 2;
            this.btnQLNV.Text = "Quản lý nhân viên";
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnQLSP
            // 
            this.btnQLSP.Location = new System.Drawing.Point(170, 238);
            this.btnQLSP.Name = "btnQLSP";
            this.btnQLSP.Size = new System.Drawing.Size(453, 39);
            this.btnQLSP.TabIndex = 3;
            this.btnQLSP.Text = "Quản lý sản phẩm";
            this.btnQLSP.UseVisualStyleBackColor = true;
            this.btnQLSP.Click += new System.EventHandler(this.btnQLSP_Click);
            // 
            // btnQLHD
            // 
            this.btnQLHD.Location = new System.Drawing.Point(170, 321);
            this.btnQLHD.Name = "btnQLHD";
            this.btnQLHD.Size = new System.Drawing.Size(453, 39);
            this.btnQLHD.TabIndex = 4;
            this.btnQLHD.Text = "Quản lý hóa đơn";
            this.btnQLHD.UseVisualStyleBackColor = true;
            this.btnQLHD.Click += new System.EventHandler(this.btnQLHD_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQLHD);
            this.Controls.Add(this.btnQLSP);
            this.Controls.Add(this.btnQLNV);
            this.Controls.Add(this.btnQLKH);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnQLSP;
        private System.Windows.Forms.Button btnQLHD;
    }
}