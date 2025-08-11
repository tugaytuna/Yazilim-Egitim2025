using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgiler kaydedildi!");
        }

        private void btnOgrenciBilgi_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Öğrenci Bilgileri Kaydedildi!");
            label1.Text = "C# Kodu ile Değiştirildi";
            label1.ForeColor = Color.Blue;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 4)
            {
                MessageBox.Show("Şifre çok kısa!");
                return;
            }


            if (textBox1.Text == "tugaytuna")
            {
                MessageBox.Show("Admin Hoşgeldin");
            }else
            {
                MessageBox.Show("Hoş geldiniz " + textBox1.Text);
            }
        }

     

        
    }
}
