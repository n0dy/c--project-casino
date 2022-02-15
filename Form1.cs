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
    public partial class Form1 : Form
    {
        bool ZaboravljenaLozinka = false;

        public Form1()
        {
            InitializeComponent();
        }

        private bool ProveraKorisnika(string Korisnik)
        {
            string Ime = @"Aplikacija\Korisnici\" + tBoxUsername.Text + ".txt";
            bool Postoji = File.Exists(Ime) ? true : false;
            return Postoji;
        }

        private void pBoxIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string Korisnik = tBoxUsername.Text;
            if (string.IsNullOrEmpty(tBoxUsername.Text) || string.IsNullOrEmpty(tBoxPassword.Text))
            {
                MBox mbox = new MBox("Molimo Vas unesite Username i Password!", "GREŠKA");
                mbox.Show();
                return;
            }
            if (ProveraKorisnika(tBoxUsername.Text))
            {
                Korisnik korisnik = new Korisnik(Korisnik);
                if (korisnik.UzmiPassword(Korisnik) == tBoxPassword.Text)
                {
                    if (korisnik.BanovanKorisnik(Korisnik) == true)
                    {
                        MBox mbox = new MBox("Banovani ste, razlog: " + korisnik.RazlogBana(Korisnik) + "!", "GREŠKA");
                        mbox.Show();
                    }
                    else
                    {
                        Pocetna pc1 = new Pocetna(Korisnik);
                        this.Hide();
                        pc1.Show();
                    }
                }
                else
                {
                    MBox mbox = new MBox("Pogrešna lozinka!", "GREŠKA");
                    mbox.Show();
                }
            }
            else
            {
                MBox mbox = new MBox("Korisničko ime ne postoji!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            Registracija reg1 = new Registracija();
            this.Hide();
            reg1.Show();
        }

        private void btnZaboravljenaLozinka_Click(object sender, EventArgs e)
        {
            if(ZaboravljenaLozinka == false)
            {
                tBoxPinKod.Visible = true;
                lblInfo.Visible = true;
                lblInfo.Text = "Unesite vas PinKod i ponovo kliknite na 'Zaboravljena lozinka?'!";
                tBoxPinKod.Text = "";
                ZaboravljenaLozinka = true;
            }
            else
            {
                if(string.IsNullOrEmpty(tBoxPinKod.Text))
                {
                    MBox mbox = new MBox("Molimo Vas unesite PinKod!", "GREŠKA");
                    mbox.Show();
                    return;
                }
                if (string.IsNullOrEmpty(tBoxUsername.Text))
                {
                    MBox mbox = new MBox("Molimo Vas unesite Username!", "GREŠKA");
                    mbox.Show();
                    return;
                }
                string KorisnikZL = tBoxUsername.Text;
                int PinKod = Convert.ToInt32(tBoxPinKod.Text);
                Korisnik Korisnik = new Korisnik(KorisnikZL);
                if(Korisnik.UzmiPinKod(KorisnikZL) == PinKod)
                {
                    lblInfo.Text = "Lozinka vašeg naloga je: "  + Korisnik.UzmiPassword(KorisnikZL) + " !";
                    TimerGasenja.Start();
                }
                else
                {
                    MBox mbox = new MBox("Nije dobar PinKod!", "GREŠKA");
                    mbox.Show();
                    return;
                }
            }
        }

        private void TimerGasenja_Tick(object sender, EventArgs e)
        {
            tBoxPinKod.Visible = false;
            lblInfo.Visible = false;
            ZaboravljenaLozinka = false;
        }

        private void tBoxPinKod_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tBoxPinKod.Text, "[^0-9]"))
            {
                MBox mbox = new MBox("Molimo Vas unesite samo brojeve!", "GREŠKA");
                mbox.Show();
                tBoxPinKod.Text = tBoxPinKod.Text.Remove(tBoxPinKod.Text.Length - 1);
            }
        }

        private void btnPrijava_Click_1(object sender, EventArgs e)
        {
            string Korisnik = tBoxUsername.Text;
            if (string.IsNullOrEmpty(tBoxUsername.Text) || string.IsNullOrEmpty(tBoxPassword.Text))
            {
                MBox mbox = new MBox("Molimo Vas unesite Username i Password!", "GREŠKA");
                mbox.Show();
                return;
            }
            if (ProveraKorisnika(tBoxUsername.Text))
            {
                Korisnik korisnik = new Korisnik(Korisnik);
                if (korisnik.UzmiPassword(Korisnik) == tBoxPassword.Text)
                {
                    if (korisnik.BanovanKorisnik(Korisnik) == true)
                    {
                        MBox mbox = new MBox("Banovani ste, razlog: " + korisnik.RazlogBana(Korisnik) + "!", "GREŠKA");
                        mbox.Show();
                    }
                    else
                    {
                        Pocetna pc1 = new Pocetna(Korisnik);
                        this.Hide();
                        pc1.Show();
                    }
                }
                else
                {
                    MBox mbox = new MBox("Pogrešna lozinka!", "GREŠKA");
                    mbox.Show();
                }
            }
            else
            {
                MBox mbox = new MBox("Korisničko ime ne postoji!", "GREŠKA");
                mbox.Show();
            }
        }
    }
}
