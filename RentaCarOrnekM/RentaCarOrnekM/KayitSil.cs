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
    public partial class KayitSil : Form
    {
        public KayitSil(DataTable _table1)
        {
            InitializeComponent();
            dataGridView1.DataSource = _table1;
        }


        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if(txtPass.Text == "1234")
            {
                //MessageBox.Show("Şifre Doğru");
                formPass();
            }
        }

        
        void formPass()
        {
            txtPass.Visible = false;
            label1.Visible = false;

            groupBox1.Visible = true;

            //this.BackColor = Color.Black;

            this.Size = new Size(850, 750);
            

        }

        public int AracId { get; set; }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            AracId = int.Parse(txtAracId.Text);

            if (MessageBox.Show("Silmek istediğine emin misin?", "Silme İşlemi", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }


           
        }
    }
}
