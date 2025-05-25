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
        private Class1 repo;
        public Form1()
        {
            InitializeComponent();
            repo = new Class1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                repo.InsertWarga(txtNama.Text, txtAlamat.Text);
                MessageBox.Show("Record Saved Successfully!");
                TampilkanData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            TampilkanData();
        }

        private void TampilkanData()
        {
            try
            {
                DataTable dt = repo.GetAllWarga();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = repo.CariWarga(txtCari.Text);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                repo.DeleteWarga(txtNama.Text);
                MessageBox.Show("Record Deleted Successfully!");
                TampilkanData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                repo.UpdateWarga(txtNama.Text, txtAlamat.Text);
                MessageBox.Show("Record Updated Successfully!");
                TampilkanData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
