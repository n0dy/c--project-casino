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
    public partial class Utakmice : Form
    {
        Korisnik UlogovanKorisnik = new Korisnik("Default");
        string UKorisnik;
        int SumaNaRacunu, Ulozeno = 0, Dobitak = 0;
        string[] Timovi1 = new string[3] { "Crvena Zvezda", "FK Vozdovac", "Radnik" }; string[] Timovi2 = new string[3] { "Partizan", "Macva", "Backa" };
        string[] Timovi3 = new string[3] { "Spartak Subotica", "Napredak", "Mladost" }; string[] Timovi4 = new string[3] { "Vojvodina", "Javor", "Borac" };
        Random r = new Random();
        int Kvota1, Kvota2; bool Odigrano = false;
        public Utakmice(string Korisnik)
        {
            InitializeComponent();
            UKorisnik = Korisnik;
            UlogovanKorisnik = new Korisnik(UKorisnik);
            SumaNaRacunu = UlogovanKorisnik.UzmiStanjeNaRacunu(UKorisnik);
            lblUtakmiceStanje.Text += " " + SumaNaRacunu + "€";
            lblU1T1.Text = Timovi1[r.Next(0, 2)];
            lblU1T2.Text = Timovi2[r.Next(0, 2)];
            lblU2T1.Text = Timovi3[r.Next(0, 2)];
            lblU2T2.Text = Timovi4[r.Next(0, 2)];
            Kvota1 = r.Next(2, 20); Kvota2 = r.Next(2,20);
            lblU1K.Text = Kvota1.ToString();
            lblU2K.Text = Kvota2.ToString();
        }

        private void pBoxIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            Pocetna pc1 = new Pocetna(UKorisnik);
            this.Hide();
            pc1.Show();
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

        private void btnKladjenje_Click(object sender, EventArgs e)
        {
            if(Odigrano)
            {
                MBox mbox = new MBox("Molimo Vas sačekajte 5 sekundi!", "GREŠKA");
                mbox.Show();
                return;
            }
            if (!rbU11.Checked && !rbU12.Checked && !rbU1X.Checked || !rbU21.Checked && !rbU22.Checked && !rbU2X.Checked)
            {
                MBox mbox = new MBox("Molimo Vas odaberite rezultat!", "GREŠKA");
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
            Ulozeno = Ulozeno2;
            lblUtakmiceUlozeno.Text = "Uloženo: " + Ulozeno + "€";
            SumaNaRacunu -= Ulozeno;
            int R1, R2, U1 = 0, U2 = 0;
            R1 = r.Next(0, 3); R2 = r.Next(0, 3);
            if (R1 == 0) { lblU1R.Text = "X"; }
            if (R2 == 0){ lblU2R.Text = "X"; }
            if (R1 > 0){ lblU1R.Text = R1.ToString(); }
            if (R2 > 0){ lblU2R.Text = R2.ToString(); }
            if (rbU11.Checked) { U1 = 1; }
            if (rbU12.Checked) { U1 = 2; }
            if (rbU1X.Checked) { U1 = 0; }
            if (rbU21.Checked) { U2 = 1; }
            if (rbU22.Checked) { U2 = 2; }
            if (rbU2X.Checked) { U2 = 0; }
            if(U1 == R1 && U2 == R2)
            {
                Dobitak = Ulozeno * Kvota1 * Kvota2;
                SumaNaRacunu += Dobitak;
                lblUtakmiceDobitak.Text = "Dobitak: " + Dobitak + "€";
                lblDobitak.Visible = true;
                lblDobitak.Text = "DOBILI STE!!!";
            }
            else
            {
                lblDobitak.Visible = true;
                lblDobitak.Text = "NISTE DOBILI!!!";
            }
            lblUtakmiceStanje.Text = "Stanje na računu: " + SumaNaRacunu + "€";
            SacuvajKorisnika(UKorisnik);
            Odigrano = true;
            TimerVracanje.Start();
        }

        private void TimerVracanje_Tick(object sender, EventArgs e)
        {
            lblU1T1.Text = Timovi1[r.Next(0, 2)];
            lblU1T2.Text = Timovi2[r.Next(0, 2)];
            lblU2T1.Text = Timovi3[r.Next(0, 2)];
            lblU2T2.Text = Timovi4[r.Next(0, 2)];
            Kvota1 = r.Next(2, 20); Kvota2 = r.Next(2, 20);
            lblU1K.Text = Kvota1.ToString();
            lblU2K.Text = Kvota2.ToString();
            lblU1R.Text = "-";
            lblU2R.Text = "-";
            lblUtakmiceDobitak.Text = "Dobitak:";
            lblUtakmiceUlozeno.Text = "Uloženo:";
            lblDobitak.Visible = false;
            tBoxUlog.Text = "";
            Odigrano = false;
            TimerVracanje.Stop();
        }
    }
}
