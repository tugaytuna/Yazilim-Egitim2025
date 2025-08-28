using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirisYapOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<User> users = new List<User>();
        User loggedUser = new User();

        string username = "";
        string password = "";

        bool login = false;


        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;



            foreach (User usr in users)
            {
                if (username == usr.UserName && password == usr.Password)
                {
                    loggedUser = usr;
                    login = true;
                }
            }

            if (login)
            {
                MessageBox.Show("Başarılı bir şekilde giriş yapıldı!");

                lblName.Text = loggedUser.UserName;
                lblEmail.Text = loggedUser.Email;
                lblAge.Text = loggedUser.Age.ToString();
                grpPersonalInfo.Visible = true;

                txtUsername.Text = "";
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
        }



        class User
        {
            public int UserId { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
            public int Age { get; set; }
            public bool Admin { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            users.Add(new User { UserId = 1, UserName = "tugaytuna", Password = "12345", Email = "tugaytuna@outlook.com.tr", Age = 18, Admin = true });

            users.Add(new User { UserId = 2, UserName = "metinok", Password = "54321", Email = "metinok@outlook.com", Age = 20, Admin = false });

            users.Add(new User { UserId = 3, UserName = "oner", Password = "5555", Email = "onerozturk@outlook.com", Age = 22, Admin = false });

            users.Add(new User { UserId = 4, UserName = "sibel", Password = "4444", Email = "sibelkatar@outlook.com", Age = 20, Admin = false });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();



            if (loggedUser.Admin)
            {
                listView1.Visible = true;

                foreach (User item in users)
                {
                    listView1.Items.Add(item.UserName);
                }


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            grpPersonalInfo.BackColor = colorDialog1.Color;
        }

        private void checkBoxSozlesme_CheckedChanged(object sender, EventArgs e)
        {
            textControl();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            //users.Add(new User { UserId = 1, UserName = "tugaytuna", Password = "12345", Email = "tugaytuna@outlook.com.tr", Age = 18, Admin = true });

            User kayit1 = new User();
            kayit1.UserName = txtKadi.Text;
            kayit1.Password = txtksifre.Text;
            kayit1.Email = txtkemail.Text;
            kayit1.Age = int.Parse(txtkyas.Text);
            kayit1.Admin = false;

            users.Add(kayit1);


            MessageBox.Show("Kayıt olunmuştur!");

            txtkemail.Clear();
            txtksifre.Clear();
            txtkyas.Clear();
            txtKadi.Clear();
            checkBoxSozlesme.Checked = false;

            tabControl1.SelectedIndex = 0;
        }




        //bool textControl()
        //{
        //    if (txtKadi.Text == "" || txtksifre.Text == "" || txtkemail.Text == "" || txtkyas.Text == "")
        //    {
        //        MessageBox.Show("Boş alan bırakılamaz!");
        //    }
        //    return false;
        //}

        void textControl()
        {
            if (txtKadi.Text == "" || txtksifre.Text == "" || txtkemail.Text == "" || txtkyas.Text == "" || checkBoxSozlesme.Checked == false)
            {
                btnKayitOl.Enabled = false;
            }

            if (txtKadi.Text != "" && txtksifre.Text != "" && txtkemail.Text != "" && txtkyas.Text != "" && checkBoxSozlesme.Checked == true)
            {
                btnKayitOl.Enabled = true;
            }
        }

        private void txtKadi_TextChanged(object sender, EventArgs e)
        {
            textControl();
        }

        private void txtksifre_TextChanged(object sender, EventArgs e)
        {
            textControl();
        }

        private void txtkemail_TextChanged(object sender, EventArgs e)
        {
            textControl();
        }

        private void txtkyas_TextChanged(object sender, EventArgs e)
        {
            textControl();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
    }
}
