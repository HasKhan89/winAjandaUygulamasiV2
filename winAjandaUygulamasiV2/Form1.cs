using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winAjandaUygulamasiV2
{
    public partial class Form1 : Form
    {
        List<Toplanti> Toplantilar = new List<Toplanti>();  // = null;
        List<Bulusma> Bulusmalar = new List<Bulusma>();
        List<Gorev> Gorevler = new List<Gorev>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Toplantilar = new List<Toplanti>();
            //Bulusmalar = new List<Bulusma>();
            //Gorevler = new List<Gorev>();

            OrnekVeriUret();    // CTRL + R + M
            ListboxYukle();
        }

        private void ListboxYukle()
        {
            lstEtkinlikler.Items.Clear();

            foreach (Toplanti toplanti in Toplantilar)
            {
                lstEtkinlikler.Items.Add(toplanti);
            }

            foreach (Bulusma bulusma in Bulusmalar)
            {
                lstEtkinlikler.Items.Add(bulusma);
            }

            foreach (Gorev gorev in Gorevler)
            {
                lstEtkinlikler.Items.Add(gorev);
            }
        }

        private void OrnekVeriUret()
        {
            Random rnd = new Random();

            for (int i = 0; i < rnd.Next(1, 5); i++)
            {
                Toplanti toplanti = new Toplanti();
                toplanti.BaslangicTar = DateTime.Now.AddDays(i);
                toplanti.BitisTar = toplanti.BaslangicTar.AddHours(2);
                toplanti.Konu = "Konu-" + i.ToString();
                toplanti.Mesaj = "Mesaj-" + i.ToString();

                Toplantilar.Add(toplanti);
            }

            for (int i = 0; i < rnd.Next(1, 5); i++)
            {
                Bulusma bulusma = new Bulusma();
                bulusma.BulusmaTar = DateTime.Now.AddDays(i);
                bulusma.Not = "Buluşma notu-" + i.ToString();
                bulusma.Katilimcilar = "Katilimci-" + i.ToString();

                Bulusmalar.Add(bulusma);
            }

            for (int i = 0; i < rnd.Next(1, 5); i++)
            {
                Gorev gorev = new Gorev();
                gorev.GorevTar = DateTime.Now.AddMonths(i);
                gorev.Konu = "Görev Konu - " + i.ToString();
                gorev.YapildiMi = (i % 2 == 0) ? true : false;

                Gorevler.Add(gorev);
            }
        }

        private void mnuYeniToplanti_Click(object sender, EventArgs e)
        {
            ToplatiFormu toplatiFormu = new ToplatiFormu();
            toplatiFormu.ShowDialog();

            Toplanti toplanti = toplatiFormu.ToplantiNesnesi;
            Toplantilar.Add(toplanti);

            ListboxYukle();
        }

        private void mnuYeniBulusma_Click(object sender, EventArgs e)
        {
            BulusmaFormu bulusmaFormu = new BulusmaFormu();
            bulusmaFormu.Durum = true;
            bulusmaFormu.ShowDialog();

            Bulusma bulusma = bulusmaFormu.BulusmaNesnesi;
            Bulusmalar.Add(bulusma);

            ListboxYukle();
        }

        private void mnuYeniGorev_Click(object sender, EventArgs e)
        {
            GorevFormu gorevFormu = new GorevFormu();
            gorevFormu.ShowDialog();

            Gorev gorev = gorevFormu.GorevNesnesi;
            Gorevler.Add(gorev);

            ListboxYukle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(lstEtkinlikler.SelectedItem is Bulusma)
            {
                Bulusma secilenBulusma = (Bulusma)lstEtkinlikler.SelectedItem;
                Bulusmalar.Remove(secilenBulusma);
            }
            else if (lstEtkinlikler.SelectedItem is Toplanti)
            {
                Toplanti secilenToplanti = (Toplanti)lstEtkinlikler.SelectedItem;
                Toplantilar.Remove(secilenToplanti);
            }
            else if (lstEtkinlikler.SelectedItem is Gorev)
            {
                Gorev secilenGorev = (Gorev)lstEtkinlikler.SelectedItem;
                Gorevler.Remove(secilenGorev);
            }

            ListboxYukle();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (lstEtkinlikler.SelectedItem is Bulusma)
            {
                Bulusma secilenBulusma = (Bulusma)lstEtkinlikler.SelectedItem;

                BulusmaFormu bulusmaFormu = new BulusmaFormu();
                bulusmaFormu.BulusmaNesnesi = secilenBulusma;   // listbox'dan seçilen nesne verildi.
                bulusmaFormu.Durum = false; // düzenleme modunda açma..
                bulusmaFormu.ShowDialog();
            }
            else if (lstEtkinlikler.SelectedItem is Toplanti)
            {
                Toplanti secilenToplanti = (Toplanti)lstEtkinlikler.SelectedItem;
            }
            else if (lstEtkinlikler.SelectedItem is Gorev)
            {
                Gorev secilenGorev = (Gorev)lstEtkinlikler.SelectedItem;
            }

            ListboxYukle();
        }
    }
}
