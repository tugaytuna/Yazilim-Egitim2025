using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ListeYapısıForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        bool passCh = false;
        bool passNu = false;

        private void button1_Click(object sender, EventArgs e)
        {
            passCh = false;
            passNu = false;

            foreach (char c in txtSifre.Text)
            { 
                if (c < '0' || c > '9')
                {
                    passCh = true; 
                }
                else
                {
                    passNu = true;
                }
            }


            
            if (passNu && passCh)
            {
                MessageBox.Show("Şifre uygundur!");
                List<string> userpass = new List<string>();
                userpass.Add(txtUsername.Text);
                userpass.Add(txtSifre.Text);


                listBox1.Items.Add(userpass);
            }

        }


        class Users
        {
            public int UserId { get; set; }

            public string userName{ get; set; }

            public string userPassword{ get; set; } 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblName.Text = listBox1.SelectedItem[1].toString();

            //MessageBox.Show(listBox1.SelectedItem.ToString());

            //foreach (List<string> item in listBox1.Items)
            //{
            //    lblName.Text = item[1].ToString();
            //}

            for (int i = 0; i <= listBox1.Items.Count; i++)
            {
                if (i == listBox1.SelectedIndex)
                {
                    lblName.Text = listBox1.Items[i].ToString();
                }
            }

            //lblName.Text = txtSifre.Text;

        }
    }
}
