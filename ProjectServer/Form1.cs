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

namespace ProjectServer
{



    public partial class Form1 : Form
    {


        void Init()
        {
            Korisnik.korisnici.Add(new Korisnik("ivan", "pass"));

            List<Popravka> ivanPopravke = new List<Popravka>();
            ivanPopravke.Add(new Popravka("Remenjaca", 1000));
            ivanPopravke.Add(new Popravka("Promena ulja", 5000));

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

            [OperationContract]
            List<status> StatusPopravkiNaAutu();
        }


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

            public List<status> StatusPopravkiNaAutu()
            {
                if (logovan)
                {
                    return Automobil.stanjaPopravkaNaKolima(korisnickoIme);
                }

                return null;
            }
        }















        /*
        [ServiceContract]
        public interface IJavniServis
        {
            [OperationContract]
            double ProsecneTemperature(string stanica, DateTime pocetak, DateTime kraj);
        }



        public class JavniServis : IJavniServis
        {
            public double ProsecneTemperature(string stanica, DateTime pocetak, DateTime kraj)
            {

                return 0;
            }
        }

    */
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
            Uri baseAddress = new Uri(@"http://localhost:8732/MeteoServis/OperaterServis");
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

            serviceHost.Open();











            /*


            Uri baseAddress2 = new Uri("http://localhost:8732/MeteoServis/JavniServis");


        
            // Create the ServiceHost.
            ServiceHost host2 = new ServiceHost(typeof(JavniServis), baseAddress2);

            // Enable metadata publishing.
            ServiceMetadataBehavior smb2 = new ServiceMetadataBehavior();
            smb2.HttpGetEnabled = true;
            smb2.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
            host2.Description.Behaviors.Add(smb2);

            // Open the ServiceHost to start listening for messages. Since
            // no endpoints are explicitly configured, the runtime will create
            // one endpoint per base address for each service contract implemented
            // by the service.
            host2.Open();*/

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
