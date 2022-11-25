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
    public partial class FormAdmin : System.Windows.Forms.Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
           new FormQLKhachHang().Show();
           this.Hide();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            new FormQLNhanVien().Show();
            this.Hide();
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            new FormQLHang().Show();
            this.Hide();
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            new FormQLHoaDon().Show();
            this.Hide();
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát hay không ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
