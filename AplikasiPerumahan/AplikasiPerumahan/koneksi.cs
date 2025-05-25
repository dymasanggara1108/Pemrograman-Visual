using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiPerumahan
{
    internal class koneksi
    {
        private static readonly string connectionString = @"Data Source=DESKTOP-518UR21;Initial Catalog=DBPerumahan;TrustServerCertificate=True;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
