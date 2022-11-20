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
    public partial class FromQLHoaDon : Form
    {
        public FromQLHoaDon()
        {
            InitializeComponent();
        }
        public void loadDB()
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                dgvHoaDon.DataSource = from hdb in db.chiTietHDBans
                                        from hh in db.hangs
                                        where hdb.maHang == hh.maHang
                                        select new
                                        {
                                            maHang = hh.maHang,
                                            tenHang = hh.tenHang,
                                            soLuong = hdb.soLuong,
                                            donGia = hdb.donGia,
                                            giamGia = hdb.giamGia,
                                            thanhTien = hdb.thanhTien,
                                        };
            }
        }
        private void FromQLHoaDon_Load(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                var dataNV = db.nhanViens.Select(k => k);
                cboMaNV.DataSource = dataNV;
                cboMaNV.DisplayMember = "maNhanVien";
                cboMaNV.ValueMember = "maNhanVien";

                var dataKH = db.khaches.Select(k => k);
                cboMaKH.DataSource = dataKH;
                cboMaKH.DisplayMember = "maKhach";
                cboMaKH.ValueMember = "maKhach";

                var dataHH = db.hangs.Select(k => k);
                cboMaHang.DataSource = dataHH;
                cboMaHang.DisplayMember = "maHang";
                cboMaHang.ValueMember = "maHang";
            }
            loadDB();
        }

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                khach makh = db.khaches.Where(p => p.makhach.Equals(cboMaKH.Text)).SingleOrDefault();
                if(makh == db.khaches)
            }
        }
    }
}
