using System;
using System.Windows.Forms;

namespace CariHesapTakibi
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void btn_CariHesaplar_Click(object sender, EventArgs e)
        {
            Navigation.Show(typeof(CariHesapListe));
        }
        private void btn_HesapHareketleri_Click(object sender, EventArgs e)
        {
            Navigation.Show(typeof(HesapHareketListe));
        }
        private void btn_CariGrup_Click(object sender, EventArgs e)
        {
            Navigation.Show(typeof(GrupListe));
        }
        private void btn_Raporlar_Click(object sender, EventArgs e)
        {
            Navigation.Show(typeof(Raporlar));
        }
        private void btn_Yedekler_Click(object sender, EventArgs e)
        {
            Navigation.Show(typeof(Yedekler));
        }
    }
}
