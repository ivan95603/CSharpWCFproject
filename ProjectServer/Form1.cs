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



            List<Popravka> ivanPopravke = new List<Popravka>();
            ivanPopravke.Add(new Popravka());
            ivanPopravke[0].DodajDeoUPopravku("Remenjaca");
            ivanPopravke[0].DodajDeoUPopravku("Kais");


            Automobil.listaAutomobila.Add( new Automobil("podaci", status.popravljaSe, "ivan", ivanPopravke) );
            Debug.WriteLine(Automobil.listaAutomobila[0].sumaTroskovaZaAuto());

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
            /***
             * Imam problem sa ovim mora da se podesi nesto za searializovanje liste kao [CollectionDataContract] samo sto je ovaj za klasu ili struct
             * */
            
                       [OperationContract]
                       List<status> StatusPopravkiNaAutu();

            
                        [OperationContract]
                        ListaDeo PovuciDelove();
           

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
                   return Automobil.sumaCeneTroskova(korisnickoIme);
                }
                return 0;
            }

            /***
           * Imam problem sa ovim mora da se podesi nesto za searializovanje liste kao [CollectionDataContract] samo sto je ovaj za klasu ili struct
           * */
       
            
                        public List<status> StatusPopravkiNaAutu()
                        {
                            if (logovan)
                            {
                                return Automobil.stanjaPopravkaNaKolima(korisnickoIme);
                            }
                            return null;
                        }

          
                        public ListaDeo PovuciDelove()
                        {
                            return ProjectLibrary.Deo.lagerDelova;
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
