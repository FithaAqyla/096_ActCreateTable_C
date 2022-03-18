using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PABD2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Koneksi();
        }
        public void Koneksi()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-AS5OAOK;database=ProdiTI; Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand(" Create table Mahasiswa_Coba (NIM char(12) not null primary key, " +
                    "Nama varchar (50), Alamat varchar(255), Jenis_Kelamin char(1))", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel sukses dibuat!");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("Dops, sepertinya ada yang salah. ", e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
