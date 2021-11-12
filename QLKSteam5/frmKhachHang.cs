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
    public partial class frmKhachHang : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=.;Initial Catalog=PMQLKS5;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from tbl_khachhang";
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView2.DataSource = table;
        }
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }
        //hiển thị giá trị các cột trong sql len datagridview
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView2.CurrentRow.Index;
            txtMaKH.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            cbGT.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            txtDT.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            txtCM.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
        }
        // them khach hang
        private void button7_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into tbl_Phong values('" + txtMaKH.Text + "',N'" + txtTenKH.Text + "',N'" + cbGT.Text + "',N'" + txtDiaChi.Text + "','" + txtDT.Text + "','" + txtCM.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Thêm Thành công");

        }
        // xoa khách hàng
        private void button9_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from tbl_Phong where MaKH='" + txtMaKH.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
