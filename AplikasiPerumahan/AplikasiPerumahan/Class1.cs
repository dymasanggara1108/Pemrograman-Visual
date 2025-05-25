using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiPerumahan
{
    internal class Class1
    {
        public void InsertWarga(string nama, string alamat)
        {
            using (SqlConnection con = koneksi.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Warga VALUES(@Nama, @Alamat)", con);
                cmd.Parameters.AddWithValue("@Nama", nama);
                cmd.Parameters.AddWithValue("@Alamat", alamat);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateWarga(string nama, string alamat)
        {
            using (SqlConnection con = koneksi.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Warga SET Alamat=@Alamat WHERE Nama=@Nama", con);
                cmd.Parameters.AddWithValue("@Nama", nama);
                cmd.Parameters.AddWithValue("@Alamat", alamat);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteWarga(string nama)
        {
            using (SqlConnection con = koneksi.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Warga WHERE Nama=@Nama", con);
                cmd.Parameters.AddWithValue("@Nama", nama);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllWarga()
        {
            using (SqlConnection con = koneksi.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Warga", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable CariWarga(string keyword)
        {
            using (SqlConnection con = koneksi.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Warga WHERE Nama LIKE @Keyword OR Alamat LIKE @Keyword", con);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
