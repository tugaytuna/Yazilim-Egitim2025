using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
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

            bool dongu = true;
            while (dongu)
            {
                Console.WriteLine("1-Kayıtları Getir");
                Console.WriteLine("2-Kayıt Oluştur");
                Console.WriteLine("3-Çıkış Yap");

                string secim = Console.ReadLine();

                

                switch (secim) {
                    case "1":
                        VeritabaniOku();
                        break;
                    case "2":
                        VeritabaniYaz();
                        break;
                    case "3":
                        dongu = false;
                        break;
                    default:
                        Console.WriteLine("Hatalı tuşlama yaptınız");
                        break;
                }

            }


            void VeritabaniOku()
            {

                // using kullanarak tüm database bağlantı işlerimizi yapıyoruz.
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // yukarıda oluşturduğumuz SqlConnection tipindeki connectionı başlatıyoruz.
                    connection.Open();

                    // istediğimiz bir sql query'sini string tipinde oluşturuyoruz.
                    string query1 = "SELECT * FROM KullaniciKayitlari ORDER BY TakipciSayisi DESC";
                    string query2 = "SELECT * FROM AktifKullanicilar ORDER BY TakipciSayisi DESC";

                    // yeni bir SqlCommand oluşturup parametre olarak query ve SqlConnection tipindeki connection'ı veriyoruz.
                    SqlCommand command = new SqlCommand(query2, connection);
                    // command'i çalıştırıp SqlDataReader tipindeki nesnemize aktarıyoruz.
                    SqlDataReader reader = command.ExecuteReader();

                    int counter = 0;
                    // SqlDataReader'ı okumaya başlıyoruz.
                    while (reader.Read())
                    {
                        Console.WriteLine("Kullanıcı Adı: {0}, Takipçi Sayısı: {1}, Takip Edilen Sayısı: {2} ", reader.GetValue(0), reader.GetValue(1), reader["TakipEdilenSayisi"]);

                        counter++;
                    }

                    Console.WriteLine("{0} adet kullanıcı listelendi.", counter);

                    // SqlDataReader'ı kapatıyoruz.
                    reader.Close();

                }

            }

            void VeritabaniYaz()
            {
                Console.WriteLine("Yeni kullanıcı oluşturuluyor...");

                Console.WriteLine("Lütfen kullanıcı adını giriniz:");
                string kadi = Console.ReadLine();
                Console.WriteLine("Lütfen şifrenizi giriniz:");
                string sifre = Console.ReadLine();

                Console.WriteLine("Lütfen takipçi sayınızı giriniz:");
                int takipciSayisi = int.Parse(Console.ReadLine());
                Console.WriteLine("Lütfen takip edilen sayısını giriniz:");
                int takipEdilenSayisi = int.Parse(Console.ReadLine());



                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO KullaniciKayitlari (KullaniciAdi, Sifre, Aktif, TakipciSayisi, TakipEdilenSayisi) VALUES (@kulaniciadi, @sifre, 1, @takipci,@takipedilen)";



                    SqlCommand command = new SqlCommand(query, connection);

                    //SqlCommand command1 = new SqlCommand();
                    //command1.CommandText = query;
                    //command1.Connection = connection;

                    command.Parameters.AddWithValue("@kulaniciadi", kadi);
                    command.Parameters.AddWithValue("@sifre", sifre);
                    command.Parameters.AddWithValue("@takipci",takipciSayisi);
                    command.Parameters.AddWithValue("@takipedilen",takipEdilenSayisi);


                    int result = command.ExecuteNonQuery();
                

                    Console.WriteLine("{0} adet satır eklendi.",result);
                }

            }


        }
    }
}
