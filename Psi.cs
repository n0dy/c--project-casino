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
    public partial class Psi : Form
    {
        Korisnik UlogovanKorisnik = new Korisnik("Default");
        string UKorisnik;
        int SumaNaRacunu, Ulozeno = 0, Dobitak = 0;
        Random r = new Random();
        int Kvota1 = 0, Kvota2 = 0, Kvota3 = 0, Kvota4 = 0, Pobednik = 0, PPobednik;
        bool TrkaPsa = false, PobedioPas = false;
        public Psi(string Korisnik)
        {
            InitializeComponent();
            UKorisnik = Korisnik;
            UlogovanKorisnik = new Korisnik(UKorisnik);
            SumaNaRacunu = UlogovanKorisnik.UzmiStanjeNaRacunu(UKorisnik);
            lblPsiStanje.Text += " " + SumaNaRacunu + "€";
            Kvota1 = r.Next(2, 10); Kvota2 = r.Next(2, 10); Kvota3 = r.Next(2, 10); Kvota4 = r.Next(2, 10);
            lblPas1.Text = Kvota1.ToString(); lblPas2.Text = Kvota2.ToString(); lblPas3.Text = Kvota3.ToString(); lblPas4.Text = Kvota4.ToString();
        }


        private void pBoxIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            if (TrkaPsa)
            {
                MBox mbox = new MBox("U toku je trka!", "GREŠKA");
                mbox.Show(); return;
            }
            Pocetna pc1 = new Pocetna(UKorisnik);
            this.Hide();
            pc1.Show();
        }

        private void btnZapocni_Click(object sender, EventArgs e)
        {
            if (TrkaPsa)
            {
                MBox mbox = new MBox("U toku je trka!", "GREŠKA");
                mbox.Show(); return;
            }
            if (string.IsNullOrEmpty(tBoxUlog.Text) || string.IsNullOrEmpty(tBoxPas.Text))
            {
                MBox mbox = new MBox("Molimo Vas unesite sva polja!", "GREŠKA");
                mbox.Show();
                return;
            }
            int Ulozeno2 = Convert.ToInt32(tBoxUlog.Text);
            if (Ulozeno2 > SumaNaRacunu)
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
            PPobednik = Convert.ToInt32(tBoxPas.Text);
            Ulozeno = Ulozeno2;
            lblPsiUlozeno.Text = "Uloženo: " + Ulozeno + "€";
            SumaNaRacunu -= Ulozeno;
            lblPsiStanje.Text = "Stanje na računu: " + SumaNaRacunu + "€";
            TrkaPsa = true;
            TimerPas1.Interval = r.Next(100,Kvota1*100);
            TimerPas1.Start();
            TimerPas2.Interval = r.Next(100, Kvota1 * 100);
            TimerPas2.Start();
            TimerPas3.Interval = r.Next(100, Kvota1 * 100);
            TimerPas3.Start();
            TimerPas4.Interval = r.Next(100, Kvota1 * 100);
            TimerPas4.Start();
        }

        private void Izracunavanje()
        {
            int Kvota = 0;
            switch(Pobednik)
            {
                case 1:
                    Kvota = Kvota1;
                    break;
                case 2:
                    Kvota = Kvota2;
                    break;
                case 3:
                    Kvota = Kvota3;
                    break;
                case 4:
                    Kvota = Kvota4;
                    break;
                default:
                    break;
            }
            if(Pobednik == PPobednik)
            {
                Dobitak = Kvota * Ulozeno;
                SumaNaRacunu += Dobitak;
                lblPsiDobitak.Text = "Dobitak: " + Dobitak + "€";
                lblPsiStanje.Text = "Stanje na računu: " + SumaNaRacunu + "€";
                lblDobitak.Visible = true;
                lblDobitak.Text = "DOBILI STE!!!";
            }
            else
            {
                lblDobitak.Visible = true;
                lblDobitak.Text = "NISTE DOBILI!!!";
            }
            SacuvajKorisnika(UKorisnik);
            TimerVracanje.Start();
        }

        private void TimerPas1_Tick(object sender, EventArgs e)
        {
            if (!PobedioPas && pBoxPas1.Location.X <= 623 - 20)
            {
                pBoxPas1.Left += 40;
                if (pBoxPas1.Location.X >= 623 - 60)
                {
                    TimerPas1.Stop();
                    TimerPas2.Stop();
                    TimerPas3.Stop();
                    TimerPas4.Stop(); 
                    PobedioPas = false;
                    Pobednik = 1;
                    Izracunavanje();
                }
            }
        }

        private void TimerPas2_Tick(object sender, EventArgs e)
        {
            if (!PobedioPas && pBoxPas2.Location.X <= 623 - 20)
            {
                pBoxPas2.Left += 40;
                if (pBoxPas2.Location.X >= 623 - 60)
                {
                    TimerPas1.Stop();
                    TimerPas2.Stop();
                    TimerPas3.Stop();
                    TimerPas4.Stop(); 
                    PobedioPas = false;
                    Pobednik = 2;
                    Izracunavanje();
                }
            }
        }

        private void TimerPas3_Tick(object sender, EventArgs e)
        {
            if (!PobedioPas && pBoxPas3.Location.X <= 623-20)
            {
                pBoxPas3.Left += 40;
                if (pBoxPas3.Location.X >= 623 - 60)
                {
                    TimerPas1.Stop();
                    TimerPas2.Stop();
                    TimerPas3.Stop();
                    TimerPas4.Stop(); 
                    PobedioPas = false;
                    Pobednik = 3;
                    Izracunavanje();
                }
            }
        }

        private void TimerPas4_Tick(object sender, EventArgs e)
        {
            if (!PobedioPas && pBoxPas4.Location.X <= 623 - 20)
            {
                pBoxPas4.Left += 40;
                if (pBoxPas4.Location.X >= 623 - 60)
                {
                    TimerPas1.Stop();
                    TimerPas2.Stop();
                    TimerPas3.Stop();
                    TimerPas4.Stop(); 
                    PobedioPas = false;
                    Pobednik = 4;
                    Izracunavanje();
                }
            }
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

        private void TimerVracanje_Tick(object sender, EventArgs e)
        {
            Kvota1 = r.Next(2, 10); Kvota2 = r.Next(2, 10); Kvota3 = r.Next(2, 10); Kvota4 = r.Next(2, 10);
            lblPas1.Text = Kvota1.ToString(); lblPas2.Text = Kvota2.ToString(); lblPas3.Text = Kvota3.ToString(); lblPas4.Text = Kvota4.ToString();
            pBoxPas1.Location = new Point(15, 210);
            pBoxPas2.Location = new Point(15, 260);
            pBoxPas3.Location = new Point(15, 310);
            pBoxPas4.Location = new Point(15, 360);
            Ulozeno = Dobitak = 0;
            lblDobitak.Visible = false;
            lblPsiUlozeno.Text = "Uloženo: " + Ulozeno + "€";
            lblPsiDobitak.Text = "Dobitak: " + Dobitak + "€";
            TrkaPsa = false; tBoxUlog.Text = "";
            TimerVracanje.Stop();
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

        private void tBoxPas_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tBoxPas.Text, "[^1-4]"))
            {
                MBox mbox = new MBox("Molimo Vas unesite samo brojeve od 1 do 4!", "GREŠKA");
                mbox.Show();
                tBoxPas.Text = tBoxPas.Text.Remove(tBoxPas.Text.Length - 1);
            }
        }

    }
}
