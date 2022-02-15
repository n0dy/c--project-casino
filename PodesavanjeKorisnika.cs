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
    public partial class PodesavanjeKorisnika : Form
    {
        Korisnik UlogovanKorisnik = new Korisnik("Default");
        string UKorisnik;
        public PodesavanjeKorisnika(string Korisnik)
        {
            InitializeComponent();
            UKorisnik = Korisnik;
            UlogovanKorisnik = new Korisnik(UKorisnik);
            tBoxUsername.Text = UKorisnik;
            tBoxIme.Text = UlogovanKorisnik.UzmiIme(UKorisnik);
            tBoxPrezime.Text = UlogovanKorisnik.UzmiPrezime(UKorisnik);
        }

        private void pBoxIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            Pocetna pc1 = new Pocetna(tBoxUsername.Text);
            this.Hide();
            pc1.Show();
        }

        public void SacuvajKorisnika(string Korisnik, string Password)
        {
            string Ime = UlogovanKorisnik.UzmiIme(UKorisnik), Prezime = UlogovanKorisnik.UzmiPrezime(UKorisnik);
            int Grupa = UlogovanKorisnik.UzmiGrupu(UKorisnik), BrojClanstva = UlogovanKorisnik.UzmiBrojClanstva(UKorisnik), StanjeNaRacunu = UlogovanKorisnik.UzmiStanjeNaRacunu(UKorisnik), PinKod = UlogovanKorisnik.UzmiPinKod(UKorisnik);
            StreamWriter sw = new StreamWriter(@"Aplikacija\Korisnici\" + Korisnik + ".txt", false);
            sw.WriteLine("Ime:" + Ime);
            sw.WriteLine("Prezime:" + Prezime);
            sw.WriteLine("Password:" + Password);
            sw.WriteLine("Grupa:" + Grupa);
            sw.WriteLine("Broj clanstva:" + BrojClanstva);
            sw.WriteLine("Stanje na računu:" + StanjeNaRacunu);
            sw.WriteLine("Pinkod:" + PinKod);
            sw.Close();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBoxPinKod.Text))
            {
                MBox mbox = new MBox("Sva polja moraju biti popunjena!", "GREŠKA");
                mbox.Show(); return;
            }
            int PinKod = Convert.ToInt32(tBoxPinKod.Text);
            string Password = tBoxLozinka.Text;
            if (string.IsNullOrEmpty(tBoxLozinka.Text))
            {
                MBox mbox = new MBox("Sva polja moraju biti popunjena!", "GREŠKA");
                mbox.Show(); return;
            }
            if (tBoxLozinka.TextLength < 3)
            {
                MBox mbox = new MBox("Password mora imati više od tri karaktera!", "GREŠKA");
                mbox.Show(); return;
            }
            if(PinKod != UlogovanKorisnik.UzmiPinKod(UKorisnik))
            {
                MBox mbox = new MBox("Niste uneli dobar PinKod!", "GREŠKA");
                mbox.Show(); return;
            }
            SacuvajKorisnika(UKorisnik, Password);
            lblInfo.Visible = true;
            lblInfo.Text = "Uspešno ste promenili vašu lozinku!";
        }
    }
}
