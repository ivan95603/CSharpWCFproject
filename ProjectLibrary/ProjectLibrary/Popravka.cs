﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ProjectLibrary;

namespace ProjectLibrary
{
    [DataContract]
    public enum status
    {
        [EnumMember]
        nijeStigaoNaRed,
        [EnumMember]
        popravljaSe,
        [EnumMember]
        popravljen
    };

    [DataContract]
    public class Popravka
    {
        [DataMember]
        public List<Deo> deloviZaPoravku = new List<Deo>();

        [DataMember]
        static int trenutniIDPopravke = 0;
        [DataMember]
        public status statusPopravke;

        [DataMember]
        public int id_popravke;
        [DataMember]
        List<int> deloviIDs = new List<int>();
        [DataMember]
        public List<Deo> delovi = new List<Deo>();

        public Popravka(status statusPopravke)
        {
            this.statusPopravke = statusPopravke;
            this.id_popravke = trenutniIDPopravke;
            trenutniIDPopravke++;
        }

        public Popravka(status statusPopravke, List<Deo> deloviZaPopravke)
        {
            id_popravke = trenutniIDPopravke;
            this.statusPopravke = statusPopravke;
            this.deloviZaPoravku = deloviZaPopravke;
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
