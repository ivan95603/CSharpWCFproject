using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary
{
    [DataContract]
    public class Korisnik
    {
        [DataMember]
        public static List<Korisnik> korisnici = new List<Korisnik>();

        [DataMember]
        public List<Automobil> Automobili = new List<Automobil>();

        

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

        public static bool ProveriDaLiPostojiKorisnik(string ime)
        {
            foreach (Korisnik item in Korisnik.korisnici)
            {
                if (item.korisnicko_ime == ime)
                {
                    return true;
                }

            }
            return false;
        }

        [DataMember]
        public string korisnicko_ime;
        [DataMember]
        string lozinka;

        

        public Korisnik(string korisnickoIme, string lozinka)
        {
            if (korisnickoIme == null) throw new ArgumentNullException(nameof(korisnickoIme));
            if (lozinka == null) throw new ArgumentNullException(nameof(lozinka));
            korisnicko_ime = korisnickoIme;
            this.lozinka = lozinka;
        }

        public double sumaTroskovaZaKorisnika()
        {
            double tempSum = 0;
            foreach (var VARIABLE in Automobili)
            {
                tempSum += VARIABLE.sumaTroskovaZaAuto();
            }
            return tempSum;
        }


        public static double sumaTroskovaZaKorisnika(string userName)
        {
            double tempSum = 0;

            foreach (var VARIABLE in Korisnik.korisnici)
            {
                if (VARIABLE.korisnicko_ime == userName)
                {
                    foreach (var VARIABLE2 in VARIABLE.Automobili)
                    {
                        tempSum += VARIABLE2.sumaTroskovaZaAuto();
                    }
                }
            }
           
            return tempSum;
        }


        public static List<status> stanjaPopravkaNaKolimaZaKorisnika(string userName)
        {
            List<status> tempStatusi = new List<status>();

            foreach (var VARIABLE in Korisnik.korisnici)
            {
                if (VARIABLE.korisnicko_ime == userName)
                {
                    foreach (var VARIABLE2 in VARIABLE.Automobili)
                    {
                        tempStatusi.AddRange(VARIABLE2.stanjaPopravkaNaKolima());
                    }
                }
            }

            return tempStatusi;
        }


    }
}