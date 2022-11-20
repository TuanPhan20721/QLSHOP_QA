
namespace QLShop_QA
{
    partial class FormQLHang
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
            this.cboMaChatLieu = new System.Windows.Forms.ComboBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.NS = new System.Windows.Forms.Label();
            this.DT = new System.Windows.Forms.Label();
            this.DC = new System.Windows.Forms.Label();
            this.GT = new System.Windows.Forms.Label();
            this.lbtennv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMaChatLieu
            // 
            this.cboMaChatLieu.FormattingEnabled = true;
            this.cboMaChatLieu.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboMaChatLieu.Location = new System.Drawing.Point(315, 85);
            this.cboMaChatLieu.Name = "cboMaChatLieu";
            this.cboMaChatLieu.Size = new System.Drawing.Size(145, 21);
            this.cboMaChatLieu.TabIndex = 42;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(94, 130);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(145, 20);
            this.txtTenSP.TabIndex = 41;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(315, 175);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(145, 20);
            this.txtDonGiaNhap.TabIndex = 40;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(315, 130);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(145, 20);
            this.txtSoLuong.TabIndex = 39;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(94, 85);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(145, 20);
            this.txtMaSP.TabIndex = 38;
            // 
            // NS
            // 
            this.NS.AutoSize = true;
            this.NS.Location = new System.Drawing.Point(22, 175);
            this.NS.Name = "NS";
            this.NS.Size = new System.Drawing.Size(65, 13);
            this.NS.TabIndex = 37;
            this.NS.Text = "Đơn giá bán";
            // 
            // DT
            // 
            this.DT.AutoSize = true;
            this.DT.Location = new System.Drawing.Point(245, 175);
            this.DT.Name = "DT";
            this.DT.Size = new System.Drawing.Size(71, 13);
            this.DT.TabIndex = 36;
            this.DT.Text = "Đơn giá nhập";
            // 
            // DC
            // 
            this.DC.AutoSize = true;
            this.DC.Location = new System.Drawing.Point(259, 133);
            this.DC.Name = "DC";
            this.DC.Size = new System.Drawing.Size(49, 13);
            this.DC.TabIndex = 35;
            this.DC.Text = "Số lượng";
            // 
            // GT
            // 
            this.GT.AutoSize = true;
            this.GT.Location = new System.Drawing.Point(248, 88);
            this.GT.Name = "GT";
            this.GT.Size = new System.Drawing.Size(65, 13);
            this.GT.TabIndex = 34;
            this.GT.Text = "Mã chất liệu";
            // 
            // lbtennv
            // 
            this.lbtennv.AutoSize = true;
            this.lbtennv.Location = new System.Drawing.Point(12, 133);
            this.lbtennv.Name = "lbtennv";
            this.lbtennv.Size = new System.Drawing.Size(75, 13);
            this.lbtennv.TabIndex = 33;
            this.lbtennv.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mã sản phẩm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(619, 477);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(64, 23);
            this.btnTimKiem.TabIndex = 30;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(608, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 29;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(296, 478);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 28;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(215, 477);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(134, 477);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(53, 477);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(246, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(455, 479);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(154, 20);
            this.txtTimKiem.TabIndex = 31;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.tenSP,
            this.maCL,
            this.soLuong,
            this.donGiaNhap,
            this.donGiaBan,
            this.anh,
            this.GhiChu});
            this.dgvSanPham.Location = new System.Drawing.Point(50, 222);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(633, 238);
            this.dgvSanPham.TabIndex = 23;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            // 
            // tenSP
            // 
            this.tenSP.DataPropertyName = "tenSP";
            this.tenSP.HeaderText = "Tên sản phẩm";
            this.tenSP.Name = "tenSP";
            // 
            // maCL
            // 
            this.maCL.DataPropertyName = "maCL";
            this.maCL.HeaderText = "Mã chất liệu";
            this.maCL.Name = "maCL";
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.Name = "soLuong";
            // 
            // donGiaNhap
            // 
            this.donGiaNhap.DataPropertyName = "donGiaNhap";
            this.donGiaNhap.HeaderText = "Đơn giá nhập";
            this.donGiaNhap.Name = "donGiaNhap";
            // 
            // donGiaBan
            // 
            this.donGiaBan.DataPropertyName = "donGiaBan";
            this.donGiaBan.HeaderText = "Đơn giá bán";
            this.donGiaBan.Name = "donGiaBan";
            // 
            // anh
            // 
            this.anh.DataPropertyName = "anh";
            this.anh.HeaderText = "Ảnh";
            this.anh.Name = "anh";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(538, 85);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(145, 20);
            this.txtAnh.TabIndex = 44;
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(94, 172);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(145, 20);
            this.txtDonGiaBan.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Ảnh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(538, 133);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(145, 78);
            this.txtGhiChu.TabIndex = 47;
            // 
            // FormQLHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 517);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDonGiaBan);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.cboMaChatLieu);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtDonGiaNhap);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.NS);
            this.Controls.Add(this.DT);
            this.Controls.Add(this.DC);
            this.Controls.Add(this.GT);
            this.Controls.Add(this.lbtennv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvSanPham);
            this.Name = "FormQLHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.FormQLHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboMaChatLieu;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label NS;
        private System.Windows.Forms.Label DT;
        private System.Windows.Forms.Label DC;
        private System.Windows.Forms.Label GT;
        private System.Windows.Forms.Label lbtennv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGhiChu;
    }
}