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



        // istediğimiz bir sql query'sini string tipinde oluşturuyoruz.
        string query1 = "SELECT * FROM KullaniciKayitlari ORDER BY TakipciSayisi DESC";
        string query2 = "SELECT * FROM AktifKullanicilar ORDER BY TakipciSayisi DESC";
        string query3 = "SELECT * FROM Araclar";

        int rowCount = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTable();

        }

        DataTable UpdateTable()
        {
            SqlConnection connection = new SqlConnection(connectionString2);

            SqlDataAdapter adap = new SqlDataAdapter(query3, connection);

            DataTable table1 = new DataTable();
            adap.Fill(table1);


            dataGridView1.DataSource = table1;
            rowCount = dataGridView1.RowCount;
            return table1;
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString2))
            {
                // yukarıda oluşturduğumuz SqlConnection tipindeki connectionı başlatıyoruz.
                connection.Open();


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

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            YeniKayit yeniKayitForm = new YeniKayit(rowCount);
           

            if (yeniKayitForm.ShowDialog() == DialogResult.OK)
            {
                SqlConnection connection = new SqlConnection(connectionString2);
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Araclar (Marka, Model, Yil, Vites, GunlukKira, Kilometre) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)",connection);
                
                command.Parameters.AddWithValue("@p1", yeniKayitForm.Marka);
                command.Parameters.AddWithValue("@p2", yeniKayitForm.Model);
                command.Parameters.AddWithValue("@p3", yeniKayitForm.Yil);
                command.Parameters.AddWithValue("@p4", yeniKayitForm.Vites);
                command.Parameters.AddWithValue("@p5", yeniKayitForm.GunlukKira);
                command.Parameters.AddWithValue("p6", yeniKayitForm.Kilometre);

                
                command.ExecuteNonQuery();
                

                connection.Close();
                UpdateTable();
                MessageBox.Show("Kayıt başarılı bir şekilde eklendi!");

            }

        }

        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            KayitSil kayitSilForm = new KayitSil(UpdateTable());

            if(kayitSilForm.ShowDialog() == DialogResult.OK)
            {
                SqlConnection connection = new SqlConnection(connectionString2);
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Araclar WHERE AracID=@p1", connection);
                command.Parameters.AddWithValue("@p1", kayitSilForm.AracId);
                 
                int commandResult = command.ExecuteNonQuery();

                connection.Close();


                MessageBox.Show(commandResult.ToString() + " tane satır etkilendi. Silme işlemi başarılı!", "Silme İşlemi Başarılı!");

                UpdateTable();

            }




        }
    }
}
