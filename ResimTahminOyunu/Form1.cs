using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResimTahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rb1.Checked = false;
        }
        //butonun aktif olabilmesi herhangi bir radibutton un seçilmesine bağlı

        void BtnAktif(RadioButton radio)
        {
            if (radio.Checked == true)
                btnTahmin.Enabled = true;
        }
        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            BtnAktif(rb1);
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            BtnAktif(rb2);
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            BtnAktif(rb3);
        }
        int tahmin = 0, dogruTahmin = 0;
        private void btnTahmin_Click(object sender, EventArgs e)
        {
            tahmin++;//her denemede tahmin sayısını arttır.
            Random gen = new Random();
            int sayi = gen.Next(1, 4);
            switch (sayi)
            {
                case 1:
                    pbBig.Image = Properties.Resources.image1;
                    if (rb1.Checked)
                    {
                        dogruTahmin++;
                        Tebrik();
                    }
                    break;
                case 2:
                    pbBig.Image = Properties.Resources.image2;
                    if (rb2.Checked)
                    {
                        dogruTahmin++;
                        Tebrik();
                    }
                    break;
                case 3:
                    pbBig.Image = Properties.Resources.image3;
                    if (rb3.Checked)
                    {
                        dogruTahmin++;
                        Tebrik();
                    }
                    break;
            }
        }

        private void Tebrik()
        {
            MessageBox.Show(string.Format("Tebrikler!..\n{0} denemede {1}. doğru tahmininiz.", tahmin, dogruTahmin), "Vuu huuuu");
            pbBig.Image = null;//pb içeriğini temizle
        }

        
    }
}
