﻿
namespace QLShop_QA
{
    partial class FormQLNhanVien
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
            this.gtvQLNV = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbtennv = new System.Windows.Forms.Label();
            this.GT = new System.Windows.Forms.Label();
            this.DC = new System.Windows.Forms.Label();
            this.DT = new System.Windows.Forms.Label();
            this.NS = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.maNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboQuyen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gtvQLNV)).BeginInit();
            this.SuspendLayout();
            // 
            // gtvQLNV
            // 
            this.gtvQLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gtvQLNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVien,
            this.taiKhoan,
            this.matKhau,
            this.idQuyen,
            this.tenNhanVien,
            this.gioiTinh,
            this.diaChi,
            this.dienThoai,
            this.ngaySinh});
            this.gtvQLNV.Location = new System.Drawing.Point(50, 178);
            this.gtvQLNV.Name = "gtvQLNV";
            this.gtvQLNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gtvQLNV.Size = new System.Drawing.Size(633, 238);
            this.gtvQLNV.TabIndex = 0;
            this.gtvQLNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gtvQLNV_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(246, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnThem.Location = new System.Drawing.Point(51, 441);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnXoa.Location = new System.Drawing.Point(132, 441);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnSua.Location = new System.Drawing.Point(213, 441);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnLuu.Location = new System.Drawing.Point(294, 442);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnThoat.Location = new System.Drawing.Point(605, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnTimKiem.Location = new System.Drawing.Point(620, 440);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(64, 23);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(453, 443);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(154, 20);
            this.txtTimKiem.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(10, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã nhân viên";
            // 
            // lbtennv
            // 
            this.lbtennv.AutoSize = true;
            this.lbtennv.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbtennv.Location = new System.Drawing.Point(6, 133);
            this.lbtennv.Name = "lbtennv";
            this.lbtennv.Size = new System.Drawing.Size(76, 13);
            this.lbtennv.TabIndex = 10;
            this.lbtennv.Text = "Tên nhân viên";
            // 
            // GT
            // 
            this.GT.AutoSize = true;
            this.GT.ForeColor = System.Drawing.Color.DarkCyan;
            this.GT.Location = new System.Drawing.Point(253, 88);
            this.GT.Name = "GT";
            this.GT.Size = new System.Drawing.Size(50, 13);
            this.GT.TabIndex = 11;
            this.GT.Text = "Giới tính ";
            // 
            // DC
            // 
            this.DC.AutoSize = true;
            this.DC.ForeColor = System.Drawing.Color.DarkCyan;
            this.DC.Location = new System.Drawing.Point(253, 133);
            this.DC.Name = "DC";
            this.DC.Size = new System.Drawing.Size(40, 13);
            this.DC.TabIndex = 12;
            this.DC.Text = "Địa chỉ";
            // 
            // DT
            // 
            this.DT.AutoSize = true;
            this.DT.ForeColor = System.Drawing.Color.DarkCyan;
            this.DT.Location = new System.Drawing.Point(471, 88);
            this.DT.Name = "DT";
            this.DT.Size = new System.Drawing.Size(55, 13);
            this.DT.TabIndex = 13;
            this.DT.Text = "Điện thoại";
            // 
            // NS
            // 
            this.NS.AutoSize = true;
            this.NS.ForeColor = System.Drawing.Color.DarkCyan;
            this.NS.Location = new System.Drawing.Point(471, 133);
            this.NS.Name = "NS";
            this.NS.Size = new System.Drawing.Size(54, 13);
            this.NS.TabIndex = 14;
            this.NS.Text = "Ngày sinh";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(88, 85);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(145, 20);
            this.txtMaNV.TabIndex = 15;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(309, 130);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(145, 20);
            this.txtDC.TabIndex = 17;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(532, 85);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(145, 20);
            this.txtDT.TabIndex = 18;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(88, 130);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(145, 20);
            this.txtTenNV.TabIndex = 20;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(309, 85);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(145, 21);
            this.cboGioiTinh.TabIndex = 21;
            this.cboGioiTinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboGioiTinh_KeyDown);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(532, 127);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(142, 20);
            this.dtpNgaySinh.TabIndex = 22;
            // 
            // maNhanVien
            // 
            this.maNhanVien.DataPropertyName = "maNhanVien";
            this.maNhanVien.HeaderText = "Mã nhân viên";
            this.maNhanVien.Name = "maNhanVien";
            // 
            // taiKhoan
            // 
            this.taiKhoan.DataPropertyName = "taiKhoan";
            this.taiKhoan.HeaderText = "Tài khoản";
            this.taiKhoan.Name = "taiKhoan";
            // 
            // matKhau
            // 
            this.matKhau.DataPropertyName = "matKhau";
            this.matKhau.HeaderText = "Mật khẩu";
            this.matKhau.Name = "matKhau";
            // 
            // idQuyen
            // 
            this.idQuyen.DataPropertyName = "idQuyen";
            this.idQuyen.HeaderText = "Quyền";
            this.idQuyen.Name = "idQuyen";
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.DataPropertyName = "tenNhanVien";
            this.tenNhanVien.HeaderText = "Tên nhân viên";
            this.tenNhanVien.Name = "tenNhanVien";
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.Width = 90;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            // 
            // dienThoai
            // 
            this.dienThoai.DataPropertyName = "dienThoai";
            this.dienThoai.HeaderText = "Điện thoại";
            this.dienThoai.Name = "dienThoai";
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "ngaySinh";
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.Name = "ngaySinh";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(822, 85);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(145, 20);
            this.txtTaiKhoan.TabIndex = 23;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(822, 126);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(145, 20);
            this.txtMatKhau.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(751, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(751, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(751, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Quyền";
            // 
            // cboQuyen
            // 
            this.cboQuyen.FormattingEnabled = true;
            this.cboQuyen.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboQuyen.Location = new System.Drawing.Point(822, 168);
            this.cboQuyen.Name = "cboQuyen";
            this.cboQuyen.Size = new System.Drawing.Size(145, 21);
            this.cboQuyen.TabIndex = 29;
            // 
            // FormQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 485);
            this.Controls.Add(this.cboQuyen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.NS);
            this.Controls.Add(this.DT);
            this.Controls.Add(this.DC);
            this.Controls.Add(this.GT);
            this.Controls.Add(this.lbtennv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gtvQLNV);
            this.Name = "FormQLNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQLNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.FormQLNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gtvQLNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gtvQLNV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbtennv;
        private System.Windows.Forms.Label GT;
        private System.Windows.Forms.Label DC;
        private System.Windows.Forms.Label DT;
        private System.Windows.Forms.Label NS;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn idQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboQuyen;
    }
}