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
    public partial class FormQLKhachHang : System.Windows.Forms.Form
    {
        public FormQLKhachHang()
        {
            InitializeComponent();
        }

        public void loadDB()
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                dgvKhachHang.DataSource = from kh in db.khaches select kh;
            }
        }

        private void FormQLKhachHang_Load(object sender, EventArgs e)
        {
            loadDB();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                dgvKhachHang.DataSource = db.khaches.Where(p => p.makhach.Equals(txtTimKiem.Text));
            }
            txtTimKiem.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtDC.Clear();
            txtDT.Clear();
            txtMaKH.Clear();
            txtTenKH.Clear();
            cboGioiTinh.Text = null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                string makh = dgvKhachHang.SelectedCells[0].OwningRow.Cells["makhach"].Value.ToString();
                khach delete = db.khaches.Where(p => p.makhach.Equals(makh)).SingleOrDefault();
                db.khaches.DeleteOnSubmit(delete);
                db.SubmitChanges();
            }
            loadDB();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                string maKH = dgvKhachHang.SelectedCells[0].OwningRow.Cells["makhach"].Value.ToString();
                string tenKH = dgvKhachHang.SelectedCells[0].OwningRow.Cells["tenkhach"].Value.ToString();
                string gioitinh = dgvKhachHang.SelectedCells[0].OwningRow.Cells["gioiTinh"].Value.ToString();
                string diachi = dgvKhachHang.SelectedCells[0].OwningRow.Cells["diachi"].Value.ToString();
                string dienthoai = dgvKhachHang.SelectedCells[0].OwningRow.Cells["dienthoai"].Value.ToString();
                DateTime? ngaysinh = dgvKhachHang.SelectedCells[0].OwningRow.Cells["ngaySinh"].Value == null ?
                    null : (DateTime?)dgvKhachHang.SelectedCells[0].OwningRow.Cells["ngaySinh"].Value;

                khach sua = db.khaches.Where(p => p.makhach.Equals(maKH)).SingleOrDefault();
                sua.tenkhach = tenKH;
                sua.gioiTinh = gioitinh;
                sua.diachi = diachi;
                sua.dienthoai = dienthoai;
                sua.ngaySinh = ngaysinh;
                db.SubmitChanges();
            }
            loadDB();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                khach them = new khach();
                them.makhach = txtMaKH.Text;
                them.tenkhach = txtTenKH.Text;
                them.gioiTinh = cboGioiTinh.Text;
                them.diachi = txtDC.Text;
                them.dienthoai = txtDT.Text;
                them.ngaySinh = DateTime.Parse(dtpNgaySinh.Text);

                db.khaches.InsertOnSubmit(them);
                db.SubmitChanges();
            }
            loadDB();
        }

        private void cboGioiTinh_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            new FormAdmin().Show();
            this.Hide();
        }

        private void FormQLKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát hay không ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
