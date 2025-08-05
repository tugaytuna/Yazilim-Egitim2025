using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeritabaniBaglantisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veritabanı Bağlantısı Uygulamasına Hoş Geldiniz!");

            // SqlConnection oluştururken vermek için connection string oluşturduk.
            // connection string içerisinde, server bilgisi, database bilgisi ve giriş kuralı yazmalıdır.
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=Kullanicilar; Trusted_Connection=True;";

            // using kullanarak tüm database bağlantı işlerimizi yapıyoruz.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // yukarıda oluşturduğumuz SqlConnection tipindeki connectionı başlatıyoruz.
                connection.Open();

                // istediğimiz bir sql query'sini string tipinde oluşturuyoruz.
                string query1 = "SELECT * FROM KullaniciKayitlari ORDER BY TakipciSayisi DESC";
                string query2 = "SELECT * FROM AktifKullanicilar ORDER BY TakipciSayisi DESC";

                // yeni bir SqlCommand oluşturup parametre olarak query ve SqlConnection tipindeki connection'ı veriyoruz.
                SqlCommand command = new SqlCommand(query2,connection);
                // command'i çalıştırıp SqlDataReader tipindeki nesnemize aktarıyoruz.
                SqlDataReader reader = command.ExecuteReader();


                // SqlDataReader'ı okumaya başlıyoruz.
                while (reader.Read())
                {
                    Console.WriteLine("Kullanıcı Adı: {0}, Takipçi Sayısı: {1}, Takip Edilen Sayısı: {2} ", reader["KullaniciAdi"], reader["TakipciSayisi"], reader["TakipEdilenSayisi"]);
                }

                // SqlDataReader'ı kapatıyoruz.
                reader.Close();

            }





        }
    }
}
