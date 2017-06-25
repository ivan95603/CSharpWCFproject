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
    public class NormalClientServis : INormalClientServis
    {
        public string GetData(string userName, string password)
        {
            string output = "";

            Korisnik user = Korisnik.korisnici.Find(korisnik => korisnik.korisnicko_ime == userName);

            if (user != null)
            {
                if (user.lozinka == password)
                {
                    foreach (var automobil in user.Automobili)
                    {
                        output += automobil.podaci + ':' + automobil.sumaTroskovaZaAuto() + '#';
                    }


                }
            }

            return output;
        }
    }
}
