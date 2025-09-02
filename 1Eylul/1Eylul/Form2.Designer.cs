namespace _1Eylul
{
    partial class Form2
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
            this.btnPrimHesapla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSatisAdet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSonucPrim = new System.Windows.Forms.TextBox();
            this.txtAylikHedef = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Satış Prim Hesaplama";
            // 
            // btnPrimHesapla
            // 
            this.btnPrimHesapla.Location = new System.Drawing.Point(164, 293);
            this.btnPrimHesapla.Name = "btnPrimHesapla";
            this.btnPrimHesapla.Size = new System.Drawing.Size(100, 23);
            this.btnPrimHesapla.TabIndex = 2;
            this.btnPrimHesapla.Text = "Hesapla";
            this.btnPrimHesapla.UseVisualStyleBackColor = true;
            this.btnPrimHesapla.Click += new System.EventHandler(this.btnPrimHesapla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yapılan Satış";
            // 
            // txtSatisAdet
            // 
            this.txtSatisAdet.Location = new System.Drawing.Point(162, 196);
            this.txtSatisAdet.Name = "txtSatisAdet";
            this.txtSatisAdet.Size = new System.Drawing.Size(100, 20);
            this.txtSatisAdet.TabIndex = 6;
            this.txtSatisAdet.TextChanged += new System.EventHandler(this.txtSatisAdet_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Satış Primi";
            // 
            // txtSonucPrim
            // 
            this.txtSonucPrim.Location = new System.Drawing.Point(164, 251);
            this.txtSonucPrim.Name = "txtSonucPrim";
            this.txtSonucPrim.ReadOnly = true;
            this.txtSonucPrim.Size = new System.Drawing.Size(100, 20);
            this.txtSonucPrim.TabIndex = 8;
            // 
            // txtAylikHedef
            // 
            this.txtAylikHedef.Location = new System.Drawing.Point(164, 138);
            this.txtAylikHedef.Name = "txtAylikHedef";
            this.txtAylikHedef.ReadOnly = true;
            this.txtAylikHedef.Size = new System.Drawing.Size(100, 20);
            this.txtAylikHedef.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aylık Hedef";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 401);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSonucPrim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSatisAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrimHesapla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAylikHedef);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Satış Prim Hesaplama";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrimHesapla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSatisAdet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSonucPrim;
        private System.Windows.Forms.TextBox txtAylikHedef;
        private System.Windows.Forms.Label label2;
    }
}