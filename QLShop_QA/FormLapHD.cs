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
    public partial class FormLapHD : System.Windows.Forms.Form
    {
        public FormLapHD()
        {
            InitializeComponent();
        }
        public void loadDB()
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                dgvChiTietHoaDon.DataSource = from a in db.chiTietHDBans
                                        from b in db.hangs
                                        where a.maHang == b.maHang 
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
        private void clear()
        {
            txtTenKH.Clear();
            txtDC.Clear();
            txtDT.Clear();
            cboMaKH.Text = " ";
            txtMaHD.Clear();
            cboMaNV.Text = " ";
            txtTenNV.Clear();
            cboMaHang.Text = " ";
            txtTenHang.Clear();
            txtDonGia.Text = "";
            txtGiamGia.Text = "";
            txtSoluong.Text = "";
            txtThanhTien.Text = "0";
            txtTongTien.Text = "0";
        }
        private void FromQLHoaDon_Load(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                var dataNV = db.nhanViens.Select(k => k.maNhanVien);
                cboMaNV.DataSource = dataNV;

                var dataKH = db.khaches.Select(k => k.makhach);
                cboMaKH.DataSource = dataKH;

                var dataHH = db.hangs.Select(k => k.maHang);
                cboMaHang.DataSource = dataHH;
             
            }
            loadDB();
            clear();
        }

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                try
                {
                    khach makh = db.khaches.FirstOrDefault(p => p.makhach.Equals(cboMaKH.SelectedValue));
                    txtTenKH.Text = makh.tenkhach;
                    txtDC.Text = makh.diachi;
                    txtDT.Text = makh.dienthoai;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                try
                {
                    hang mahh = db.hangs.FirstOrDefault(p => p.maHang.Equals(cboMaHang.SelectedValue));
                    txtTenHang.Text = mahh.tenHang;
                    txtDonGia.Text = mahh.donGiaBan.ToString();
                  
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                try
                {
                    nhanVien manv = db.nhanViens.FirstOrDefault(p => p.maNhanVien.Equals(cboMaNV.SelectedValue));
                    txtTenNV.Text = manv.tenNhanVien;

                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                dgvChiTietHoaDon.DataSource = db.HDBans.Where(p => p.maHDBan.Equals(txtTimKiem.Text));
            }
            txtTimKiem.Clear();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                string mahd = dgvChiTietHoaDon.SelectedCells[0].OwningRow.Cells["maHang"].Value.ToString();
                chiTietHDBan delete = db.chiTietHDBans.Where(p => p.maHang.Equals(mahd)).SingleOrDefault();
                db.chiTietHDBans.DeleteOnSubmit(delete);
                db.SubmitChanges();
            }
            loadDB();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                chiTietHDBan sua = db.chiTietHDBans.Where(p => p.maHang.Equals(cboMaHang.Text)).SingleOrDefault();
                sua.maHDBan = txtMaHD.Text;
                sua.giamGia = double.Parse(txtGiamGia.Text);
                sua.soLuong = double.Parse(txtSoluong.Text);
                sua.donGia = double.Parse(txtDonGia.Text);
                sua.thanhTien = double.Parse(txtThanhTien.Text);
                db.SubmitChanges();
            }
            loadDB();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                cboMaHang.Text = dgvChiTietHoaDon.Rows[numrow].Cells[0].Value.ToString();
                txtTenHang.Text = dgvChiTietHoaDon.Rows[numrow].Cells[1].Value.ToString();
                txtSoluong.Text = dgvChiTietHoaDon.Rows[numrow].Cells[2].Value.ToString();
                txtDonGia.Text = dgvChiTietHoaDon.Rows[numrow].Cells[3].Value.ToString();
                txtGiamGia.Text = dgvChiTietHoaDon.Rows[numrow].Cells[4].Value.ToString();
                txtThanhTien.Text = dgvChiTietHoaDon.Rows[numrow].Cells[5].Value.ToString();
            }
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                chiTietHDBan mahdb = db.chiTietHDBans.Where(p => p.maHang.Equals(cboMaHang.Text)).SingleOrDefault();
                txtMaHD.Text = mahdb.maHDBan;
                db.SubmitChanges();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                try
                {
                    //Thêm CTHD khi có hóa đơn
                    chiTietHDBan themCTHD = new chiTietHDBan();
                    themCTHD.maHang = cboMaHang.Text;
                    themCTHD.maHDBan = txtMaHD.Text;
                    themCTHD.soLuong = double.Parse(txtSoluong.Text);
                    themCTHD.donGia = double.Parse(txtDonGia.Text);
                    themCTHD.giamGia = double.Parse(txtGiamGia.Text);
                    themCTHD.thanhTien = double.Parse(txtThanhTien.Text);
                    db.chiTietHDBans.InsertOnSubmit(themCTHD);
                    db.SubmitChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Thông tin bị thiếu hoặc sai!!!!", "Thông báo!", MessageBoxButtons.OK);
                }
            
            }
            loadDB();
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                try
                {
                    if (txtGiamGia.Text != "")
                    {
                        txtThanhTien.Text = (double.Parse(txtSoluong.Text) * double.Parse(txtDonGia.Text) * double.Parse(txtGiamGia.Text)).ToString();
                        db.SubmitChanges();
                    }
                    else
                    {
                        txtGiamGia.Text = "0";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Chỉ được nhập số!!!!", "Thông báo!", MessageBoxButtons.OK);
                }
            }
            loadDB();
        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
            //using (QLShop_QADataContext db = new QLShop_QADataContext())
            //{
            //    var thanhtien = from cthd in db.chiTietHDBans
            //                from hdb in db.HDBans
            //                where cthd.maHDBan == hdb.maHDBan
            //                select new { cthd.thanhTien };
            //var sum = db.chiTietHDBans.Select(c => c.thanhTien).Sum();
            //txtTongTien.Text = sum.ToString();
            //}
            //loadDB();
        }

        private void FromLapHD_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát hay không ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {

        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                try
                {
                    HDBan themHDB = new HDBan();
                    themHDB.maHDBan = txtMaHD.Text;
                    themHDB.maNhanVien = cboMaNV.Text;
                    themHDB.ngayBan = DateTime.Parse(dtpNgayBan.Text);
                    themHDB.maKhach = cboMaKH.Text;
                    themHDB.tongTien = double.Parse(txtTongTien.Text);
                    db.HDBans.InsertOnSubmit(themHDB);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm hóa đơn thành công", "Thông báo!", MessageBoxButtons.OK);
                    loadDGV_HDB();
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm hóa đơn thất bại!!!!", "Thông báo!", MessageBoxButtons.OK);
                }
                //Thêm hóa đơn
               
            }
            loadDB();
        }
        public void loadDGV_HDB()
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                dgvHoaDon.DataSource = from a in db.HDBans
                                       where a.maHDBan == txtMaHD.Text
                                       select new
                                       {
                                           maHDBan = a.maHDBan,
                                           maNhanVien = a.maNhanVien,
                                           ngayBan = a.ngayBan,
                                           maKhach = a.maKhach,
                                           tongTien = a.tongTien,
                                       };
            }
        }
        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                try
                {
                    HDBan sua = db.HDBans.Where(p => p.maHDBan.Equals(txtMaHD.Text)).SingleOrDefault();
                    sua.maNhanVien = cboMaNV.Text;
                    sua.maKhach = cboMaKH.Text;
                    sua.ngayBan = DateTime.Parse(dtpNgayBan.Text);
                    db.SubmitChanges();
                    MessageBox.Show("Sửa hóa đơn thành công", "Thông báo!", MessageBoxButtons.OK);
                    loadDGV_HDB();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa hóa đơn thất bại!!!!", "Thông báo!", MessageBoxButtons.OK);
                }
              
            }
            loadDB();
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            using (QLShop_QADataContext db = new QLShop_QADataContext())
            {
                try
                {
                    if (txtSoluong.Text != "" && txtGiamGia.Text =="")
                    {
                        txtThanhTien.Text = (double.Parse(txtSoluong.Text) * double.Parse(txtDonGia.Text)).ToString();
                        db.SubmitChanges();
                    }else
                    if(txtSoluong.Text != "")
                    {
                        txtThanhTien.Text = (double.Parse(txtSoluong.Text) * double.Parse(txtDonGia.Text) * double.Parse(txtGiamGia.Text)).ToString();
                        db.SubmitChanges();
                    }
                    else
                    {
                        txtSoluong.Text = "";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Chỉ được nhập số!!!!", "Thông báo!", MessageBoxButtons.OK);
                }
            }
            loadDB();
        }
    }
}
