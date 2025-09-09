using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCarOrnekM
{
    public partial class YeniKayit : Form
    {
        public YeniKayit(int _rowCount)
        {
            InitializeComponent();
            txtAracId.Text = _rowCount.ToString();
        }

        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public int GunlukKira { get; set; }
        public int Kilometre{ get; set; }
        public int Vites { get; set; }

        private void YeniKayit_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblTrackNumber.Text = trackBar1.Value.ToString();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Vites bilgisini giriniz!");
                return;
            }

            if (txtMarka.Text == "" || txtModel.Text == "") 
            {
                MessageBox.Show("Marka-Model boş bırakılamaz!");
                return;
            }

            Marka = txtMarka.Text;
            Model = txtModel.Text;

            Yil = int.Parse(drpYil.Text);


            GunlukKira = trackBar1.Value;

            Kilometre = Convert.ToInt32(numericKm.Value);
            //Kilometre = int.Parse(txtKm.Text);

            

            if (radioButton1.Checked)
            {
                Vites = 0;
            }else if (radioButton2.Checked)
            {
                Vites = 1;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();



        }
    }
}
