using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kladionica
{
    public partial class Pocetna : Form
    {
        Korisnik UlogovanKorisnik = new Korisnik("Default");
        string UKorisnik;
        public Pocetna(string Korisnik)
        {
            InitializeComponent();
            UKorisnik = Korisnik;
            UlogovanKorisnik = new Korisnik(Korisnik);
            UlogovanKorisnik.UzmiKorisničkeInformacije(Korisnik);
            lblDobrodoslica.Text += ", " + UlogovanKorisnik.UzmiKorisnickoImeiPrezime(Korisnik) + "!";
            lblInfo.Text = "Vaše članstvo: " + UlogovanKorisnik.ImeGrupe(Korisnik) + "\n Stanje na računu: " + UlogovanKorisnik.UzmiStanjeNaRacunu(Korisnik) + "€" + "\n Broj članstva: " + UlogovanKorisnik.UzmiBrojClanstva(Korisnik);
            if(UlogovanKorisnik.ImeGrupe(Korisnik) == "Administrator")
            {
                btnAdmin.Visible = true;
            }
        }

        private void pBoxIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void btnRulet_Click(object sender, EventArgs e)
        {
            if(UlogovanKorisnik.UzmiStanjeNaRacunu(UKorisnik) == 0)
            {
                lblInfo2.Text = "Ne možete ući na rulet jer nemate para!";
                lblInfo2.Visible = true;
                TimerGasenja.Start();
            }
            else
            {
                Rulet rulet = new Rulet(UKorisnik);
                this.Hide();
                rulet.Show();
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MBox Info = new MBox("Program by Dino Bata - Nikola Jovović", "INFO");
            Info.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(UKorisnik);
            this.Hide();
            admin.Show();
        }

        private void btnPodesavanja_Click(object sender, EventArgs e)
        {
            PodesavanjeKorisnika pkorisnika = new PodesavanjeKorisnika(UKorisnik);
            this.Hide();
            pkorisnika.Show();
        }

        private void TimerGasenja_Tick(object sender, EventArgs e)
        {
            lblInfo2.Visible = false;
            lblInfo2.Text = "";
        }

        private void btnSlot_Click(object sender, EventArgs e)
        {
            if (UlogovanKorisnik.UzmiStanjeNaRacunu(UKorisnik) == 0)
            {
                lblInfo2.Text = "Ne možete ući na slot jer nemate para!";
                lblInfo2.Visible = true;
                TimerGasenja.Start();
            }
            else
            {
                Slot slot = new Slot(UKorisnik);
                this.Hide();
                slot.Show();
            }
        }

        private void btnUtakmice_Click(object sender, EventArgs e)
        {
            if (UlogovanKorisnik.UzmiStanjeNaRacunu(UKorisnik) == 0)
            {
                lblInfo2.Text = "Ne možete ući na utakmice jer nemate para!";
                lblInfo2.Visible = true;
                TimerGasenja.Start();
            }
            else
            {
                Utakmice utakmice = new Utakmice(UKorisnik);
                this.Hide();
                utakmice.Show();
            }
        }

        private void btnPsi_Click(object sender, EventArgs e)
        {
            if (UlogovanKorisnik.UzmiStanjeNaRacunu(UKorisnik) == 0)
            {
                lblInfo2.Text = "Ne možete ući na trku psa jer nemate para!";
                lblInfo2.Visible = true;
                TimerGasenja.Start();
            }
            else
            {
                Psi psi = new Psi(UKorisnik);
                this.Hide();
                psi.Show();
            }
        }
    }
}
