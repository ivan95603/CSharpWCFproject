using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary
{
    [CollectionDataContract]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Single)]
    public class AdministratorServis : IAdministratorServis
    {
        bool logovan = false;
        string korisnickoIme = "";

        public bool proveriLogin()
        {
            return logovan;
        }

        public bool Login(string userName, string password)
        {
            if (Korisnik.proveriLogin(userName, password))
            {
                logovan = true;
                korisnickoIme = userName;
                return true;
            }
            return false;
        }

        public double SumaTroskovaNaAutuZaKorisnika()
        {
            if (logovan)
            {
                return Korisnik.sumaTroskovaZaKorisnika(korisnickoIme);
            }
            return 0;
        }

        public List<status> StatusPopravkiNaAutu()
        {
            if (logovan)
            {
                return Korisnik.stanjaPopravkaNaKolimaZaKorisnika(korisnickoIme);
            }
            return null;
        }


        /**
         * 
         * Funkcije za delove
         * 
         */


        public ListaDeo PovuciDelove()
        {
            return ProjectLibrary.Deo.lagerDelova;
        }

        public bool PromeniCenuZaIDOdDeo(int ID, double Cena)
        {
            return Deo.PromeniCenuDelaZaId(ID, Cena);
        }


        /**
         * 
         * Funkcije za Korisnike
         *
         */

        public List<Korisnik> PovuciKorisnike()
        {
            return Korisnik.korisnici;
        }

        public bool DodajKorisnika(string userName, string password)
        {
            try
            {
                foreach (var VARIABLE in Korisnik.korisnici)
                {
                    if (VARIABLE.korisnicko_ime == userName)
                    {
                        throw new Exception("Korisnik vec postoji");
                    }
                }

                Korisnik.korisnici.Add(new Korisnik(userName, password));
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }

        public bool ObrisiKorisnika(string userName)
        {
            for (int i = 0; i < Korisnik.korisnici.Count(); i++)
            {
                if (Korisnik.korisnici[i].korisnicko_ime == userName)
                {
                    Korisnik.korisnici.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }


        public bool PromeniUserNameKorisnika(string newUserName, string userName)
        {
            return false;
        }


        /**
        * 
        * Funkcije za Automobile
        *
        */

        public bool DodajAutomobilZaKorisnika(string userName, string naziv)
        {
            foreach (var korisnik in Korisnik.korisnici)
            {
                if (korisnik.korisnicko_ime == userName)
                {
                    korisnik.Automobili.Add(new Automobil(naziv));
                    return true;
                }
            }
            return false;
        }

        public bool DodajAutomobilZaKorisnikaID(int userID, string naziv)
        {
            foreach (var korisnik in Korisnik.korisnici)
            {
                if (korisnik.idKorisnika == userID)
                {
                    korisnik.Automobili.Add(new Automobil(naziv));
                    return true;
                }
            }
            return false;
        }


        public bool ObrisiAutomobilZaKorisnika(string userName, int id)
        {
            foreach (var korisnik in Korisnik.korisnici)
            {
                if (korisnik.korisnicko_ime == userName)
                {
                    for (int i = 0; i < korisnik.Automobili.Count(); i++)
                    {
                        if (korisnik.Automobili[i].id_automobil == id)
                        {
                            korisnik.Automobili.RemoveAt(i);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool ObrisiAutomobilZaKorisnikaID(int userID, int id)
        {
            foreach (var korisnik in Korisnik.korisnici)
            {
                if (korisnik.idKorisnika == userID)
                {
                    for (int i = 0; i < korisnik.Automobili.Count(); i++)
                    {
                        if (korisnik.Automobili[i].id_automobil == id)
                        {
                            korisnik.Automobili.RemoveAt(i);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        /**
        * 
        * Funkcije za Popravke
        *
        */


        public bool DodajPopravkuZaAutoZaKorisnika(int userID, int carID, int status)
        {

            foreach (var korisnik in Korisnik.korisnici)
            {
                if (korisnik.idKorisnika == userID)
                {
                    foreach (var autiKorisnik in korisnik.Automobili)
                    {
                        if (autiKorisnik.id_automobil == carID)
                        {
                            autiKorisnik.popravke.Add(new Popravka((status)status));
                            return true;
                        }
                    }
                }
            }
            return false;

        }

        public bool ObrisiPopravkuZaAutoZaKorisnika(int userID, int carID, int popravkaID)
        {
            foreach (var korisnik in Korisnik.korisnici)
            {
                if (korisnik.idKorisnika == userID)
                {
                    foreach (var autiKorisnik in korisnik.Automobili)
                    {
                        if (autiKorisnik.id_automobil == carID)
                        {

                            for (int i = 0; i < autiKorisnik.popravke.Count(); i++)
                            {
                                if (autiKorisnik.popravke[i].id_popravke == popravkaID)
                                {
                                    autiKorisnik.popravke.RemoveAt(i);
                                    return true;
                                }
                            }
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        /**
        * 
        * Funkcije za delova za Popravke
        *
        */


        public bool DodajDeoZaPopravkuZaAutoZaKorisnika(int userID, int carID, int fixID, int partID)
        {

            Korisnik a = Korisnik.korisnici.Find(korisnik => korisnik.idKorisnika == userID);

            Automobil b = a.Automobili.Find(automobil => automobil.id_automobil == carID);

            Popravka c = b.popravke.Find(popravka => popravka.id_popravke == fixID);

            if ((a != null) && (b != null) && (c != null) && (Deo.izaberiDeo(partID) != null))
            {

                (Korisnik.korisnici.Find(korisnik => korisnik.idKorisnika == userID).Automobili.Find(automobil => automobil.id_automobil == carID).popravke.Find(popravka => popravka.id_popravke == fixID)).delovi.Add(Deo.izaberiDeo(partID)); ; //.Add(new Deo("ika", 354)));

                return true;

            }

            return false;

        }

        public bool ObrisiDeoZaPopravkuZaAutoZaKorisnika(int userID, int carID, int fixID, int partID)
        {

            Korisnik a = Korisnik.korisnici.Find(korisnik => korisnik.idKorisnika == userID);

            Automobil b = a.Automobili.Find(automobil => automobil.id_automobil == carID);

            Popravka c = b.popravke.Find(popravka => popravka.id_popravke == fixID);

            if ((a != null) && (b != null) && (c != null) && (Deo.izaberiDeo(partID) != null))
            {
                return (Korisnik.korisnici.Find(korisnik => korisnik.idKorisnika == userID).Automobili.Find(automobil => automobil.id_automobil == carID).popravke.Find(popravka => popravka.id_popravke == fixID)).delovi.Remove((Korisnik.korisnici.Find(korisnik => korisnik.idKorisnika == userID).Automobili.Find(automobil => automobil.id_automobil == carID).popravke.Find(popravka => popravka.id_popravke == fixID)).delovi.Find(deo => deo.id == partID));
            }

            return false;
        }
    }

}

