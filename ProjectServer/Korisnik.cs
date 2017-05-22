using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServer
{
    public class Korisnik
    {
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