using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            lblIslem.Text = "+";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblIslem.Text = "-";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblIslem.Text = "x";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblIslem.Text = "/";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (lblIslem.Text)
            {
                case "+":
                    Hesapla("+", txtSayi1.Text, txtSayi2.Text);
                    break;
                case "-":
                    Hesapla("-", txtSayi1.Text, txtSayi2.Text);
                    break;
                case "x":
                    Hesapla("x", txtSayi1.Text, txtSayi2.Text);
                    break;
                case "/":
                    Hesapla("/", txtSayi1.Text, txtSayi2.Text);
                    break;
            }
                
        }

         
        void Hesapla(string islem, string _sayi1, string _sayi2)
        {
            int sayi1 = 0;
            int sayi2 = 0;

            try{
                sayi1 = int.Parse(_sayi1);
                sayi2 = int.Parse(_sayi2);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            

            int sonuc = 0;

            if (islem == "+")
            {
                sonuc = sayi1 + sayi2;
            }else if (islem == "-") 
            {
                sonuc = sayi1 - sayi2;
            }else if (islem == "x")
            {
                sonuc = sayi1 * sayi2;
            }else if (islem == "/")
            {
                sonuc = sayi1 / sayi2;
            }

            lblSonuc.Text = sonuc.ToString();


        }

    }
}
