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
    public partial class Form2 : Form
    {
        public Form2(double _aylikHedef)
        {
            InitializeComponent();
            aylikHedef = _aylikHedef;
            txtAylikHedef.Text = _aylikHedef.ToString() + " TL";
        }


        double aylikHedef = 0;
        double satisAdet = 0;

        //double sonucPrim = 0;

        public double sonucPrim { get; set; }



        private void btnPrimHesapla_Click(object sender, EventArgs e)
        {
          

            
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void txtSatisAdet_TextChanged(object sender, EventArgs e)
        {
            satisAdet = double.Parse(txtSatisAdet.Text);

            sonucPrim = (satisAdet / aylikHedef) * 20000;

            //int indexCom = sonucPrim.ToString().IndexOf(',');

            txtSonucPrim.Text = sonucPrim.ToString();
        }
    }
}
