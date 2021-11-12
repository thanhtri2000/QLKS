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
    public partial class frmThanhToan : Form
    {
        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            string result = "";
            double total = 0.0;
            int number = 0;
            string paycafe = lbgiacf.Text.Replace(" VND", "").Replace(".", "");
            string payfood = lbgiadoan.Text.Replace(" VND", "").Replace(".", "").Replace("Phòng Thường: ", "");
            foreach (Control ctr in this.gbDichVu.Controls)
            {
                if (ctr is CheckBox)
                {
                    CheckBox radio = (CheckBox)ctr;
                    if (radio.Checked)
                    {
                        double temp = Convert.ToDouble(paycafe);
                        total = temp;
                        break;
                    }
                }
            }
            foreach (Control ctr in this.gdPhong.Controls)
            {
                if (ctr is CheckBox)
                {
                    CheckBox radio = (CheckBox)ctr;
                    if (radio.Checked)
                    {
                        double temp = Convert.ToDouble(payfood);
                        total += temp;
                    }
                }
            }
            if (chkVip.Checked)
            {
                total = total * 2.0;
            }

            txtTongTien.Text = total.ToString("N3").Replace(".000", "VND");
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string result = "---Xin Chào Khách Hàng---\n";

            result += "Tên Khách Hàng: " + txtName.Text + "\n";
            result += "Số Điện Thoại: " + txtSDT.Text + "\n";
            result += "CMND: " + txtCMND.Text + "\n";
            result += "Tên Phòng: " + cbTenPhong.Text + "\n";
            result += "Tổng Tiền: " + txtTongTien.Text + "\n";
            string phong = "";
            foreach (Control ctr in this.gdPhong.Controls)
            {
                if (ctr is CheckBox)
                {
                    CheckBox radio = (CheckBox)ctr;
                    if (radio.Checked)
                    {
                        phong += "Loại Phòng: " + radio.Text + "\n";
                    }
                }
            }
            result += phong;
            string dichvu = "";
            foreach (Control ctr in this.gbDichVu.Controls)
            {
                if (ctr is CheckBox)
                {
                    CheckBox radio = (CheckBox)ctr;
                    if (radio.Checked)
                    {
                        dichvu += "Dịch Vụ: " + radio.Text + "\n";
                    }
                }
            }
            result += dichvu;
            MessageBox.Show(result, "Chi Tiết Hóa Đơn");
        }
    }
}
