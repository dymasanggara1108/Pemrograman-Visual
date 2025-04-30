using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AplikasiPerumahan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
              SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-518UR21;Initial Catalog=DBPerumahan;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into Warga values(@Nama,@Alamat)", con);
            cnn.Parameters.AddWithValue("@Nama", txtNama.Text);
            cnn.Parameters.AddWithValue("@Alamat", txtAlamat.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully!");
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-518UR21;Initial Catalog=DBPerumahan;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from Warga", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-518UR21;Initial Catalog=DBPerumahan;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from Warga where Nama like @nama", con);
            cnn.Parameters.AddWithValue("@nama", "%" + txtCari.Text + "%");
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-518UR21;Initial Catalog=DBPerumahan;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete from Warga where Nama=@Nama", con);
            cnn.Parameters.AddWithValue("@Nama", txtNama.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!");

        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-518UR21;Initial Catalog=DBPerumahan;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cnn = new SqlCommand("update Warga set Alamat=@Alamat where Nama=@Nama", con);
            cnn.Parameters.AddWithValue("@Nama", txtNama.Text);
            cnn.Parameters.AddWithValue("@Alamat", txtAlamat.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully!");

        }
    }
}
