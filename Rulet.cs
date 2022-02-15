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
    public partial class Rulet : Form
    {
        Korisnik UlogovanKorisnik = new Korisnik("Default");
        string UKorisnik;
        int SumaNaRacunu, RuletCip = 1, RuletUlozenoUkupno = 0, RuletDobitak = 0, DobitniBroj = 0;
        int C0 = 0, C1 = 0, C2 = 0, C3 = 0, C4 = 0, C5 = 0, C6 = 0, C7 = 0, C8 = 0, C9 = 0, C10 = 0, C11 = 0, C12 = 0, C13 = 0, C14 = 0, C15 = 0, C16 = 0, C17 = 0, C18 = 0, C19 = 0, C20 = 0, C21 = 0, C22 = 0, C23 = 0, C24 = 0, C25 = 0, C26 = 0, C27 = 0, C28 = 0, C29 = 0, C30 = 0, C31 = 0, C32 = 0, C33 = 0, C34 = 0, C35 = 0, C36 = 0;
        int C1_12 = 0, C13_24 = 0, C25_36 = 0, C3st = 0, C2st = 0, C1st = 0, C1_18 = 0, C19_36 = 0, CEven = 0, COdd = 0, CRed = 0, CBlack = 0;
        bool IzvlacenjeBroja = false, CistaTabla = true;
        public Rulet(string Korisnik)
        {
            InitializeComponent();
            UKorisnik = Korisnik;
            UlogovanKorisnik = new Korisnik(UKorisnik);
            SumaNaRacunu = UlogovanKorisnik.UzmiStanjeNaRacunu(UKorisnik);
            lblRuletStanje.Text += " " + SumaNaRacunu + "€";
        }

        int[] Brojevi = new int[37] { 0, 32, 15, 19, 4, 21, 2, 25, 17, 34, 6, 27, 13, 36, 11, 30, 8, 23, 10, 5, 24, 16, 33, 1, 20, 14, 31, 9, 22, 18, 29, 7, 28, 12, 35, 3, 26 };
        Color[] Boje = new Color[37] { Color.Green, Color.Red, Color.Black, Color.Red, Color.Black, Color.Red, Color.Black, Color.Red, Color.Black, Color.Red, Color.Black, Color.Red, Color.Black, Color.Red, Color.Black, Color.Red, Color.Black, Color.Red, Color.Black, Color.Red, Color.Black, Color.Red, Color.Black, Color.Red, Color.Black, Color.Red, Color.Black, Color.Red, Color.Black, Color.Red, Color.Black, Color.Red, Color.Black, Color.Red, Color.Black, Color.Red, Color.Black };

        private void pBoxIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Rulet_Load(object sender, System.EventArgs e)
        {
            
        }

        private void PostavljanjeCipova()
        {
            C0 = 0; C1 = 0; C2 = 0; C3 = 0; C4 = 0; C5 = 0; C6 = 0; C7 = 0; C8 = 0; C9 = 0; C10 = 0; C11 = 0; C12 = 0; C13 = 0; C14 = 0; C15 = 0; C16 = 0; C17 = 0; C18 = 0; C19 = 0; C20 = 0; C21 = 0; C22 = 0; C23 = 0; C24 = 0; C25 = 0; C26 = 0; C27 = 0; C28 = 0; C29 = 0; C30 = 0; C31 = 0; C32 = 0; C33 = 0; C34 = 0; C35 = 0; C36 = 0;
            C1_12 = 0; C13_24 = 0; C25_36 = 0; C3st = 0; C2st = 0; C1st = 0; C1_18 = 0; C19_36 = 0; CEven = 0; COdd = 0; CRed = 0; CBlack = 0;
            btnRuletRED.Text = "RED"; btnRuletBLACK.Text = "BLACK"; btnRuletEVEN.Text = "EVEN"; btnRuletODD.Text = "ODD";
            btnRuletBR0.Text = "0"; btnRuletBR1.Text = "1"; btnRuletBR2.Text = "2"; btnRuletBR3.Text = "3"; btnRuletBR4.Text = "4"; btnRuletBR5.Text = "5"; btnRuletBR6.Text = "6"; btnRuletBR7.Text = "7"; btnRuletBR8.Text = "8"; btnRuletBR9.Text = "9";
            btnRuletBR10.Text = "10"; btnRuletBR11.Text = "11"; btnRuletBR12.Text = "12"; btnRuletBR13.Text = "13"; btnRuletBR14.Text = "14"; btnRuletBR15.Text = "15"; btnRuletBR16.Text = "16"; btnRuletBR17.Text = "17"; btnRuletBR18.Text = "18"; btnRuletBR19.Text = "19";
            btnRuletBR20.Text = "20"; btnRuletBR21.Text = "21"; btnRuletBR22.Text = "22"; btnRuletBR23.Text = "23"; btnRuletBR24.Text = "24"; btnRuletBR25.Text = "25"; btnRuletBR26.Text = "26"; btnRuletBR27.Text = "27"; btnRuletBR28.Text = "28"; btnRuletBR29.Text = "29";
            btnRuletBR30.Text = "30"; btnRuletBR31.Text = "31"; btnRuletBR32.Text = "32"; btnRuletBR33.Text = "33"; btnRuletBR34.Text = "34"; btnRuletBR35.Text = "35"; btnRuletBR36.Text = "36";
            btnRuletBR1_12.Text = "1 - 12"; btnRuletBR13_24.Text = "13 - 24"; btnRuletBR25_36.Text = "25 - 36"; btnRuletBR3ST.Text = "3st"; btnRuletBR2ST.Text = "2st"; btnRuletBR1ST.Text = "1st"; btnRuletBR1_18.Text = "1 - 18"; btnRuletBR19_36.Text = "19 - 36";
            lblRuletUlozeno.Text = "Uloženo: ";
            lblRuletDobitak.Text = "Dobitak: ";
        }

        private void lblRuletUlog_Click(object sender, EventArgs e)
        {
            if(SumaNaRacunu > RuletCip)
            {
                RuletCip++;
                btnRuletCip.Text = RuletCip.ToString();
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletPonistavanje_Click(object sender, EventArgs e)
        {
            RuletCip = 1; btnRuletCip.Text = "1";
        }

        private bool BrojJeCrven(int Broj)
        {
            int[] CrveniBrojevi = new int[18]{1,3,5,7,9,12,14,16,18,19,21,23,25,27,30,32,34,36};
            for(int i = 0; i < 18; i++)
            {
                if(Broj == CrveniBrojevi[i])
                {
                    return true;
                }
            }
            return false;
        }

        private bool BrojJeCrn(int Broj)
        {
            int[] CrniBrojevi = new int[18] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            for (int i = 0; i < 18; i++)
            {
                if (Broj == CrniBrojevi[i])
                {
                    return true;
                }
            }
            return false;
        }

        private bool Broj3st(int Broj)
        {
            int[] Br3ST = new int[12] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            for (int i = 0; i < 12; i++)
            {
                if (Broj == Br3ST[i])
                {
                    return true;
                }
            }
            return false;
        }

        private bool Broj2st(int Broj)
        {
            int[] Br2ST = new int[12] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            for (int i = 0; i < 12; i++)
            {
                if (Broj == Br2ST[i])
                {
                    return true;
                }
            }
            return false;
        }

        private bool Broj1st(int Broj)
        {
            int[] Br1ST = new int[12] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            for (int i = 0; i < 12; i++)
            {
                if (Broj == Br1ST[i])
                {
                    return true;
                }
            }
            return false;
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

        private void btnRuletBR0_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if(SumaNaRacunu > RuletCip)
            {
                C0 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR0.Text = "0" + "\n(" + C0 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR1_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C1 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR1.Text = "1" + "\n(" + C1 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno;
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR2_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C2 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR2.Text = "2" + "\n(" + C2 + ")";
                lblRuletUlozeno.Text = "Uloženo: " +  + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR3_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C3 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR3.Text = "3" + "\n(" + C3 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR4_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C4 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR4.Text = "4" + "\n(" + C4 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR5_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C5 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR5.Text = "5" + "\n(" + C5 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR6_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C6 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR6.Text = "6" + "\n(" + C6 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR7_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C7 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR7.Text = "7" + "\n(" + C7 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnZavrti_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if(RuletUlozenoUkupno > SumaNaRacunu) // Trenutno rešenje da stanje na računu ne može otići u -
            {
                MBox mbox = new MBox("Ulog ne može biti veći od stanja na računu!", "GREŠKA");
                mbox.Show();
                return;
            }
            if(CistaTabla == false)
            {
                MBox mbox = new MBox("Morate prvo očistiti tablu!", "GREŠKA");
                mbox.Show();
                return;
            }
            Random r = new Random();
            TimerUkupan.Interval = r.Next(1000,7000);
            TimerUkupan.Start();
            TimerBrojeva.Start();
            IzvlacenjeBroja = true;
            SumaNaRacunu -= RuletUlozenoUkupno;
            lblRuletDobitak.Text = "Dobitak:";
            lblRuletStanje.Text = "Stanje na računu: " + SumaNaRacunu + "€";
        }

        private void TimerBrojeva_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            DobitniBroj = r.Next(0, 37);
            btnRuletBroj.Text = Brojevi[DobitniBroj].ToString();
            btnRuletBroj.BackColor = Boje[DobitniBroj];
        }

        private void TimerUkupan_Tick(object sender, EventArgs e)
        {
            DobitniBroj = Convert.ToInt32(btnRuletBroj.Text);
            TimerBrojeva.Stop();
            if(CRed > 0 && BrojJeCrven(DobitniBroj))
            {
                RuletDobitak += CRed * 2;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if(CBlack > 0 && BrojJeCrn(DobitniBroj))
            {
                RuletDobitak += CBlack * 2;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if(C0 > 0 && DobitniBroj == 0)
            {
                RuletDobitak += C0 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C1 > 0 && DobitniBroj == 1)
            {
                RuletDobitak += C1 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C2 > 0 && DobitniBroj == 2)
            {
                RuletDobitak += C2 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C3 > 0 && DobitniBroj == 3)
            {
                RuletDobitak += C3 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C4 > 0 && DobitniBroj == 4)
            {
                RuletDobitak += C4 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C5 > 0 && DobitniBroj == 5)
            {
                RuletDobitak += C5 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C6 > 0 && DobitniBroj == 6)
            {
                RuletDobitak += C6 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C7 > 0 && DobitniBroj == 7)
            {
                RuletDobitak += C7 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C8 > 0 && DobitniBroj == 8)
            {
                RuletDobitak += C8 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C9 > 0 && DobitniBroj == 9)
            {
                RuletDobitak += C9 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C10 > 0 && DobitniBroj == 10)
            {
                RuletDobitak += C10 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C11 > 0 && DobitniBroj == 11)
            {
                RuletDobitak += C11 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C12 > 0 && DobitniBroj == 12)
            {
                RuletDobitak += C12 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C13 > 0 && DobitniBroj == 13)
            {
                RuletDobitak += C13 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C14 > 0 && DobitniBroj == 14)
            {
                RuletDobitak += C14 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C15 > 0 && DobitniBroj == 15)
            {
                RuletDobitak += C15 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C16 > 0 && DobitniBroj == 16)
            {
                RuletDobitak += C16 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C17 > 0 && DobitniBroj == 17)
            {
                RuletDobitak += C17 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C18 > 0 && DobitniBroj == 18)
            {
                RuletDobitak += C18 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C19 > 0 && DobitniBroj == 19)
            {
                RuletDobitak += C19 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C20 > 0 && DobitniBroj == 20)
            {
                RuletDobitak += C20 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C21 > 0 && DobitniBroj == 21)
            {
                RuletDobitak += C21 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C22 > 0 && DobitniBroj == 22)
            {
                RuletDobitak += C22 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C23 > 0 && DobitniBroj == 23)
            {
                RuletDobitak += C23 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C24 > 0 && DobitniBroj == 24)
            {
                RuletDobitak += C24 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C25 > 0 && DobitniBroj == 25)
            {
                RuletDobitak += C25 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C26 > 0 && DobitniBroj == 26)
            {
                RuletDobitak += C26 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C27 > 0 && DobitniBroj == 27)
            {
                RuletDobitak += C27 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C28 > 0 && DobitniBroj == 28)
            {
                RuletDobitak += C28 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C29 > 0 && DobitniBroj == 29)
            {
                RuletDobitak += C29 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C30 > 0 && DobitniBroj == 30)
            {
                RuletDobitak += C30 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C31 > 0 && DobitniBroj == 31)
            {
                RuletDobitak += C31 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C32 > 0 && DobitniBroj == 32)
            {
                RuletDobitak += C32 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C33 > 0 && DobitniBroj == 33)
            {
                RuletDobitak += C33 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C34 > 0 && DobitniBroj == 34)
            {
                RuletDobitak += C34 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C35 > 0 && DobitniBroj == 35)
            {
                RuletDobitak += C35 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C36 > 0 && DobitniBroj == 36)
            {
                RuletDobitak += C36 * 36;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if(C1_12 > 0 && (DobitniBroj >= 1 && DobitniBroj <= 12))
            {
                RuletDobitak += C1_12 * 2;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            
            }
            if (C13_24 > 0 && (DobitniBroj >= 13 && DobitniBroj <= 24))
            {
                RuletDobitak += C13_24 * 2;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C25_36 > 0 && (DobitniBroj >= 25 && DobitniBroj <= 36))
            {
                RuletDobitak += C25_36 * 2;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C1_18 > 0 && (DobitniBroj >= 1 && DobitniBroj <= 18))
            {
                RuletDobitak += C1_18 * 2;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C19_36 > 0 && (DobitniBroj >= 19 && DobitniBroj <= 36))
            {
                RuletDobitak += C19_36 * 2;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if(CEven > 0 && DobitniBroj % 2 == 0)
            {
                RuletDobitak += CEven * 2;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if(COdd > 0 && DobitniBroj % 2 != 0)
            {
                RuletDobitak += COdd * 2;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if(C3st > 0 && Broj3st(DobitniBroj))
            {
                RuletDobitak += C3st * 3;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C2st > 0 && Broj2st(DobitniBroj))
            {
                RuletDobitak += C2st * 3;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            if (C1st > 0 && Broj1st(DobitniBroj))
            {
                RuletDobitak += C1st * 3;
                lblRuletDobitak.Text = "Dobitak: " + RuletDobitak + "€";
            }
            SumaNaRacunu += RuletDobitak;
            RuletDobitak = 0;
            RuletUlozenoUkupno = 0;
            lblRuletStanje.Text = "Stanje na računu: " + SumaNaRacunu + "€";
            IzvlacenjeBroja = false;
            CistaTabla = false;
            SacuvajKorisnika(UKorisnik);
            TimerUkupan.Stop();
        }

        public void SacuvajKorisnika(string Korisnik)
        {
            string Ime = UlogovanKorisnik.UzmiIme(UKorisnik), Prezime = UlogovanKorisnik.UzmiPrezime(UKorisnik), RazlogBana = UlogovanKorisnik.RazlogBana(UKorisnik), Password = UlogovanKorisnik.UzmiPassword(UKorisnik);
            int Grupa = UlogovanKorisnik.UzmiGrupu(UKorisnik), BrojClanstva = UlogovanKorisnik.UzmiBrojClanstva(UKorisnik), StanjeNaRacunu = SumaNaRacunu, PinKod = UlogovanKorisnik.UzmiPinKod(UKorisnik), BanovanKorisnik;
            bool Banovan = UlogovanKorisnik.BanovanKorisnik(UKorisnik);
            if(Banovan == true)
            {
                BanovanKorisnik = 1;
            }
            else {
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

        private void btnRuletRED_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                CRed += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletRED.Text = "RED" + "\n(" + CRed + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBLACK_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                CBlack += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBLACK.Text = "BLACK" + "\n(" + CBlack + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PostavljanjeCipova();
            RuletUlozenoUkupno = 0;
            CistaTabla = true;
        }

        private void btnRuletBR8_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C8 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR8.Text = "8" + "\n(" + C8 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR9_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C9 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR9.Text = "9" + "\n(" + C9 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR10_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C10 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR10.Text = "10" + "\n(" + C10 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR11_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C11 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR11.Text = "11" + "\n(" + C11 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR12_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C12 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR12.Text = "12" + "\n(" + C12 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR13_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C13 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR13.Text = "13" + "\n(" + C13 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR14_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C14 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR14.Text = "14" + "\n(" + C14 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR15_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C15 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR15.Text = "15" + "\n(" + C15 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR16_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C16 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR16.Text = "16" + "\n(" + C16 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR17_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C17 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR17.Text = "17" + "\n(" + C17 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR18_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C18 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR18.Text = "18" + "\n(" + C18 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR19_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C19 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR19.Text = "19" + "\n(" + C19 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR20_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C20 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR20.Text = "20" + "\n(" + C20 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR21_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C21 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR21.Text = "21" + "\n(" + C21 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR22_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C22 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR22.Text = "22" + "\n(" + C22 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR23_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C23 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR23.Text = "23" + "\n(" + C23 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR24_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C24 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR24.Text = "24" + "\n(" + C24 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR25_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C25 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR25.Text = "25" + "\n(" + C25 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR26_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C26 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR26.Text = "26" + "\n(" + C26 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR27_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C27 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR27.Text = "27" + "\n(" + C27 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR28_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C28 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR28.Text = "28" + "\n(" + C28 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR29_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C29 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR29.Text = "29" + "\n(" + C29 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR30_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C30 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR30.Text = "30" + "\n(" + C30 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR31_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C31 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR31.Text = "31" + "\n(" + C31 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR32_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C32 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR32.Text = "32" + "\n(" + C32 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR33_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C33 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR33.Text = "33" + "\n(" + C33 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR34_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C34 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR34.Text = "34" + "\n(" + C34 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR35_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C35 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR35.Text = "35" + "\n(" + C35 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR36_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C36 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR36.Text = "36" + "\n(" + C36 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR3ST_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C3st += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR3ST.Text = "3st" + "\n(" + C3st + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR2ST_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C2st += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR2ST.Text = "2st" + "\n(" + C2st + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR1ST_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C1st += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR1ST.Text = "1st" + "\n(" + C1st + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletODD_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                COdd += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletODD.Text = "ODD" + "\n(" + COdd + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletEVEN_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                CEven += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletEVEN.Text = "EVEN" + "\n(" + CEven + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR1_18_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C1_18 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR1_18.Text = "1-18" + "\n(" + C1_18 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR19_36_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C19_36 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR19_36.Text = "19-36" + "\n(" + C19_36 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR1_12_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C1_12 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR1_12.Text = "1-12" + "\n(" + C1_12 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR13_24_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C13_24 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR13_24.Text = "13-24" + "\n(" + C13_24 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }

        private void btnRuletBR25_36_Click(object sender, EventArgs e)
        {
            if (IzvlacenjeBroja)
            {
                MBox mbox = new MBox("U toku je izvlačenje broja!", "GREŠKA");
                mbox.Show(); return;
            }
            if (SumaNaRacunu > RuletCip)
            {
                C25_36 += RuletCip;
                RuletUlozenoUkupno += RuletCip;
                btnRuletBR25_36.Text = "25-36" + "\n(" + C25_36 + ")";
                lblRuletUlozeno.Text = "Uloženo: " + RuletUlozenoUkupno + "€";
            }
            else
            {
                MBox mbox = new MBox("Nemate dovoljno novca!", "GREŠKA");
                mbox.Show();
            }
        }
    }
}
