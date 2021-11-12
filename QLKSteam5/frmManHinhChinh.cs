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
    public partial class frmManHinhChinh : Form
    {
        public frmManHinhChinh()
        {
            InitializeComponent();
        }
        // hiển thị form Quản Lý Phòng
        private void btnQLP_Click(object sender, EventArgs e)
        {
           frmPhong frm=new frmPhong();
            frm.ShowDialog();
        }
        // hiển thị form Quản lý khách hàng

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.ShowDialog();
        }
        // hiển thị form Quản Nhân Viên

        private void button2_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
        }
        // hiển thị form Thanh Toán

        private void button3_Click(object sender, EventArgs e)
        {
            frmThanhToan frm = new frmThanhToan();
            frm.ShowDialog();
        }
    }
}
