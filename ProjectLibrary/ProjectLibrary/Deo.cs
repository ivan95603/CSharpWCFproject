using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary
{
    [Serializable]
    [DataContract]
    [CollectionDataContract]
    public class Deo
    {
        
        [DataMember]
        public static List<Deo> lagerDelova = new List<Deo>();

        [DataMember]
        static int deoID = 0;

        [DataMember]
        public int id;
        [DataMember]
        public string nazivDela;
        [DataMember]
        public double cena_dela;

       
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
    }
}
