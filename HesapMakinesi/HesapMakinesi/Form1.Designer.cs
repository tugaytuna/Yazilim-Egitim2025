﻿namespace HesapMakinesi
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
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIslem = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(104, 97);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 20);
            this.txtSayi1.TabIndex = 0;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(282, 97);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 20);
            this.txtSayi2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(97, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hesap Makinesi";
            // 
            // lblIslem
            // 
            this.lblIslem.AutoSize = true;
            this.lblIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIslem.Location = new System.Drawing.Point(236, 97);
            this.lblIslem.Name = "lblIslem";
            this.lblIslem.Size = new System.Drawing.Size(24, 25);
            this.lblIslem.TabIndex = 2;
            this.lblIslem.Text = "+";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(296, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(251, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "x";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(152, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 38);
            this.button5.TabIndex = 7;
            this.button5.Text = "Hesapla";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.ForeColor = System.Drawing.Color.Red;
            this.lblSonuc.Location = new System.Drawing.Point(235, 237);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(31, 33);
            this.lblSonuc.TabIndex = 8;
            this.lblSonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 344);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblIslem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIslem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblSonuc;
    }
}

