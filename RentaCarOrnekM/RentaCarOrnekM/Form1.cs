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

namespace RentaCarOrnekM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=RentaCar;Integrated Security=True;";
        string connectionString2 = "Server=localhost\\SQLEXPRESS;Database=RentaCar; Trusted_Connection=True;";

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM Araclar",connection);

            DataTable table1 = new DataTable();
            adap.Fill(table1);


            dataGridView1.DataSource = table1;
            


        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString2))
            {
                // yukarıda oluşturduğumuz SqlConnection tipindeki connectionı başlatıyoruz.
                connection.Open();

                // istediğimiz bir sql query'sini string tipinde oluşturuyoruz.
                string query1 = "SELECT * FROM KullaniciKayitlari ORDER BY TakipciSayisi DESC";
                string query2 = "SELECT * FROM AktifKullanicilar ORDER BY TakipciSayisi DESC";
                string query3 = "SELECT * FROM Araclar";

                // yeni bir SqlCommand oluşturup parametre olarak query ve SqlConnection tipindeki connection'ı veriyoruz.
                SqlCommand command = new SqlCommand(query3, connection);
                // command'i çalıştırıp SqlDataReader tipindeki nesnemize aktarıyoruz.
                SqlDataReader reader = command.ExecuteReader();

                
                // SqlDataReader'ı okumaya başlıyoruz.
                while (reader.Read())
                {
                    //Console.WriteLine("Kullanıcı Adı: {0}, Takipçi Sayısı: {1}, Takip Edilen Sayısı: {2} ", reader.GetValue(0), reader.GetValue(1), reader["TakipEdilenSayisi"]);
                    listView1.Items.Add(reader["Model"].ToString());
                    //lblData1.Text = reader["Model"].ToString();
                    listView2.Items.Add(reader["Marka"].ToString());
                 
                }

               

                // SqlDataReader'ı kapatıyoruz.
                reader.Close();

            }
        }
    }
}
