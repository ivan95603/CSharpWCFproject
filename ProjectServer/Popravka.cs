using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServer
{
    class Popravka
    {
        static int trenutniIDPopravke = 0;

        int id_popravke;
        string deo;
        double cena_dela;

        public Popravka(string deo, double cenaDela)
        {
            if (deo == null) throw new ArgumentNullException(nameof(deo));
            id_popravke = trenutniIDPopravke;
            trenutniIDPopravke++;
            this.deo = deo;
            cena_dela = cenaDela;
        }



        public double CenaDela => cena_dela;
    }
}
