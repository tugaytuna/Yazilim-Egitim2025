using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VeriAnaliz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veri Analiz Uygulamasına Hoşgeldiniz!");

            string connectionString = "Server=localhost\\SQLEXPRESS;Database=CRMOrnek;Trusted_Connection=True;";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string cmdText = "SELECT * FROM TumSiparisler";

                SqlCommand command = new SqlCommand(cmdText, connection);

                SqlDataReader dataReader = command.ExecuteReader();

                //List<TumSiparisler> tumSiparisList = new List<TumSiparisler>(); 

                while (dataReader.Read())
                {
                    //TumSiparisler siparis1 = new TumSiparisler();
                    //siparis1.MusteriIsim = dataReader.GetString(4);
                    //tumSiparisList.Add(siparis1);

                    Console.WriteLine("Müşteri Adı: {0}, Sipariş Tarihi: {1}", dataReader["MusteriAd"], dataReader["SiparisTarihi"]);
                }

                dataReader.Close();

            }


            
        }

        //class TumSiparisler
        //{
        //    public int SiparisId { get; set; }
        //    public string MusteriIsim{ get; set; }
        //}

    }

    
}


