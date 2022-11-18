
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
            ((System.ComponentModel.ISupportInitialize)(this.gtvQLNV)).BeginInit();
            this.SuspendLayout();
            // 
            // gtvQLNV
            // 
            this.gtvQLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gtvQLNV.Location = new System.Drawing.Point(50, 178);
            this.gtvQLNV.Name = "gtvQLNV";
            this.gtvQLNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gtvQLNV.Size = new System.Drawing.Size(633, 238);
            this.gtvQLNV.TabIndex = 0;
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
            this.label2.Location = new System.Drawing.Point(10, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã nhân viên";
            // 
            // lbtennv
            // 
            this.lbtennv.AutoSize = true;
            this.lbtennv.Location = new System.Drawing.Point(6, 133);
            this.lbtennv.Name = "lbtennv";
            this.lbtennv.Size = new System.Drawing.Size(76, 13);
            this.lbtennv.TabIndex = 10;
            this.lbtennv.Text = "Tên nhân viên";
            // 
            // GT
            // 
            this.GT.AutoSize = true;
            this.GT.Location = new System.Drawing.Point(253, 88);
            this.GT.Name = "GT";
            this.GT.Size = new System.Drawing.Size(50, 13);
            this.GT.TabIndex = 11;
            this.GT.Text = "Giới tính ";
            // 
            // DC
            // 
            this.DC.AutoSize = true;
            this.DC.Location = new System.Drawing.Point(253, 133);
            this.DC.Name = "DC";
            this.DC.Size = new System.Drawing.Size(40, 13);
            this.DC.TabIndex = 12;
            this.DC.Text = "Địa chỉ";
            // 
            // DT
            // 
            this.DT.AutoSize = true;
            this.DT.Location = new System.Drawing.Point(471, 88);
            this.DT.Name = "DT";
            this.DT.Size = new System.Drawing.Size(55, 13);
            this.DT.TabIndex = 13;
            this.DT.Text = "Điện thoại";
            // 
            // NS
            // 
            this.NS.AutoSize = true;
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
            // FormQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 485);
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
    }
}