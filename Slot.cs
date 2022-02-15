using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Kladionica
{
    public partial class Slot : Form
    {
        Korisnik UlogovanKorisnik = new Korisnik("Default");
        string UKorisnik;
        int SumaNaRacunu, Ulozeno = 0, Dobitak = 0;
        Random r = new Random();
        Color [] Boje = new Color[3] { Color.White, Color.Black, Color.Gray };
        bool IzvlacenjeBroja = false;
        public Slot(string Korisnik)
        {
            InitializeComponent();
            UKorisnik = Korisnik;
            UlogovanKorisnik = new Korisnik(UKorisnik);
            SumaNaRacunu = UlogovanKorisnik.UzmiStanjeNaRacunu(UKorisnik);
            lblSlotStanje.Text += " " + SumaNaRacunu + "€";
        }

        private void pBoxIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            Pocetna pc1 = new Pocetna(UKorisnik);
            this.Hide();
            pc1.Show();
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            if(IzvlacenjeBroja)
            {
                MBox mbox = new MBox("Molimo Vas sačekajte!", "GREŠKA");
                mbox.Show();
                return;
            }
            if (string.IsNullOrEmpty(tBoxUlog.Text))
            {
                MBox mbox = new MBox("Molimo Vas unesite ulog!", "GREŠKA");
                mbox.Show();
                return;
            }
            int Ulozeno2 = Convert.ToInt32(tBoxUlog.Text);
            if(Ulozeno2 > SumaNaRacunu)
            {
                MBox mbox = new MBox("Nemate toliko novca!", "GREŠKA");
                mbox.Show();
                return;
            }
            if (Ulozeno2 == 0)
            {
                MBox mbox = new MBox("Ne možete uložiti 0€!", "GREŠKA");
                mbox.Show();
                return;
            }
            Ulozeno = Ulozeno2;
            lblSlotUlozeno.Text = "Uloženo: " + Ulozeno + "€";
            SumaNaRacunu -= Ulozeno;
            lblSlotStanje.Text = "Stanje na računu: " + SumaNaRacunu + "€";
            TimerSlotUkupan.Interval = r.Next(2000, 6000);
            TimerSlotUkupan.Start();
            TimerSlot.Start();
            IzvlacenjeBroja = true;
        }

        private void TimerSlot_Tick(object sender, EventArgs e)
        {
            pBox1.BackColor = Boje[r.Next(0, 3)];
            pBox2.BackColor = Boje[r.Next(0, 3)];
            pBox3.BackColor = Boje[r.Next(0, 3)];
        }

        private void TimerSlotUkupan_Tick(object sender, EventArgs e)
        {
            TimerSlot.Stop();
            if (pBox1.BackColor == pBox2.BackColor && pBox3.BackColor == pBox2.BackColor)
            {
                Dobitak = Ulozeno * 3;
                SumaNaRacunu += Dobitak;
                lblDobitak.Visible = true;
                lblDobitak.Text = "DOBILI STE!!!";
            }
            else
            {
                lblDobitak.Visible = true;
                lblDobitak.Text = "NISTE DOBILI!!!";
            }
            SacuvajKorisnika(UKorisnik);
            IzvlacenjeBroja = false;
            TimerVracanje.Start();
            TimerSlotUkupan.Stop();
        }
        public void SacuvajKorisnika(string Korisnik)
        {
            string Ime = UlogovanKorisnik.UzmiIme(UKorisnik), Prezime = UlogovanKorisnik.UzmiPrezime(UKorisnik), RazlogBana = UlogovanKorisnik.RazlogBana(UKorisnik), Password = UlogovanKorisnik.UzmiPassword(UKorisnik);
            int Grupa = UlogovanKorisnik.UzmiGrupu(UKorisnik), BrojClanstva = UlogovanKorisnik.UzmiBrojClanstva(UKorisnik), StanjeNaRacunu = SumaNaRacunu, PinKod = UlogovanKorisnik.UzmiPinKod(UKorisnik), BanovanKorisnik;
            bool Banovan = UlogovanKorisnik.BanovanKorisnik(UKorisnik);
            if (Banovan == true)
            {
                BanovanKorisnik = 1;
            }
            else
            {
                BanovanKorisnik = 0;
            }
            StreamWriter sw = new StreamWriter(@"Aplikacija\Korisnici\" + Korisnik + ".txt", false);
            sw.WriteLine("Ime:" + Ime);
            sw.WriteLine("Prezime:" + Prezime);
            sw.WriteLine("Password:" + Password);
            sw.WriteLine("Grupa:" + Grupa);
            sw.WriteLine("Broj clanstva:" + BrojClanstva);
            sw.WriteLine("Stanje na računu:" + StanjeNaRacunu);
            sw.WriteLine("Pinkod:" + PinKod);
            sw.WriteLine("Banovan: " + BanovanKorisnik);
            sw.WriteLine("Banovan razlog: " + RazlogBana);
            sw.Close();
        }

        private void tBoxUlog_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tBoxUlog.Text, "[^0-9]"))
            {
                MBox mbox = new MBox("Molimo Vas unesite samo brojeve!", "GREŠKA");
                mbox.Show();
                tBoxUlog.Text = tBoxUlog.Text.Remove(tBoxUlog.Text.Length - 1);
            }
        }

        private void TimerVracanja_Tick(object sender, EventArgs e)
        {
            lblSlotDobitak.Text = "Dobitak:";
            lblSlotUlozeno.Text = "Uloženo:";
            lblDobitak.Visible = false;
            tBoxUlog.Text = "";
            TimerVracanje.Stop();
        }
    }
}
