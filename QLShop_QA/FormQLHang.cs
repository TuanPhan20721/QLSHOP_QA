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
    public partial class FormQLHang : Form
    {
        public FormQLHang()
        {
            InitializeComponent();
        }
        public void loadDB()
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                dgvSanPham.DataSource = from sp in db.hangs
                                        from cl in db.chatLieus
                                        where sp.maChatLieu == cl.maChatLieu
                                        select new
                                        {
                                            MaSP = sp.maHang,
                                            tenSP = sp.tenHang,
                                            maCL = cl.maChatLieu,
                                            soLuong = sp.soLuong,
                                            donGiaNhap = sp.donGiaNhap,
                                            donGiaBan = sp.donGiaBan,
                                            anh = sp.anh,
                                            GhiChu = sp.ghiChu
                                        };
            }
        }

        private void FormQLHang_Load(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                var data = db.chatLieus.Select(k => k);
                cboMaChatLieu.DataSource = data;
                cboMaChatLieu.DisplayMember = "maChatLieu";
                cboMaChatLieu.ValueMember = "maChatLieu";
            }
            loadDB();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                dgvSanPham.DataSource = db.hangs.Where(p => p.maHang.Equals(txtTimKiem.Text));
            }
            txtTimKiem.Clear();
        }

        
         private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaSP.Text = dgvSanPham.Rows[numrow].Cells[0].Value.ToString();
                txtTenSP.Text = dgvSanPham.Rows[numrow].Cells[1].Value.ToString();
                cboMaChatLieu.Text = dgvSanPham.Rows[numrow].Cells[2].Value.ToString();
                txtSoLuong.Text = dgvSanPham.Rows[numrow].Cells[3].Value.ToString();
                txtDonGiaNhap.Text = dgvSanPham.Rows[numrow].Cells[4].Value.ToString();
                txtDonGiaBan.Text = dgvSanPham.Rows[numrow].Cells[5].Value.ToString();
                txtAnh.Text = dgvSanPham.Rows[numrow].Cells[6].Value.ToString();
                txtGhiChu.Text = dgvSanPham.Rows[numrow].Cells[7].Value.ToString();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                string masp = dgvSanPham.SelectedCells[0].OwningRow.Cells["MaSP"].Value.ToString();
                hang delete = db.hangs.Where(p => p.maHang.Equals(masp)).SingleOrDefault();
                db.hangs.DeleteOnSubmit(delete);
                db.SubmitChanges();
            }
            loadDB();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                //txtMaSP.Text = dgvSanPham.SelectedCells[0].OwningRow.Cells["MaSP"].Value.ToString();
                //txtTenSP.Text = dgvSanPham.SelectedCells[0].OwningRow.Cells["tenSP"].Value.ToString();
                //cboMaChatLieu.Text = dgvSanPham.SelectedCells[0].OwningRow.Cells["maCL"].Value.ToString();
                //txtSoLuong.Text = dgvSanPham.SelectedCells[0].OwningRow.Cells["soLuong"].Value.ToString();
                //txtDonGiaNhap.Text = dgvSanPham.SelectedCells[0].OwningRow.Cells["donGiaNhap"].Value.ToString();
                //txtDonGiaBan.Text = dgvSanPham.SelectedCells[0].OwningRow.Cells["donGiaBan"].Value.ToString();
                //txtAnh.Text = dgvSanPham.SelectedCells[0].OwningRow.Cells["anh"].Value.ToString();
                //txtGhiChu.Text = dgvSanPham.SelectedCells[0].OwningRow.Cells["GhiChu"].Value.ToString();

                hang sua = db.hangs.Where(p => p.maHang.Equals(txtMaSP.Text)).SingleOrDefault();
                sua.maHang = txtMaSP.Text;
                sua.tenHang = txtTenSP.Text;
                sua.maChatLieu = cboMaChatLieu.Text;
                sua.soLuong = double.Parse(txtSoLuong.Text);
                sua.donGiaNhap = double.Parse(txtDonGiaNhap.Text);
                sua.donGiaBan = double.Parse(txtDonGiaBan.Text);
                sua.anh = txtAnh.Text;
                sua.ghiChu = txtGhiChu.Text;

                db.SubmitChanges();
            }
            loadDB();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                hang them = new hang();
                them.maHang = txtMaSP.Text;
                them.tenHang = txtTenSP.Text;
                them.maChatLieu = cboMaChatLieu.Text;
                them.soLuong = double.Parse(txtSoLuong.Text);
                them.donGiaNhap = double.Parse(txtDonGiaNhap.Text);
                them.donGiaBan = double.Parse(txtDonGiaBan.Text);
                them.anh = txtAnh.Text;
                them.ghiChu= txtGhiChu.Text;

                db.hangs.InsertOnSubmit(them);
                db.SubmitChanges();
            }
            loadDB();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtAnh.Clear();
            txtDonGiaBan.Clear();
            txtDonGiaNhap.Clear();
            txtGhiChu.Clear();
            txtMaSP.Clear();
            txtSoLuong.Clear();
            txtTenSP.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
