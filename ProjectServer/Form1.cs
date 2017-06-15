using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Runtime.Serialization;
using ProjectLibrary;

namespace ProjectServer
{



    public partial class Form1 : Form
    {


        void Init()
        {
            Korisnik.korisnici.Add(new Korisnik("ivan", "pass"));

            Deo.DodajDeo(new Deo("Remenjaca", 10000));
            Deo.DodajDeo(new Deo("Kais", 5000));

            Korisnik.korisnici[0].Automobili.Add(new Automobil("Audi", new List<Popravka>()));

            
            Korisnik.korisnici[0].Automobili[0].popravke.Add(new Popravka(status.nijeStigaoNaRed, new List<Deo>() ));
            Korisnik.korisnici[0].Automobili[0].popravke[0].DodajDeoUPopravku("Remenjaca");
            Korisnik.korisnici[0].Automobili[0].popravke[0].DodajDeoUPopravku("Kais");


           // Automobil.listaAutomobila.Add( new Automobil("podaci", status.popravljaSe, "ivan", ivanPopravke) );
           // Debug.WriteLine(Automobil.listaAutomobila[0].sumaTroskovaZaAuto());

        }
   

        public Form1()
        {
            InitializeComponent();
        }

        [ServiceContract(SessionMode = SessionMode.Required)]
        public interface IOperaterServis
        {
            [OperationContract]
            bool Login(string userName, string password);

            [OperationContract]
            bool proveriLogin();

            [OperationContract]
            double SumaTroskovaNaAutuZaKorisnika();
   
            [OperationContract]
            List<status> StatusPopravkiNaAutu();


            /**
            * 
            * Funkcije za delove
            * 
            */

            [OperationContract]
            ListaDeo PovuciDelove();

            [OperationContract]
            bool PromeniCenuZaIDOdDeo(int ID, double Cena);

            /**
            * 
            * Funkcije za Korisnike
            *
            */

            [OperationContract]
            List<Korisnik> PovuciKorisnike();

            [OperationContract]
            bool DodajKorisnika(string userName, string password);

            [OperationContract]
            bool ObrisiKorisnika(string userName);

            [OperationContract]
            bool PromeniUserNameKorisnika(string newUserName, string userName);


            /**
            * 
            * Funkcije za Automobile
            *
            */

            [OperationContract]
            bool DodajAutomobilZaKorisnika(string userName, string naziv);

            [OperationContract]
            bool DodajAutomobilZaKorisnikaID(int userID, string naziv);


            [OperationContract]
            bool ObrisiAutomobilZaKorisnika(string userName, int id);

            [OperationContract]
            bool ObrisiAutomobilZaKorisnikaID(int userID, int id);

            /**
            * 
            * Funkcije za Popravke
            *
            */

            [OperationContract]
            bool DodajPopravkuZaAutoZaKorisnika(int userID, int carID, int status);

            [OperationContract]
            bool ObrisiPopravkuZaAutoZaKorisnika(int userID, int carID, int popravkaID);
            
        
        }

        [CollectionDataContract]
        [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Single)]
        public class OperaterServis : IOperaterServis
        {
            bool logovan = false;
            string korisnickoIme = "";

            public bool proveriLogin()
            {
                return logovan;
            }

            public bool Login(string userName, string password)
            {
                if (Korisnik.proveriLogin(userName, password))
                {
                    logovan = true;
                    korisnickoIme = userName;
                    return true;
                }
                return false;
            }

            public double SumaTroskovaNaAutuZaKorisnika()
            {
                if (logovan)
                {
                   return Korisnik.sumaTroskovaZaKorisnika(korisnickoIme);
                }
                return 0;
            }
            
            public List<status> StatusPopravkiNaAutu()
            {
                 if (logovan)
                 {
                    return Korisnik.stanjaPopravkaNaKolimaZaKorisnika(korisnickoIme);
                 }
                 return null;
            }


            /**
             * 
             * Funkcije za delove
             * 
             */

          
            public ListaDeo PovuciDelove()
            {
                 return ProjectLibrary.Deo.lagerDelova;
            }

            public bool PromeniCenuZaIDOdDeo(int ID, double Cena)
            {
                return Deo.PromeniCenuDelaZaId(ID, Cena);
            }


            /**
             * 
             * Funkcije za Korisnike
             *
             */

            public List<Korisnik> PovuciKorisnike()
            {
                return Korisnik.korisnici;
            }

            public bool DodajKorisnika(string userName, string password)
            {
                try
                {
                    foreach (var VARIABLE in Korisnik.korisnici)
                    {
                        if (VARIABLE.korisnicko_ime == userName)
                        {
                            throw new Exception("Korisnik vec postoji");
                        }
                    }

                    Korisnik.korisnici.Add(new Korisnik(userName, password));
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return false;
                }
              
            }

            public bool ObrisiKorisnika(string userName)
            {
                for (int i = 0; i < Korisnik.korisnici.Count(); i++)
                {
                    if (Korisnik.korisnici[i].korisnicko_ime == userName)
                    {
                        Korisnik.korisnici.RemoveAt(i);
                        return true;
                    }
                }
                return false;
            }


            public bool PromeniUserNameKorisnika(string newUserName, string userName)
            {
                return false;
            }


            /**
            * 
            * Funkcije za Automobile
            *
            */

            public bool DodajAutomobilZaKorisnika(string userName, string naziv)
            {
                foreach (var korisnik in Korisnik.korisnici)
                {
                    if (korisnik.korisnicko_ime == userName)
                    {
                        korisnik.Automobili.Add(new Automobil(naziv));
                        return true;
                    }
                }
                return false;
            }

            public bool DodajAutomobilZaKorisnikaID(int userID, string naziv)
            {
                foreach (var korisnik in Korisnik.korisnici)
                {
                    if (korisnik.idKorisnika == userID)
                    {
                        korisnik.Automobili.Add(new Automobil(naziv));
                        return true;
                    }
                }
                return false;
            }


            public bool ObrisiAutomobilZaKorisnika(string userName, int id)
            {
                foreach (var korisnik in Korisnik.korisnici)
                {
                    if (korisnik.korisnicko_ime == userName)
                    {
                        for (int i = 0; i < korisnik.Automobili.Count(); i++)
                        {
                            if (korisnik.Automobili[i].id_automobil == id)
                            {
                                korisnik.Automobili.RemoveAt(i);
                                return true;
                            }
                        }                       
                    }
                }
                return false;
            }

            public bool ObrisiAutomobilZaKorisnikaID(int userID, int id)
            {
                foreach (var korisnik in Korisnik.korisnici)
                {
                    if (korisnik.idKorisnika == userID)
                    {
                        for (int i = 0; i < korisnik.Automobili.Count(); i++)
                        {
                            if (korisnik.Automobili[i].id_automobil == id)
                            {
                                korisnik.Automobili.RemoveAt(i);
                                return true;
                            }
                        }
                    }
                }
                return false;
            }

            /**
            * 
            * Funkcije za Popravke
            *
            */


            public bool DodajPopravkuZaAutoZaKorisnika(int userID, int carID, int status)
            {

                foreach (var korisnik in Korisnik.korisnici)
                {
                    if (korisnik.idKorisnika == userID)
                    {
                        foreach (var autiKorisnik in korisnik.Automobili)
                        {
                            if (autiKorisnik.id_automobil == carID)
                            {
                                autiKorisnik.popravke.Add(new Popravka((status)status));
                                return true;
                            }
                        }
                    }
                }
                return false;

            }

            public bool ObrisiPopravkuZaAutoZaKorisnika(int userID, int carID, int popravkaID)
            {
                foreach (var korisnik in Korisnik.korisnici)
                {
                    if (korisnik.idKorisnika == userID)
                    {
                        foreach (var autiKorisnik in korisnik.Automobili)
                        {
                            if (autiKorisnik.id_automobil == carID)
                            {

                                for (int i = 0; i < autiKorisnik.popravke.Count(); i++)
                                {
                                    if (autiKorisnik.popravke[i].id_popravke == popravkaID)
                                    {
                                        autiKorisnik.popravke.RemoveAt(i);
                                        return true;
                                    }
                                }
                                return true;
                            }
                        }
                    }
                }
                return false;
            }
        }






        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
            Debug.WriteLine("IVANVNASJVALSKDJLKASJDLKSA");

              // Create a WSHttpBinding and set its property values. 
              WSHttpBinding binding = new WSHttpBinding();
              binding.Name = "binding1";
              binding.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;
              binding.Security.Mode = SecurityMode.Message;
              binding.ReliableSession.Enabled = true;
              binding.TransactionFlow = false;
              //Specify a base address for the service endpoint. 
              Uri baseAddress = new Uri(@"http://localhost:8734/MeteoServis/OperaterServis");
              // Create a ServiceHost for the CalculatorService type 
              // and provide it with a base address. 
              ServiceHost serviceHost = new ServiceHost(typeof(OperaterServis), baseAddress);
              serviceHost.AddServiceEndpoint(typeof(IOperaterServis), binding, baseAddress);
              // Open the ServiceHostBase to create listeners 
              // and start listening for messages. 

              ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
              smb.HttpGetEnabled = true;
              smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
              serviceHost.Description.Behaviors.Add(smb);


            serviceHost.Description.Behaviors.Remove(
                typeof(ServiceDebugBehavior));
            serviceHost.Description.Behaviors.Add(
                new ServiceDebugBehavior { IncludeExceptionDetailInFaults = true });


            // Add MEX endpoint
            serviceHost.AddServiceEndpoint(
                  ServiceMetadataBehavior.MexContractName,
                  MetadataExchangeBindings.CreateMexHttpBinding(),
                  "mex"
              );

            serviceHost.Open();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
