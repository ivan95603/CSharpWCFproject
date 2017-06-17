using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ProjectLibrary;

namespace ProjectLibrary
{
    [DataContract]
    public class Deo
    {
        /*
        [DataMember]
        public static List<Deo> lagerDelova = new List<Deo>();
        */
        [DataMember]
        public static ListaDeo lagerDelova = new ListaDeo();


        [DataMember]
        static int deoID = 0;

        [DataMember]
        public int id;
        [DataMember]
        public string nazivDela;
        [DataMember]
        public double cena_dela;



        public static Deo izaberiDeo(int idDela)
        {
            return Deo.lagerDelova.Find(deo => deo.id == idDela);
        }

        public Deo(string nazivDela, double cenaDela)
        {
            if (nazivDela == null) throw new ArgumentNullException(nameof(nazivDela));
            this.nazivDela = nazivDela;
            cena_dela = cenaDela;
            this.id = deoID;
            deoID++;
        }

        public Deo(int id, string nazivDela, double cenaDela)
        {
            if (nazivDela == null) throw new ArgumentNullException(nameof(nazivDela));
            this.id = id;
            this.nazivDela = nazivDela;
            cena_dela = cenaDela;
        }

        public static bool DodajDeo(Deo ulaz)
        {
            try
            {
                Deo.lagerDelova.Add(ulaz);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public void PromeniCenuDela(double cena)
        {
            this.cena_dela = cena;
        }

        public static bool PromeniCenuDelaZaId(int ID, double Cena)
        {
            foreach (var VARIABLE in lagerDelova)
            {
                if (VARIABLE.id == ID)
                {
                    VARIABLE.PromeniCenuDela(Cena);
                    return true;
                }
            }
            return false;
            
        }
    }


    }
    [CollectionDataContract]
    public class ListaDeo:List<Deo>
    {

    }
