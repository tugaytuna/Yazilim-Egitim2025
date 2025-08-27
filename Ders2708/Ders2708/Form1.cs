using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Ders2708
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

        int loggedUserId = 0;


        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;

           

            foreach (User usr in users)
            {
                if (username == usr.UserName && password == usr.Password)
                {
                    loggedUser = usr;
                    loggedUserId = usr.UserId;
                    login = true;
                }
            }

            if (login) 
            {
                MessageBox.Show("Başarılı bir şekilde giriş yapıldı!");

                //foreach(User kk in users)
                //{
                //    if (kk.UserId == loggedUserId){
                //        MessageBox.Show(kk.Age.ToString());
                //    }
                //}


                //MessageBox.Show("Kullanıcının yaşı: " + users[loggedUserId - 1].Age);

                MessageBox.Show("Kullanıcının yaşı: " + loggedUser.Age);

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
            users.Add(new User { UserId = 1, UserName = "tugaytuna", Password = "12345", Email = "tugaytuna@outlook.com.tr", Age = 18 , Admin=true});

            users.Add(new User { UserId = 2, UserName = "metinok", Password = "54321", Email = "metinok@outlook.com", Age = 20 , Admin = false});

            users.Add(new User { UserId = 3, UserName = "oner", Password = "5555", Email = "onerozturk@outlook.com", Age = 22, Admin = false });

            users.Add(new User { UserId = 4, UserName = "sibel", Password = "4444", Email = "sibelkatar@outlook.com", Age = 20, Admin = false });

            //users.AddRange(new List<User>() { new User { UserId = 1, UserName = "tugaytuna", Password = "12345", Email = "tugaytuna@outlook.com.tr", Age = 18 }, new User { UserId = 2, UserName = "metinok", Password = "54321", Email = "metinok@outlook.com", Age = 20 }, new User { UserId = 3, UserName = "oner", Password = "5555", Email = "onerozturk@outlook.com", Age = 22 }, new User { UserId = 4, UserName = "sibel", Password = "4444", Email = "sibelkatar@outlook.com", Age = 20 } }); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            grpPersonalInfo.BackColor = colorDialog1.Color;


            if (loggedUser.Admin)
            {
                listView1.Visible = true;
               
                foreach (User item in users)
                {
                    listView1.Items.Add(item.UserName);
                }


            }
            

        }
    }
}
