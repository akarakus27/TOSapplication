using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using Application = Microsoft.Office.Interop.Word.Application;
using Microsoft.VisualBasic;

namespace TOSapplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbUnvan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbUnvan.SelectedIndex == 0)
                {
                    tbTelefonEposta.Text = "0242 740 00 11";
                    tbAdres.Text = "BAHÇELİ EVLER MAHALLESİ ÇETİN EMEÇ CADDESİ NO : 58 / 2 MANAVGAT/ANTALYA";
                }
                if (cbUnvan.SelectedIndex == 1)
                {
                    tbTelefonEposta.Text = "0212 232 03 24";
                    tbAdres.Text = "MERKEZ MAH.HASAT SOK.KAMARA NO:52/1 ŞİŞLİ/İSTANBUL";
                }
                if (cbUnvan.SelectedIndex == 2)
                {
                    tbTelefonEposta.Text = "0242 740 00 11";
                    tbAdres.Text = "BAHÇELİ EVLER MAHALLESİ ÇETİN EMEÇ CADDESİ NO : 58 / 3 MANAVGAT /ANTALYA";
                }
            }
            catch (Exception r)
            {

                MessageBox.Show(r.Message);
            }
           
        }
        private void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            try
            {
                object matchCase = true;
                object matchWholeWord = true;
                object matchWildCards = false;
                object matchSoundLike = false;
                object nmatchAllforms = false;
                object forward = true;
                object format = false;
                object matchKashida = false;
                object matchDiactitics = false;
                object matchAlefHamza = false;
                object matchControl = false;
                object read_only = false;
                object visible = true;
                object replace = 2;
                object wrap = 1;

                wordApp.Selection.Find.Execute(ref ToFindText,
                    ref matchCase, ref matchWholeWord,
                    ref matchWildCards, ref matchSoundLike,
                    ref nmatchAllforms, ref forward,
                    ref wrap, ref format, ref replaceWithText,
                    ref replace, ref matchKashida,
                    ref matchDiactitics, ref matchAlefHamza,
                    ref matchControl);
            }
            catch (Exception r)
            {

                MessageBox.Show(r.Message);
            }
           
        }

        private void CreateInvitationDocument(object filename, object SaveAs)
        {
            try
            {
                Word.Application wordApp = new Word.Application();
                object missing = Missing.Value;
                Word.Document myWordDoc = null;

                if (File.Exists((string)filename))
                {
                    object readOnly = false;
                    object isVisible = false;
                    wordApp.Visible = false;

                    myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing, ref missing);
                    myWordDoc.Activate();

                    //find and replace
                    this.FindAndReplace(wordApp, "temsilcilik", cbTemsilcilik.Text);
                    this.FindAndReplace(wordApp, "adres", tbAdres.Text);
                    this.FindAndReplace(wordApp, "adsoyad", tbAdSoyad.Text);
                    this.FindAndReplace(wordApp, "uyruk", tbUyruk.Text);
                    this.FindAndReplace(wordApp, "pasaport", tbPasaportNo.Text);
                    this.FindAndReplace(wordApp, "dogumtarihi", tbDogumTarihi.Text);
                    this.FindAndReplace(wordApp, "unvanı", cbUnvan.Text);

                }
                else
                {
                    MessageBox.Show("File not Found!");
                }

                //Save as
                myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing);

                myWordDoc.Close();
                wordApp.Quit();
                MessageBox.Show("Dosya Oluşturuldu!");
            }
            catch (Exception r)
            {

                MessageBox.Show(r.Message);
            }
           

        }

        private void CreateEnglishContractDocument(object filename, object SaveAs)
        {
            try
            {
                Word.Application wordApp = new Word.Application();
                object missing = Missing.Value;
                Word.Document myWordDoc = null;

                if (File.Exists((string)filename))
                {
                    object readOnly = false;
                    object isVisible = false;
                    wordApp.Visible = false;

                    myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing, ref missing);
                    myWordDoc.Activate();

                    //find and replace
                    this.FindAndReplace(wordApp, "FirmaUnvani", cbUnvan.Text);
                    this.FindAndReplace(wordApp, "FirmaAdresAlani", tbAdres.Text);
                    this.FindAndReplace(wordApp, "adsoyadAlani", tbAdSoyad.Text);
                    this.FindAndReplace(wordApp, "pasaportnoAlani", tbPasaportNo.Text);
                    this.FindAndReplace(wordApp, "dogumyılıAlani", tbDogumTarihi.Text);
                    this.FindAndReplace(wordApp, "DogumyeriAlani", tbDogumYeri.Text);
                    this.FindAndReplace(wordApp, "adresAlani", tbYurtdisiAdres.Text);
                    this.FindAndReplace(wordApp, "ucretTurari", tbUcret.Text);
                    this.FindAndReplace(wordApp, "tarihAlani ", dateTimePicker1.Value.ToShortDateString());

                }
                else
                {
                    MessageBox.Show("File not Found!");
                }

                //Save as
                myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing);

                myWordDoc.Close();
                wordApp.Quit();
                MessageBox.Show("Dosya Oluşturuldu!");
            }
            catch (Exception r)
            {

                MessageBox.Show(r.Message);
            }


        }
        private void CreateContractDocument(object filename, object SaveAs)
        {
            try
            {
                Word.Application wordApp = new Word.Application();
                object missing = Missing.Value;
                Word.Document myWordDoc = null;

                if (File.Exists((string)filename))
                {
                    object readOnly = false;
                    object isVisible = false;
                    wordApp.Visible = false;

                    myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing, ref missing);
                    myWordDoc.Activate();

                    //find and replace
                    this.FindAndReplace(wordApp, "FirmaUnvani", cbUnvan.Text);
                    this.FindAndReplace(wordApp, "FirmaAdresAlani", tbAdres.Text);
                    this.FindAndReplace(wordApp, "FirmaTelefon", tbTelefonEposta.Text);
                    this.FindAndReplace(wordApp, "adSoyadAlani", tbAdSoyad.Text);
                    this.FindAndReplace(wordApp, "babaAdSoyadAlani", tbBabaAdi.Text);
                    this.FindAndReplace(wordApp, "uyrukAlani", tbUyruk.Text);
                    this.FindAndReplace(wordApp, "pasaportNo", tbPasaportNo.Text);
                    this.FindAndReplace(wordApp, "dogumTarihiAlani", tbDogumTarihi.Text);
                    this.FindAndReplace(wordApp, "dogumYeriAlani", tbDogumYeri.Text);
                    this.FindAndReplace(wordApp, "yurtDisiAdres", tbYurtdisiAdres.Text);
                    this.FindAndReplace(wordApp, "ucretAlani", tbUcret.Text);

                }
                else
                {
                    MessageBox.Show("Hedef Dosya Bulunamadı! Lütfen masaüstünde bulunan klasöre sözleşme dosyasını eklediğinizden emin olun.");
                }

                //Save as
                myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing);

                myWordDoc.Close();
                wordApp.Quit();
                MessageBox.Show("Dosya Oluşturuldu!");
            }
            catch (Exception r)
            {

                MessageBox.Show(r.Message);
            }
        }




        private void btnSozlesme_Click(object sender, EventArgs e)
        {
            try
            {
               string dosyaAdi = Interaction.InputBox("Lütfen Sözleşmeye Bir İsim Veriniz!", "Sözleşme Adı", "Örn: Sozlesmeİsmi", 250, 250);
               CreateContractDocument(@"C:\Users\yunus\Desktop\Evraklar\sozlesme.doc", @"C:\Users\yunus\Desktop\OlusturulanEvraklar\y" + dosyaAdi);
            }
            catch (Exception r)
            {

                MessageBox.Show(r.Message);
            }
        }



        private void btnIngSozlesme_Click(object sender, EventArgs e)
        {
            try
            {
                string dosyaAdi = Interaction.InputBox("Lütfen Sözleşmeye Bir İsim Veriniz!", "Sözleşme Adı", "Örn: IngilizceSozlesme", 150, 150);
                CreateEnglishContractDocument(@"C:\Users\yunus\Desktop\Evraklar\ingilizcesozlesme.doc", @"C:\Users\yunus\Desktop\OlusturulanEvraklar\" + dosyaAdi);
            }
            catch (Exception r)
            {

                MessageBox.Show(r.Message);
            }
        }

        private void btnDavetiye_Click(object sender, EventArgs e)
        {
            try
            {
                string dosyaAdi = Interaction.InputBox("Lütfen Sözleşmeye Bir İsim Veriniz!", "Sözleşme Adı", "Örn: Davetiyeİsmi", 250, 250);
                CreateInvitationDocument(@"C:\Users\yunus\Desktop\Evraklar\davetiye.doc", @"C:\Users\yunus\Desktop\" + dosyaAdi);
            }
            catch (Exception r)
            {

                MessageBox.Show(r.Message);
            }
        }
    }
}



/*
 * 
 * 
 * 
 * 
  private void yazdır()
    {
        PrintDialog printDialog1 = new PrintDialog();

        if (printDialog1.ShowDialog() == true)
        {
            ProcessStartInfo info2 = new ProcessStartInfo(filename);
            info2.Verb = "Print";
            info2.CreateNoWindow = true;
            info2.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(info2);
        }
    }




    */



/*

                this.FindAndReplace(wordApp, "temsilcilik", cbTemsilcilik.Text);
                this.FindAndReplace(wordApp, "adres", tbAdres.Text);
                this.FindAndReplace(wordApp, "adsoyad", tbAdSoyad.Text);
                this.FindAndReplace(wordApp, "uyruk", tbUyruk.Text);
                this.FindAndReplace(wordApp, "pasaport", tbPasaportNo.Text);
                this.FindAndReplace(wordApp, "dogumtarihi", tbDogumTarihi.Text);
                this.FindAndReplace(wordApp, "unvanı", cbUnvan.Text);

 */
