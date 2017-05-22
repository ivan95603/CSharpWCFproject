using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServer
{
    public class Korisnik
    {
        public static List<Korisnik> korisnici = new List<Korisnik>();

        public static bool proveriLogin(string korIme, string pass)
        {
            foreach (var item in korisnici)
            {
                if ((item.korisnicko_ime == korIme) && (item.lozinka == pass))
                {
                    return true;
                }
            }
            return false;
        }
    

        string korisnicko_ime;
        string lozinka;

        public Korisnik(string korisnickoIme, string lozinka)
        {
            if (korisnickoIme == null) throw new ArgumentNullException(nameof(korisnickoIme));
            if (lozinka == null) throw new ArgumentNullException(nameof(lozinka));
            korisnicko_ime = korisnickoIme;
            this.lozinka = lozinka;
        }
    }
}