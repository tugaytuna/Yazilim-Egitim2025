namespace _1Eylul
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTemelMaas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSatisPrim = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGunSayisi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYol = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYemek = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.btnSatisHesap = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAylikHedef = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(118, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ücret Hesaplama";
            // 
            // txtTemelMaas
            // 
            this.txtTemelMaas.Location = new System.Drawing.Point(124, 87);
            this.txtTemelMaas.Name = "txtTemelMaas";
            this.txtTemelMaas.Size = new System.Drawing.Size(100, 20);
            this.txtTemelMaas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Temel Maaş:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Satış Primi:";
            // 
            // txtSatisPrim
            // 
            this.txtSatisPrim.Location = new System.Drawing.Point(124, 204);
            this.txtSatisPrim.Name = "txtSatisPrim";
            this.txtSatisPrim.ReadOnly = true;
            this.txtSatisPrim.Size = new System.Drawing.Size(100, 20);
            this.txtSatisPrim.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(165, 116);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "%10";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(216, 116);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "%20";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Çalışılan Gün:";
            // 
            // txtGunSayisi
            // 
            this.txtGunSayisi.Location = new System.Drawing.Point(124, 240);
            this.txtGunSayisi.Name = "txtGunSayisi";
            this.txtGunSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtGunSayisi.TabIndex = 7;
            this.txtGunSayisi.TextChanged += new System.EventHandler(this.txtGunSayisi_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Yol Ücreti:";
            // 
            // txtYol
            // 
            this.txtYol.Location = new System.Drawing.Point(124, 288);
            this.txtYol.Name = "txtYol";
            this.txtYol.ReadOnly = true;
            this.txtYol.Size = new System.Drawing.Size(100, 20);
            this.txtYol.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Yemek Ücreti:";
            // 
            // txtYemek
            // 
            this.txtYemek.Location = new System.Drawing.Point(124, 314);
            this.txtYemek.Name = "txtYemek";
            this.txtYemek.ReadOnly = true;
            this.txtYemek.Size = new System.Drawing.Size(100, 20);
            this.txtYemek.TabIndex = 11;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(124, 395);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 25);
            this.lblSonuc.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Performans Bonusu:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(165, 141);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(45, 17);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "%30";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(53, 351);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(176, 23);
            this.btnHesapla.TabIndex = 16;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(216, 141);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(77, 17);
            this.radioButton4.TabIndex = 17;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Bonus Yok";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // btnSatisHesap
            // 
            this.btnSatisHesap.Location = new System.Drawing.Point(230, 201);
            this.btnSatisHesap.Name = "btnSatisHesap";
            this.btnSatisHesap.Size = new System.Drawing.Size(63, 23);
            this.btnSatisHesap.TabIndex = 18;
            this.btnSatisHesap.Text = "Hesapla";
            this.btnSatisHesap.UseVisualStyleBackColor = true;
            this.btnSatisHesap.Click += new System.EventHandler(this.btnSatisHesap_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Aylık Hedef:";
            // 
            // txtAylikHedef
            // 
            this.txtAylikHedef.Location = new System.Drawing.Point(124, 178);
            this.txtAylikHedef.Name = "txtAylikHedef";
            this.txtAylikHedef.Size = new System.Drawing.Size(100, 20);
            this.txtAylikHedef.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 463);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAylikHedef);
            this.Controls.Add(this.btnSatisHesap);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtYemek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGunSayisi);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSatisPrim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTemelMaas);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Kullanıcı Bilgileri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemelMaas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSatisPrim;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGunSayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYemek;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button btnSatisHesap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAylikHedef;
    }
}

