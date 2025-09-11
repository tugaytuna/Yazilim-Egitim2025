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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDialog_Click(object sender, EventArgs e)
        {
            //Örnek #1
            //if (MessageBox.Show("Message Box", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    label1.Text = "Yes";
            //}else
            //{
            //    label1.Text = "No";
            //}

            
            DialogResult result = MessageBox.Show("Message Box", "Uyarı");

            this.DialogResult = DialogResult.OK;
        }
    }
}
