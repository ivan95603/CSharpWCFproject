using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ProjectLibrary;

namespace ProjectServer
{
    [CollectionDataContract]
    public class Popravka
    {
        static int trenutniIDPopravke = 0;

        int id_popravke;
        List<int> deloviIDs = new List<int>();
        List<Deo> delovi = new List<Deo>();

        public Popravka()
        {
            id_popravke = trenutniIDPopravke;
            trenutniIDPopravke++;
        }

        public double CenaPopravke()
        {
            double sum = 0;

            foreach (var item in deloviIDs)
            {
                foreach (var item2 in ProjectLibrary.Deo.lagerDelova)
                {
                    if (item == item2.id)
                    {
                        sum += item2.cena_dela;
                    }
                }
            }
            return sum;
        }

        public bool DodajDeoUPopravku(string naziv)
        {
            try
            {
                foreach (var VARIABLE in Deo.lagerDelova)
                {
                    if (VARIABLE.nazivDela == naziv)
                    {
                        delovi.Add(VARIABLE);
                        deloviIDs.Add(VARIABLE.id);
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return false;
        }

        public bool DodajDeoUPopravku(int id)
        {
            try
            {
                deloviIDs.Add(id);
                delovi = new List<Deo>();
                foreach (var VARIABLE in Deo.lagerDelova)
                {
                    if (VARIABLE.id == id)
                    {
                        delovi.Add(VARIABLE);
                        return true;
                    }
                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return false;
        }



    }
}
