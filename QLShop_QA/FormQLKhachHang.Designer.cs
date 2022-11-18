
namespace QLShop_QA
{
    partial class FormQLKhachHang
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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.NS = new System.Windows.Forms.Label();
            this.DT = new System.Windows.Forms.Label();
            this.DC = new System.Windows.Forms.Label();
            this.GT = new System.Windows.Forms.Label();
            this.lbtennv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(50, 178);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(633, 238);
            this.dgvKhachHang.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(246, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(538, 127);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(142, 20);
            this.dtpNgaySinh.TabIndex = 34;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(315, 85);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(145, 21);
            this.cboGioiTinh.TabIndex = 33;
            this.cboGioiTinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboGioiTinh_KeyDown);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(94, 130);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(145, 20);
            this.txtTenKH.TabIndex = 32;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(538, 85);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(145, 20);
            this.txtDT.TabIndex = 31;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(315, 130);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(145, 20);
            this.txtDC.TabIndex = 30;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(94, 85);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(145, 20);
            this.txtMaKH.TabIndex = 29;
            // 
            // NS
            // 
            this.NS.AutoSize = true;
            this.NS.Location = new System.Drawing.Point(477, 133);
            this.NS.Name = "NS";
            this.NS.Size = new System.Drawing.Size(54, 13);
            this.NS.TabIndex = 28;
            this.NS.Text = "Ngày sinh";
            // 
            // DT
            // 
            this.DT.AutoSize = true;
            this.DT.Location = new System.Drawing.Point(477, 88);
            this.DT.Name = "DT";
            this.DT.Size = new System.Drawing.Size(55, 13);
            this.DT.TabIndex = 27;
            this.DT.Text = "Điện thoại";
            // 
            // DC
            // 
            this.DC.AutoSize = true;
            this.DC.Location = new System.Drawing.Point(259, 133);
            this.DC.Name = "DC";
            this.DC.Size = new System.Drawing.Size(40, 13);
            this.DC.TabIndex = 26;
            this.DC.Text = "Địa chỉ";
            // 
            // GT
            // 
            this.GT.AutoSize = true;
            this.GT.Location = new System.Drawing.Point(259, 88);
            this.GT.Name = "GT";
            this.GT.Size = new System.Drawing.Size(50, 13);
            this.GT.TabIndex = 25;
            this.GT.Text = "Giới tính ";
            // 
            // lbtennv
            // 
            this.lbtennv.AutoSize = true;
            this.lbtennv.Location = new System.Drawing.Point(2, 133);
            this.lbtennv.Name = "lbtennv";
            this.lbtennv.Size = new System.Drawing.Size(86, 13);
            this.lbtennv.TabIndex = 24;
            this.lbtennv.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã khách hàng";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(605, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 35;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(452, 443);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(154, 20);
            this.txtTimKiem.TabIndex = 41;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(619, 440);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(64, 23);
            this.btnTimKiem.TabIndex = 40;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(293, 442);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 39;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(212, 441);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 38;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(131, 441);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(50, 441);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FormQLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 485);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.NS);
            this.Controls.Add(this.DT);
            this.Controls.Add(this.DC);
            this.Controls.Add(this.GT);
            this.Controls.Add(this.lbtennv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.label1);
            this.Name = "FormQLKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.FormQLKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label NS;
        private System.Windows.Forms.Label DT;
        private System.Windows.Forms.Label DC;
        private System.Windows.Forms.Label GT;
        private System.Windows.Forms.Label lbtennv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}