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
    public partial class FormQLHoaDon : System.Windows.Forms.Form
    {
        public FormQLHoaDon()
        {
            InitializeComponent();
        }

        private void FromQLHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát hay không ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        public void loadDB()
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                dgvHoaDon.DataSource = from a in db.HDBans
                                       select new
                                       {
                                           MaHDBan = a.maHDBan,
                                           maNhanVien = a.maNhanVien,
                                           ngayBan = a.ngayBan,
                                           maKhach = a.maKhach,
                                           tongTien = a.tongTien,
                                       };

            }
        }
        private void FromQLHoaDon_Load(object sender, EventArgs e)
        {
            loadDB();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                string mahd = dgvHoaDon.SelectedCells[0].OwningRow.Cells["maHDBan"].Value.ToString();
                HDBan delete = db.HDBans.Where(p => p.maHDBan.Equals(mahd)).SingleOrDefault();
                db.HDBans.DeleteOnSubmit(delete);
                db.SubmitChanges();
            }
            loadDB();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                string mahd = dgvHoaDon.SelectedCells[0].OwningRow.Cells["maHDBan"].Value.ToString();
                dtgCTHD.DataSource =   from a in db.chiTietHDBans
                                       from b in db.hangs
                                       from c in db.HDBans
                                       where a.maHang == b.maHang && a.maHDBan == mahd
                                       select new
                                       {
                                           maHang = a.maHang,
                                           tenHang = b.tenHang,
                                           soLuong = a.soLuong,
                                           donGia = b.donGiaBan,
                                           giamGia = a.giamGia,
                                           thanhTien = a.thanhTien,
                                       };
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            new FormAdmin().Show();
            this.Hide();
        }
    }
}
