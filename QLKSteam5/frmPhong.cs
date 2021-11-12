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
    public partial class frmPhong : Form
    {
        //lien ket sql
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=.;Initial Catalog=PMQLKS5;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        // hiển thị các thông tin lên datagridview
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from tbl_Phong";
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView4.DataSource = table;
        }
        public frmPhong()
        {
            InitializeComponent();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }
        // hiển thị giá trị của cột trong sql len datagridview
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // txtMaKH.ReadOnly = true;
            int i;
            i = dataGridView4.CurrentRow.Index;
            txtmaKhH.Text = dataGridView4.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = dataGridView4.Rows[i].Cells[1].Value.ToString();
            cbSP.Text = dataGridView4.Rows[i].Cells[2].Value.ToString();
            cbLP.Text = dataGridView4.Rows[i].Cells[3].Value.ToString();
            txtSL.Text = dataGridView4.Rows[i].Cells[4].Value.ToString();
            dtpNgayDen.Text = dataGridView4.Rows[i].Cells[5].Value.ToString();
            dtpNgayDi.Text = dataGridView4.Rows[i].Cells[6].Value.ToString();
            txtGia.Text = dataGridView4.Rows[i].Cells[7].Value.ToString();
        }
        //Them Phong
        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into tbl_Phong values('" + txtmaKhH.Text + "',N'" + txtTenKH.Text + "',N'" + cbSP.Text + "',N'" + cbLP.Text + "','" + txtSL.Text + "','" + dtpNgayDen.Text + "','"+dtpNgayDi.Text+"','"+txtGia.Text+"')";
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Thêm Thành công");
        }
        // xoa Phong
        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from tbl_Phong where MaKH='" + txtmaKhH.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
