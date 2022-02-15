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
    public partial class Admin : Form
    {
        string UKorisnik;
        public Admin(string Korisnik)
        {
            InitializeComponent();
            UKorisnik = Korisnik;
            lblInfo.Text = "Trenutno je registrovano " + Clanovi() + " članova.";
            tBoxPocetniNovac.Text = UzmiPocetniNovac();
        }

        private void pBoxIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string UzmiPocetniNovac()
        {
            StreamReader sr = new StreamReader(@"Aplikacija\PocetniNovac.txt");
            string PN = sr.ReadLine();
            sr.Close();
            return PN;
        }

        private bool ProveraKorisnika(string Korisnik)
        {
            string Ime = @"Aplikacija\Korisnici\" + tBoxUsername.Text + ".txt";
            bool Postoji = File.Exists(Ime) ? true : false;
            return Postoji;
        }

        public int Clanovi()
        {
            StreamReader sr = new StreamReader(@"Aplikacija\BrojClanova.txt");
            int BrClanova = Convert.ToInt32(sr.ReadLine());
            sr.Close();
            return BrClanova;
        }

        string OtvorenKorisnik;

        private void btnOtvori_Click(object sender, EventArgs e)
        {
            OtvorenKorisnik = tBoxUsername.Text;
            if (ProveraKorisnika(OtvorenKorisnik))
            {
                rBoxKorisnik.Text = "";
                StreamReader sr = new StreamReader(@"Aplikacija\Korisnici\" + OtvorenKorisnik + ".txt");
                while (!sr.EndOfStream)
                {
                    rBoxKorisnik.Text += sr.ReadLine() + "\n";
                }
                sr.Close();
                tBoxUsername.ReadOnly = true;
            }
            else
            {
                MBox mbox = new MBox("Korisničko ime ne postoji!", "GREŠKA");
                mbox.Show();
            }
            
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ProveraKorisnika(OtvorenKorisnik))
            {
                StreamWriter sw = new StreamWriter(@"Aplikacija\Korisnici\" + OtvorenKorisnik + ".txt");
                for (int i = 0; i < rBoxKorisnik.Lines.Length; i++)
                {
                    sw.WriteLine(rBoxKorisnik.Lines[i]);
                }
                sw.Flush();
                sw.Close();
                tBoxUsername.ReadOnly = false;
                tBoxUsername.Text = ""; rBoxKorisnik.Text = "";
            }
            else
            {
                MBox mbox = new MBox("Korisničko ime ne postoji!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            Pocetna pc1 = new Pocetna(UKorisnik);
            this.Hide();
            pc1.Show();
        }

        private void tBoxPocetniNovac_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tBoxPocetniNovac.Text, "[^0-9]"))
            {
                MBox mbox = new MBox("Molimo Vas unesite samo brojeve!", "GREŠKA");
                mbox.Show();
                tBoxPocetniNovac.Text = tBoxPocetniNovac.Text.Remove(tBoxPocetniNovac.Text.Length - 1);
            }
        }

        private void btnSacuvajPN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBoxPocetniNovac.Text))
            {
                MBox mbox = new MBox("Molimo Vas unesite početni novac!", "GREŠKA");
                mbox.Show();
                return;
            }
            int PN = Convert.ToInt32(tBoxPocetniNovac.Text);
            StreamWriter sw = new StreamWriter(@"Aplikacija\PocetniNovac.txt");
            sw.WriteLine(PN);
            sw.Flush();
            sw.Close();
        }
    }
}
