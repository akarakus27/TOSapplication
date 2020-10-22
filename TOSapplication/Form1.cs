using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
