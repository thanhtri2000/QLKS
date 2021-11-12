using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKSteam5
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string admin = "team5";
            string pass = "123";
            if (admin.Equals(txtTenDangNhap.Text) && pass.Equals(txtMatKhau.Text))
            {
                MessageBox.Show("Đăng nhập thành công");
                frmManHinhChinh f = new frmManHinhChinh();
                f.Show();
                this.Hide();

            }
            else
                MessageBox.Show("Sai thông tin đăng nhập");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
              ("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                this.Close();
        }
    }
}
