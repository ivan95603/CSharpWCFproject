using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary
{


    [CollectionDataContract]
    public class Automobil
    {
        public List<Popravka> popravke = new List<Popravka>();

        static int trenutniID = 0;

        static int trenutniIdPopravke = 0;

        int id_automobil;
        string podaci;

        double cena_popravke;
        int id_popravke;
        double sumaTroskovaNaAutu;

        //List<Popravka> popravke;


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

        public List<status> stanjaPopravkaNaKolima()
        {
            List<status> temp = new List<status>();

            foreach (var VARIABLE in popravke)
            {
      
                    temp.Add(VARIABLE.statusPopravke);
               
            }

            return temp;
        }

        public double sumaTroskovaZaAuto(string username)
        {
            double sum = 0;

            foreach (var VARIABLE in popravke)
            {
              
                    sum += VARIABLE.CenaPopravke();
                
            }

            return sum;
        }




        public Automobil(string podaci, List<Popravka> popravke)
        { 
            try
            {
                if (podaci == null) throw new ArgumentNullException(nameof(podaci));
                if (popravke == null) throw new ArgumentNullException(nameof(popravke));
               this.id_automobil = trenutniID;
                trenutniID++;
                this.podaci = podaci;
               
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
