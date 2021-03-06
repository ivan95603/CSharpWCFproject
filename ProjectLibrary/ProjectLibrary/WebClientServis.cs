﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProjectLibrary
{
    public class WebClientServis : IWebClientServis
    {
        public string GetData(string userName, string password)
        {
            //List<string> a = new List<string>();
            //a.Add("asd");
            //a.Add("aaaaaaaaaaa");

            //List<string> videogames = new List<string>
            //{
            //        "Starcraft",
            //        "Halo",
            //        "Legend of Zelda"
            // };
            //Deo aa = new Deo("kais", 200);
            //string output = JsonConvert.SerializeObject(aa);

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
