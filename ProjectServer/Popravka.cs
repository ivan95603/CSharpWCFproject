using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServer
{
    class Popravka
    {
        int id_popravke;
        string deo;
        double cena_dela;

        public Popravka(int idPopravke, string deo, double cenaDela)
        {
            if (deo == null) throw new ArgumentNullException(nameof(deo));
            id_popravke = idPopravke;
            this.deo = deo;
            cena_dela = cenaDela;
        }

        public double CenaDela => cena_dela;
    }
}
