using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1Eylul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Hesapla();
        
        }

        int temelMaas = 0;
        double performansBonus = 0;
        double calismaGunu = 0;

        double yolUcret = 0;
        double yemekUcret = 0;


        void Hesapla()
        {
            temelMaas = int.Parse(txtTemelMaas.Text);
            
            if (radioButton1.Checked)
            {
                performansBonus = 1.1;
            }else if (radioButton2.Checked)
            {
                performansBonus = 1.2;
            }else if (radioButton3.Checked) 
            {
                performansBonus = 1.3;
            }else if (radioButton4.Checked)
            {
                performansBonus = 1;
            }else
            {
                performansBonus = 1;
            }

            calismaGunu = double.Parse(txtGunSayisi.Text);


        }

        private void txtGunSayisi_TextChanged(object sender, EventArgs e)
        {
            try{
                calismaGunu = double.Parse(txtGunSayisi.Text);
            }
            catch
            {
                calismaGunu = 0;
            }
            

            txtYemek.Text = (calismaGunu * 345).ToString();
            txtYol.Text = (calismaGunu * 115).ToString();
        }

        private void btnSatisHesap_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
