﻿namespace TOSapplication
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.tbTelefonEposta = new System.Windows.Forms.TextBox();
            this.cbUnvan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDogumYeri = new System.Windows.Forms.TextBox();
            this.tbUcret = new System.Windows.Forms.TextBox();
            this.tbYurtdisiAdres = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbDogumTarihi = new System.Windows.Forms.TextBox();
            this.tbPasaportNo = new System.Windows.Forms.TextBox();
            this.tbUyruk = new System.Windows.Forms.TextBox();
            this.tbBabaAdi = new System.Windows.Forms.TextBox();
            this.tbAdSoyad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSozlesme = new System.Windows.Forms.Button();
            this.cbTemsilcilik = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.btnIngSozlesme = new System.Windows.Forms.Button();
            this.btnDavetiye = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ünvan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adres";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAdres);
            this.groupBox1.Controls.Add(this.tbTelefonEposta);
            this.groupBox1.Controls.Add(this.cbUnvan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 176);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TARAFLAR";
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(120, 114);
            this.tbAdres.Multiline = true;
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(548, 56);
            this.tbAdres.TabIndex = 6;
            // 
            // tbTelefonEposta
            // 
            this.tbTelefonEposta.Location = new System.Drawing.Point(120, 70);
            this.tbTelefonEposta.Multiline = true;
            this.tbTelefonEposta.Name = "tbTelefonEposta";
            this.tbTelefonEposta.Size = new System.Drawing.Size(548, 38);
            this.tbTelefonEposta.TabIndex = 5;
            // 
            // cbUnvan
            // 
            this.cbUnvan.FormattingEnabled = true;
            this.cbUnvan.Items.AddRange(new object[] {
            "SİDE PARTNERS ORGANİZASYON TUR. VE TİC. LTD. ŞTİ.",
            "LAVINIA DANIŞMANLIK ORG.TUR.TİC.LTD.ŞTİ",
            "SİDE PARTNERS SAĞLIK TUR. VE TİC. LTD. ŞTİ"});
            this.cbUnvan.Location = new System.Drawing.Point(120, 29);
            this.cbUnvan.Name = "cbUnvan";
            this.cbUnvan.Size = new System.Drawing.Size(548, 21);
            this.cbUnvan.TabIndex = 4;
            this.cbUnvan.SelectedIndexChanged += new System.EventHandler(this.cbUnvan_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-posta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon Numarası";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDogumYeri);
            this.groupBox2.Controls.Add(this.tbUcret);
            this.groupBox2.Controls.Add(this.tbYurtdisiAdres);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbDogumTarihi);
            this.groupBox2.Controls.Add(this.tbPasaportNo);
            this.groupBox2.Controls.Add(this.tbUyruk);
            this.groupBox2.Controls.Add(this.tbBabaAdi);
            this.groupBox2.Controls.Add(this.tbAdSoyad);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(763, 205);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İŞÇİNİN";
            // 
            // tbDogumYeri
            // 
            this.tbDogumYeri.Location = new System.Drawing.Point(547, 40);
            this.tbDogumYeri.Name = "tbDogumYeri";
            this.tbDogumYeri.Size = new System.Drawing.Size(193, 20);
            this.tbDogumYeri.TabIndex = 12;
            // 
            // tbUcret
            // 
            this.tbUcret.Location = new System.Drawing.Point(120, 175);
            this.tbUcret.Name = "tbUcret";
            this.tbUcret.Size = new System.Drawing.Size(219, 20);
            this.tbUcret.TabIndex = 11;
            // 
            // tbYurtdisiAdres
            // 
            this.tbYurtdisiAdres.Location = new System.Drawing.Point(547, 113);
            this.tbYurtdisiAdres.Multiline = true;
            this.tbYurtdisiAdres.Name = "tbYurtdisiAdres";
            this.tbYurtdisiAdres.Size = new System.Drawing.Size(193, 82);
            this.tbYurtdisiAdres.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Ücret";
            // 
            // tbDogumTarihi
            // 
            this.tbDogumTarihi.Location = new System.Drawing.Point(547, 79);
            this.tbDogumTarihi.Name = "tbDogumTarihi";
            this.tbDogumTarihi.Size = new System.Drawing.Size(193, 20);
            this.tbDogumTarihi.TabIndex = 13;
            // 
            // tbPasaportNo
            // 
            this.tbPasaportNo.Location = new System.Drawing.Point(120, 138);
            this.tbPasaportNo.Name = "tbPasaportNo";
            this.tbPasaportNo.Size = new System.Drawing.Size(219, 20);
            this.tbPasaportNo.TabIndex = 10;
            // 
            // tbUyruk
            // 
            this.tbUyruk.Location = new System.Drawing.Point(120, 106);
            this.tbUyruk.Name = "tbUyruk";
            this.tbUyruk.Size = new System.Drawing.Size(219, 20);
            this.tbUyruk.TabIndex = 9;
            // 
            // tbBabaAdi
            // 
            this.tbBabaAdi.Location = new System.Drawing.Point(120, 72);
            this.tbBabaAdi.Name = "tbBabaAdi";
            this.tbBabaAdi.Size = new System.Drawing.Size(219, 20);
            this.tbBabaAdi.TabIndex = 8;
            // 
            // tbAdSoyad
            // 
            this.tbAdSoyad.Location = new System.Drawing.Point(120, 36);
            this.tbAdSoyad.Name = "tbAdSoyad";
            this.tbAdSoyad.Size = new System.Drawing.Size(219, 20);
            this.tbAdSoyad.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(416, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Yurtdışı İkamet Adresi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(416, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Doğum Tarihi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Doğum Yeri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Pasaport No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Uyruk";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Adı Soyadı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Baba Adı";
            // 
            // btnSozlesme
            // 
            this.btnSozlesme.Location = new System.Drawing.Point(250, 454);
            this.btnSozlesme.Name = "btnSozlesme";
            this.btnSozlesme.Size = new System.Drawing.Size(87, 43);
            this.btnSozlesme.TabIndex = 16;
            this.btnSozlesme.Text = "Sözleşme Oluştur";
            this.btnSozlesme.UseVisualStyleBackColor = true;
            this.btnSozlesme.Click += new System.EventHandler(this.btnSozlesme_Click);
            // 
            // cbTemsilcilik
            // 
            this.cbTemsilcilik.FormattingEnabled = true;
            this.cbTemsilcilik.Items.AddRange(new object[] {
            "BANGLADEŞ",
            "ENDONEZYA",
            "FAS",
            "İRAN",
            "KAMERUN",
            "NEPAL",
            "RUSYA"});
            this.cbTemsilcilik.Location = new System.Drawing.Point(132, 415);
            this.cbTemsilcilik.Name = "cbTemsilcilik";
            this.cbTemsilcilik.Size = new System.Drawing.Size(219, 21);
            this.cbTemsilcilik.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 423);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Temsilcilik";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(552, 412);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(400, 410);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 26);
            this.label14.TabIndex = 18;
            this.label14.Text = "Lütfen Tarihin Doğruluğunu\r\nKontrol Edin";
            // 
            // btnIngSozlesme
            // 
            this.btnIngSozlesme.Location = new System.Drawing.Point(132, 454);
            this.btnIngSozlesme.Name = "btnIngSozlesme";
            this.btnIngSozlesme.Size = new System.Drawing.Size(98, 43);
            this.btnIngSozlesme.TabIndex = 20;
            this.btnIngSozlesme.Text = "İngilizce Sözleşme Oluştur";
            this.btnIngSozlesme.UseVisualStyleBackColor = true;
            this.btnIngSozlesme.Click += new System.EventHandler(this.btnIngSozlesme_Click);
            // 
            // btnDavetiye
            // 
            this.btnDavetiye.Location = new System.Drawing.Point(12, 454);
            this.btnDavetiye.Name = "btnDavetiye";
            this.btnDavetiye.Size = new System.Drawing.Size(105, 43);
            this.btnDavetiye.TabIndex = 21;
            this.btnDavetiye.Text = "Davetiye Oluştur";
            this.btnDavetiye.UseVisualStyleBackColor = true;
            this.btnDavetiye.Click += new System.EventHandler(this.btnDavetiye_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 509);
            this.Controls.Add(this.btnDavetiye);
            this.Controls.Add(this.btnIngSozlesme);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbTemsilcilik);
            this.Controls.Add(this.btnSozlesme);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sö";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.TextBox tbTelefonEposta;
        private System.Windows.Forms.ComboBox cbUnvan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbYurtdisiAdres;
        private System.Windows.Forms.TextBox tbDogumTarihi;
        private System.Windows.Forms.TextBox tbPasaportNo;
        private System.Windows.Forms.TextBox tbUyruk;
        private System.Windows.Forms.TextBox tbBabaAdi;
        private System.Windows.Forms.TextBox tbAdSoyad;
        private System.Windows.Forms.TextBox tbUcret;
        private System.Windows.Forms.Button btnSozlesme;
        private System.Windows.Forms.ComboBox cbTemsilcilik;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbDogumYeri;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnIngSozlesme;
        private System.Windows.Forms.Button btnDavetiye;
    }
}

