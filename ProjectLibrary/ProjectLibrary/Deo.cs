using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary
{
    public class Deo
    {
        public static List<Deo> lagerDelova = new List<Deo>();

        static int deoID = 0;

        public int id;
        public string nazivDela;
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
