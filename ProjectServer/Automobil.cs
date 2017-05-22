using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServer
{
    enum status { nijeStigaoNaRed, popravljaSe, popravljen};

    class Automobil
    {
        static int trenutniIdPopravke = 0;

        int id_automobil;
        string podaci;
        status statusPopravke;
        double cena_popravke;
        string korisnicko_ime;
        int id_popravke;

        List<Popravka> popravke;


        public double sumaTroskovaZaAuto()
        {
            double suma = 0;

            foreach (var item in popravke)
            {
                suma += item.CenaDela;
            }

            return suma;
        }
    }
}
