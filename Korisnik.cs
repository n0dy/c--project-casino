using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Kladionica
{
    class Korisnik
    {
        string ImeKorisnika, PrezimeKorisnika, UsernameKorisnika, PasswordKorisnika, BanovanRazlog;
        int BrojClanstva, StanjeNaRacunu, Grupa, PinKod, Banovan;
        public Korisnik(string KorisnickoIme)
        {
            UsernameKorisnika = KorisnickoIme;
        }
        public void UzmiKorisničkeInformacije(string Korisnik)
        {
            StreamReader sr = new StreamReader(@"Aplikacija\Korisnici\" + Korisnik + ".txt");
            string s;
            s = sr.ReadLine();
            ImeKorisnika = s.Substring(s.IndexOf(":") + 1);
            s = sr.ReadLine();
            PrezimeKorisnika = s.Substring(s.IndexOf(":") + 1);
            s = sr.ReadLine();
            PasswordKorisnika = s.Substring(s.IndexOf(":") + 1);
            s = sr.ReadLine();
            Grupa = Convert.ToInt32(s.Substring(s.IndexOf(":") + 1 ));
            s = sr.ReadLine();
            BrojClanstva = Convert.ToInt32(s.Substring(s.IndexOf(":") + 1));
            s = sr.ReadLine();
            StanjeNaRacunu = Convert.ToInt32(s.Substring(s.IndexOf(":") + 1));
            s = sr.ReadLine();
            PinKod = Convert.ToInt32(s.Substring(s.IndexOf(":") + 1));
            s = sr.ReadLine();
            Banovan = Convert.ToInt32(s.Substring(s.IndexOf(":") + 1));
            s = sr.ReadLine();
            BanovanRazlog = s.Substring(s.IndexOf(":") + 1);
            sr.Close();
        }
        public void SacuvajKorisnika(string Korisnik)
        {
            StreamWriter sw = new StreamWriter(@"Aplikacija\Korisnici\" + Korisnik + ".txt", false);
            sw.WriteLine("Ime:" + ImeKorisnika);
            sw.WriteLine("Prezime:" + PrezimeKorisnika);
            sw.WriteLine("Password:" + PasswordKorisnika);
            sw.WriteLine("Grupa:" + Grupa);
            sw.WriteLine("Broj clanstva:" + BrojClanstva);
            sw.WriteLine("Stanje na računu:" + StanjeNaRacunu);
            sw.WriteLine("Pinkod:" + PinKod);
            sw.WriteLine("Banovan:" + Banovan);
            sw.WriteLine("Banovan razlog:" + BanovanRazlog);
            sw.Close();
        }

        public string UzmiPassword(string Korisnik)
        {
            UzmiKorisničkeInformacije(Korisnik);
            return PasswordKorisnika;
        }

        public string UzmiKorisnickoImeiPrezime(string Korisnik)
        {
            UzmiKorisničkeInformacije(Korisnik);
            return ImeKorisnika + " " + PrezimeKorisnika;
        }

        public string UzmiIme(string Korisnik)
        {
            UzmiKorisničkeInformacije(Korisnik);
            return ImeKorisnika;
        }

        public string UzmiPrezime(string Korisnik)
        {
            UzmiKorisničkeInformacije(Korisnik);
            return PrezimeKorisnika;
        }

        public int UzmiStanjeNaRacunu(string Korisnik)
        {
            UzmiKorisničkeInformacije(Korisnik);
            return StanjeNaRacunu;
        }

        public int UzmiBrojClanstva(string Korisnik)
        {
            UzmiKorisničkeInformacije(Korisnik);
            return BrojClanstva;
        }

        public int UzmiPinKod(string Korisnik)
        {
            UzmiKorisničkeInformacije(Korisnik);
            return PinKod;
        }

        public int UzmiGrupu(string Korisnik)
        {
            UzmiKorisničkeInformacije(Korisnik);
            return Grupa;
        }

        public bool BanovanKorisnik(string Korisnik)
        {
            UzmiKorisničkeInformacije(Korisnik);
            if (Banovan == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string RazlogBana(string Korisnik)
        {
            UzmiKorisničkeInformacije(Korisnik);
            return BanovanRazlog;
        }

        public string ImeGrupe(string Korisnik)
        {
            UzmiKorisničkeInformacije(Korisnik);
            string NazivGrupe = "Korisnik";
            if(Grupa == 2)
            {
                NazivGrupe = "Administrator";
            }
            return NazivGrupe;
        }
    }
}
