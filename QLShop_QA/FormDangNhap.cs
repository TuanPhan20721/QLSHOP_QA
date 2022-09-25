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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát hay không ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(rs == DialogResult.No)
            {
                e.Cancel = true;
            }    
        }

        private void txtTDN_Leave(object sender, EventArgs e)
        {
            if(txtTDN.Text.Trim()=="")
            {
                this.errorTenDangNhap.SetError(txtTDN,"Bạn chưa nhập tên đăng nhập");
            }else
            {
                this.errorTenDangNhap.Clear();
            }    
        }

        private void txtMK_Leave(object sender, EventArgs e)
        {
            if (txtMK.Text.Trim() == "")
            {
                this.errorMatKhau.SetError(txtMK, "Bạn chưa nhập mật khẩu");
            }
            else
            {
                this.errorMatKhau.Clear();
            }
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if(txtTDN.Text.Trim() == "" )
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            if (txtMK.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                MessageBox.Show("Cảm ơn Bạn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }
    }
}
