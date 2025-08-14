using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontrollerOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Kullanici> kullanicilar = new List<Kullanici>();   

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            // OR || 
            if (txtKadi.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş bırakılamaz!");
                return;
            }

            //Checkbox seçili değilse devam edemezsiniz!
            //if (!checkBox1.Checked)
            //{
            //    MessageBox.Show("Kullanıcı sözleşmesiniz kabul etmeniz gerekiyor!");
            //    return;
            //}

            string kullaniciAdi;
            string sifre;
            string cinsiyet = "";

            kullaniciAdi = txtKadi.Text;
            sifre = txtSifre.Text;


            if (radioButton1.Checked)
            {
                cinsiyet = "Kadın";
            }
            else if (radioButton2.Checked)
            {
                cinsiyet = "Erkek";
            }else
            {
                // Cinsiyet null gelecek.
            }

            txtKadi.Text = "";
            txtSifre.Text = "";
            checkBox1.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            Kullanici k1 = new Kullanici();
            k1.KullaniciAdi = kullaniciAdi;
            k1.KullaniciSifre = sifre;
            k1.Cinsiyet = cinsiyet;
            DateTime date = new DateTime();
            date = DateTime.Now;
            k1.OlusturmaZamani = date;


            kullanicilar.Add(k1);

            MessageBox.Show("Kullanıcı kaydedildi! Kullanıcı adı: " + kullaniciAdi + " - " + cinsiyet);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                btnKayitOl.Enabled = true;
            }else
            {
                btnKayitOl.Enabled = false;
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtGKAdi.Text == "" || txtGSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş bırakılamaz!");
                return;
            }

            GirisYap(txtGKAdi.Text, txtGSifre.Text);

            txtGKAdi.Text = "";
            txtGSifre.Text = "";

        }

        void GirisYap(string kullaniciAdi, string sifre)
        {
            foreach (Kullanici user in kullanicilar)
            {
                if (kullaniciAdi == user.KullaniciAdi && sifre == user.KullaniciSifre)
                {
                    MessageBox.Show("Giriş Yapıldı");
                    MessageBox.Show("Kullanıcının şifresi: " + user.KullaniciSifre);
                    MessageBox.Show("Kullanıcının cinsiyeti: " + user.Cinsiyet);
                    MessageBox.Show("Oluşturulma Zamanı (test): " + user.OlusturmaZamani.ToString());
                }
                
            }


            
        }


        class Kullanici
        {
            public int UserId { get; set; }
            public string KullaniciAdi { get; set; }

            public string KullaniciSifre { get; set; }
            public string Cinsiyet { get; set; }
            public DateTime OlusturmaZamani { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          // Form ilk yüklendiğinde
        }

    }
}
