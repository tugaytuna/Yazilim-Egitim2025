using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alistirmalar_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            Settings settings1 = new Settings();

            if(settings1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("İşlem başarılı!");
            }
            else
            {
                MessageBox.Show("Dialog False");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com");
        }

        string url = "https://github.com/tugaytuna";

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(new Uri(url));
            //webBrowser1.Navigate("https://github.com/tugaytuna");
            //webBrowser1.Navigate(url);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now.AddYears(-18);
            dateTimePicker1.MaxDate = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime sdt = new DateTime();

            sdt = dateTimePicker1.Value;
            //label1.Text = sdt.Year.ToString();

            string gunler = (DateTime.Now - sdt).TotalDays.ToString();
            gunler = gunler.Remove(gunler.IndexOf(','));
            label1.Text = gunler;

        }
    }
}
