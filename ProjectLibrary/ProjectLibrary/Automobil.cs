using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary
{

    [DataContract]
    public enum status {
        [EnumMember]
        nijeStigaoNaRed,
        [EnumMember]
        popravljaSe,
        [EnumMember]
        popravljen };

    [CollectionDataContract]
    public class Automobil
    {
        public static List<Automobil> listaAutomobila = new List<Automobil>();

        static int trenutniID = 0;

        static int trenutniIdPopravke = 0;

        int id_automobil;
        string podaci;
        status statusPopravke;
        double cena_popravke;
        string korisnicko_ime;
        int id_popravke;
        double sumaTroskovaNaAutu;

        List<Popravka> popravke;


        public double sumaTroskovaZaAuto()
        {
            double suma = 0;

            foreach (var item in popravke)
            {
                suma += item.CenaPopravke();
            }
            sumaTroskovaNaAutu = suma;

            return suma;
        }

        public static List<status> stanjaPopravkaNaKolima(string username)
        {
            List<status> temp = new List<status>();

            foreach (var VARIABLE in Automobil.listaAutomobila)
            {
                if (VARIABLE.korisnicko_ime == username)
                {
                    temp.Add(VARIABLE.statusPopravke);
                }
            }

            return temp;
        }

        public static double sumaCeneTroskova(string username)
        {
            double sum = 0;

            foreach (var VARIABLE in Automobil.listaAutomobila)
            {
                if (VARIABLE.korisnicko_ime == username)
                {
                    sum += VARIABLE.sumaTroskovaNaAutu;
                }
            }

            return sum;
        }



        public Automobil(string podaci, status statusPopravke, string korisnickoIme, List<Popravka> popravke)
        { 
            try
            {
                if (podaci == null) throw new ArgumentNullException(nameof(podaci));
                if ((korisnickoIme == null) ||  !(Korisnik.ProveriDaLiPostojiKorisnik(korisnickoIme))  ) throw new ArgumentNullException(nameof(korisnickoIme));
                if (popravke == null) throw new ArgumentNullException(nameof(popravke));
               this.id_automobil = trenutniID;
                trenutniID++;
                this.podaci = podaci;
                this.statusPopravke = statusPopravke;
                korisnicko_ime = korisnickoIme;
                id_popravke = trenutniIdPopravke;
                trenutniIdPopravke++;
                this.popravke = popravke;
                sumaTroskovaZaAuto();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
