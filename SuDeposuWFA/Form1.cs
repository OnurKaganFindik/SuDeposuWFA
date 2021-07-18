using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuDeposuWFA
{
    public partial class Form1 : Form
    {
        SuDeposu suDeposu = new SuDeposu(100);

        public Form1()
        {

            InitializeComponent();
            suDeposu.Tasti += SuDeposuTasti;
            lblKapasite.Text = suDeposu.Kapasite + "m³";
            SeviyeGuncelle();
        }

        private void SuDeposuTasti(object sender, SuTastiEventArgs e)
        {
            MessageBox.Show($"Depodan {e.TasanMiktar}m3 su taştı.");
        }

        private void SeviyeGuncelle()
        {
            pnlSu.Height = (int)(pnlDepo.Height * suDeposu.DolulukOrani);
            decimal yuzde = 100 * suDeposu.DolulukOrani;
            lblDolulukOrani.Text = string.Format("{0:0.##}%", yuzde);
            lblSuMiktari.Text = string.Format("{0:0.##}m³", suDeposu.SuMiktari);
        }

        private void btnSuEkle_Click(object sender, EventArgs e)
        {
            suDeposu.SuEkle(nudSuMiktari.Value);
            SeviyeGuncelle();
        }
    }
}
