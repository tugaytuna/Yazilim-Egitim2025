namespace GirisYapOrnek
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.grpPersonalInfo = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKadi = new System.Windows.Forms.TextBox();
            this.txtksifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkemail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtkyas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxSozlesme = new System.Windows.Forms.CheckBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpPersonalInfo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Location = new System.Drawing.Point(18, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 206);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Yap";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(6, 125);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(161, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(6, 99);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(161, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(6, 54);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(161, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // grpPersonalInfo
            // 
            this.grpPersonalInfo.Controls.Add(this.button2);
            this.grpPersonalInfo.Controls.Add(this.listView1);
            this.grpPersonalInfo.Controls.Add(this.button1);
            this.grpPersonalInfo.Controls.Add(this.lblEmail);
            this.grpPersonalInfo.Controls.Add(this.lblAge);
            this.grpPersonalInfo.Controls.Add(this.lblName);
            this.grpPersonalInfo.Location = new System.Drawing.Point(26, 349);
            this.grpPersonalInfo.Name = "grpPersonalInfo";
            this.grpPersonalInfo.Size = new System.Drawing.Size(363, 206);
            this.grpPersonalInfo.TabIndex = 2;
            this.grpPersonalInfo.TabStop = false;
            this.grpPersonalInfo.Text = "Kişisel Bilgileri";
            this.grpPersonalInfo.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Renk Ayarla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(202, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(155, 181);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Renk Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 73);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(132, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "tugaytuna@outlook.com.tr";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(6, 106);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(19, 13);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "18";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tugay Tuna";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(22, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(529, 304);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(521, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Giriş Yap";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnKayitOl);
            this.tabPage2.Controls.Add(this.checkBoxSozlesme);
            this.tabPage2.Controls.Add(this.txtkyas);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtkemail);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtksifre);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtKadi);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(521, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kayıt Ol";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 167);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kayıt Olmak İçin";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // txtKadi
            // 
            this.txtKadi.Location = new System.Drawing.Point(9, 30);
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.Size = new System.Drawing.Size(196, 20);
            this.txtKadi.TabIndex = 1;
            this.txtKadi.TextChanged += new System.EventHandler(this.txtKadi_TextChanged);
            // 
            // txtksifre
            // 
            this.txtksifre.Location = new System.Drawing.Point(9, 69);
            this.txtksifre.Name = "txtksifre";
            this.txtksifre.Size = new System.Drawing.Size(196, 20);
            this.txtksifre.TabIndex = 3;
            this.txtksifre.TextChanged += new System.EventHandler(this.txtksifre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Şifre:";
            // 
            // txtkemail
            // 
            this.txtkemail.Location = new System.Drawing.Point(9, 110);
            this.txtkemail.Name = "txtkemail";
            this.txtkemail.Size = new System.Drawing.Size(196, 20);
            this.txtkemail.TabIndex = 5;
            this.txtkemail.TextChanged += new System.EventHandler(this.txtkemail_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email Adres:";
            // 
            // txtkyas
            // 
            this.txtkyas.Location = new System.Drawing.Point(9, 155);
            this.txtkyas.Name = "txtkyas";
            this.txtkyas.Size = new System.Drawing.Size(196, 20);
            this.txtkyas.TabIndex = 7;
            this.txtkyas.TextChanged += new System.EventHandler(this.txtkyas_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Yaşınız";
            // 
            // checkBoxSozlesme
            // 
            this.checkBoxSozlesme.AutoSize = true;
            this.checkBoxSozlesme.Location = new System.Drawing.Point(9, 181);
            this.checkBoxSozlesme.Name = "checkBoxSozlesme";
            this.checkBoxSozlesme.Size = new System.Drawing.Size(231, 17);
            this.checkBoxSozlesme.TabIndex = 8;
            this.checkBoxSozlesme.Text = "Kullanıcı Sözleşmesini Okudum Onaylıyorum";
            this.checkBoxSozlesme.UseVisualStyleBackColor = true;
            this.checkBoxSozlesme.CheckedChanged += new System.EventHandler(this.checkBoxSozlesme_CheckedChanged);
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Enabled = false;
            this.btnKayitOl.Location = new System.Drawing.Point(9, 215);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(196, 23);
            this.btnKayitOl.TabIndex = 9;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 648);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grpPersonalInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox grpPersonalInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.CheckBox checkBoxSozlesme;
        private System.Windows.Forms.TextBox txtkyas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtkemail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtksifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKadi;
        private System.Windows.Forms.Label label3;
    }
}

