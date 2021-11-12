using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKSteam5
{
    public partial class frmNhanVien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=.;Initial Catalog=PMQLKS5;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from tbl_nhanvien";
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView3.DataSource = table;


        }
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }
        // hien thi gia tri cua cac cot len datagridview
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.ReadOnly = true;
            int i;
            i = dataGridView3.CurrentRow.Index;
            txtMaNV.Text = dataGridView3.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dataGridView3.Rows[i].Cells[1].Value.ToString();
            cbGioiTinh.Text = dataGridView3.Rows[i].Cells[2].Value.ToString();
            cbCV.Text = dataGridView3.Rows[i].Cells[3].Value.ToString();
            txtDiaCHii.Text = dataGridView3.Rows[i].Cells[4].Value.ToString();
            txtSDTT.Text = dataGridView3.Rows[i].Cells[5].Value.ToString();

        }
        // them nhan vien
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into tbl_nhanvien values('" + txtMaNV.Text + "',N'" + txtTenNV.Text + "',N'" + cbGioiTinh.Text + "',N'" + cbCV.Text + "','" + txtDiaCHii.Text + "','" + txtSDTT.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Thêm Thành công");
        }
        // xoa nhan vien
        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from tbl_nhanvien where MaNV='" + txtMaNV.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }
        // sua nhan vien
        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            /*command = connection.CreateCommand();
            command.CommandText = "update tbl_nhanvien set TenNV='" + txtTenNV.Text + "',GioiTinh='" + cbGioiTinh.Text + "',ChucVu='"+cbCV.Text+"',DiaChi='" + txtDiaCHii + "',SDT='" + txtSDTT.Text + "'  Where MaNV= '"+ txtMaNV.Text + "'";
            command.ExecuteNonQuery();
            loaddata();*/
        }
    }
}
