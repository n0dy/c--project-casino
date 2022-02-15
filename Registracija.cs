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
    public partial class Registracija : Form
    {
        int PinKod, BrClanova;
        public Registracija()
        {
            InitializeComponent();
        }

        private void pBoxIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private bool ProveraKorisnika(string Korisnik)
        {
            string Ime = @"Aplikacija\Korisnici\" + Korisnik + ".txt";
            bool Postoji = File.Exists(Ime) ? true : false;
            return Postoji;
        }

        private string UzmiPocetniNovac()
        {
            StreamReader sr = new StreamReader(@"Aplikacija\PocetniNovac.txt");
            string PN = sr.ReadLine();
            sr.Close();
            return PN;
        }

        public int Clanovi()
        {
            StreamReader sr = new StreamReader(@"Aplikacija\BrojClanova.txt");
            BrClanova = Convert.ToInt32(sr.ReadLine()) + 1;
            sr.Close();
            StreamWriter sw = new StreamWriter(@"Aplikacija\BrojClanova.txt", false);
            sw.WriteLine(BrClanova);
            sw.Close();
            return BrClanova;
        }

        public void SacuvajKorisnika(string Korisnik)
        {
            StreamWriter sw = new StreamWriter(@"Aplikacija\Korisnici\" + Korisnik + ".txt", false);
            sw.WriteLine("Ime:" + tBoxImeR.Text);
            sw.WriteLine("Prezime:" + tBoxPrezimeR.Text);
            sw.WriteLine("Password:" + tBoxPasswordR.Text);
            sw.WriteLine("Grupa:1");
            sw.WriteLine("Broj clanstva:" + Clanovi());
            sw.WriteLine("Stanje na računu:" + UzmiPocetniNovac());
            sw.WriteLine("Pinkod:" + PinKod);
            sw.WriteLine("Banovan: 0");
            sw.WriteLine("Banovan razlog: ");
            sw.Close();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            string KorisnickoIme = tBoxUsernameR.Text;
            if (string.IsNullOrEmpty(tBoxUsernameR.Text) || string.IsNullOrEmpty(tBoxImeR.Text) || string.IsNullOrEmpty(tBoxPrezimeR.Text) || string.IsNullOrEmpty(tBoxPasswordR.Text))
            {
                MBox mbox = new MBox("Sva polja moraju biti popunjena!", "GREŠKA");
                mbox.Show(); return;
            }
            if (ProveraKorisnika(KorisnickoIme))
            {
                MBox mbox = new MBox("Taj nalog već postoji!", "GREŠKA");
                mbox.Show(); return;
            } 
            if (tBoxImeR.TextLength < 3 || tBoxPrezimeR.TextLength < 3 || tBoxPasswordR.TextLength < 3)
            {
                MBox mbox = new MBox("Ime, prezime i password moraju imati više od tri karaktera!", "GREŠKA");
                mbox.Show(); return;
            }
            Random r = new Random();
            PinKod = r.Next(1000, 9999);
            SacuvajKorisnika(tBoxUsernameR.Text);
            lblInfo.Visible = true;
            lblInfo.Text = "Uspešna registracija! Vaš pin kod je " + PinKod + " , zapamtite ga obavezno!";
            TimerGasenja.Start();
        }

        private void TimerGasenja_Tick(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            lblInfo.Text = "";
        }
    }
}
