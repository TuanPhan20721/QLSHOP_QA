using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLShop_QA
{
    public partial class FormQLNhanVien : System.Windows.Forms.Form
    {
        public FormQLNhanVien()
        {
            InitializeComponent();
        }
        private void FormQLNhanVien_Load(object sender, EventArgs e)
        {
            loadDB();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtDC.Clear();
            txtDT.Clear();
            txtMaNV.Clear();
            txtTenNV.Clear();
            cboGioiTinh.Text = null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                string manv = gtvQLNV.SelectedCells[0].OwningRow.Cells["maNhanVien"].Value.ToString();
                nhanVien delete = db.nhanViens.Where(p => p.maNhanVien.Equals(manv)).SingleOrDefault();
                db.nhanViens.DeleteOnSubmit(delete);
                db.SubmitChanges();
            }
            loadDB();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                string manv = gtvQLNV.SelectedCells[0].OwningRow.Cells["maNhanVien"].Value.ToString();
                string tennv = gtvQLNV.SelectedCells[0].OwningRow.Cells["tenNhanVien"].Value.ToString();
                string gioitinh = gtvQLNV.SelectedCells[0].OwningRow.Cells["gioiTinh"].Value.ToString();
                string diachi = gtvQLNV.SelectedCells[0].OwningRow.Cells["diaChi"].Value.ToString();
                string dienthoai = gtvQLNV.SelectedCells[0].OwningRow.Cells["dienThoai"].Value.ToString();
                DateTime? ngaysinh = gtvQLNV.SelectedCells[0].OwningRow.Cells["ngaySinh"].Value == null?
                    null : (DateTime?)gtvQLNV.SelectedCells[0].OwningRow.Cells["ngaySinh"].Value;

                nhanVien sua = db.nhanViens.Where(p => p.maNhanVien.Equals(manv)).SingleOrDefault();
                sua.tenNhanVien = tennv;
                sua.gioiTinh = gioitinh;
                sua.diaChi = diachi;
                sua.dienThoai = dienthoai;
                sua.ngaySinh = ngaysinh;

                db.SubmitChanges();
            }
            loadDB();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                //string manv = gtvQLNV.SelectedCells[0].OwningRow.Cells["maNhanVien"].Value.ToString();
                //string tennv = gtvQLNV.SelectedCells[1].OwningRow.Cells["tenNhanVien"].Value.ToString();
                //string gioitinh = gtvQLNV.SelectedCells[2].OwningRow.Cells["gioiTinh"].Value.ToString();
                //string diachi = gtvQLNV.SelectedCells[3].OwningRow.Cells["diaChi"].Value.ToString();
                //string dienthoai = gtvQLNV.SelectedCells[4].OwningRow.Cells["dienThoai"].Value.ToString();
                //DateTime ngaysinh = (DateTime)gtvQLNV.SelectedCells[5].OwningRow.Cells["ngaySinh"].Value;

                nhanVien them = new nhanVien();
                them.maNhanVien = txtMaNV.Text;
                them.tenNhanVien = txtTenNV.Text;
                them.gioiTinh = cboGioiTinh.Text;
                them.diaChi = txtDC.Text;
                them.dienThoai = txtDT.Text;
                them.ngaySinh = DateTime.Parse(dtpNgaySinh.Text);

                db.nhanViens.InsertOnSubmit(them);
                db.SubmitChanges();
            }
            loadDB();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                gtvQLNV.DataSource = db.nhanViens.Where(p => p.maNhanVien.Equals(txtTimKiem.Text));
            }
            txtTimKiem.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            new FormAdmin().Show();
            this.Hide();
        }
        public void loadDB()
        {
            using(QLShop_QADataContext db = new QLShop_QADataContext())
            {
                gtvQLNV.DataSource = from nv in db.nhanViens select nv;
            }    
        }

        private void cboGioiTinh_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void FormQLNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát hay không ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
