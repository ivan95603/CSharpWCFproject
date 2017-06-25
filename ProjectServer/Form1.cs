using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Runtime.Serialization;
using System.ServiceModel.Web;
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





        private void Form1_Load(object sender, EventArgs e)
        {
            
              Init();

            //Operater servis
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

    




            //Web client
            Uri baseAddressREST = new Uri("http://localhost:8080/webklientrest");
            WebServiceHost serviceHostREST = new WebServiceHost(typeof(WebClientServis), baseAddressREST);

            serviceHostREST.Open();


            //Normal client


            // Create a WSHttpBinding and set its property values. 
            WSHttpBinding bindingNormalClient = new WSHttpBinding();
            bindingNormalClient.Name = "binding1";
            bindingNormalClient.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;
            bindingNormalClient.Security.Mode = SecurityMode.Message;
            bindingNormalClient.ReliableSession.Enabled = true;
            bindingNormalClient.TransactionFlow = false;
            //Specify a base address for the service endpoint. 
            Uri baseAddressNormalClient = new Uri(@"http://localhost:8734/MeteoServis/NormalClient");
            // Create a ServiceHost for the CalculatorService type 
            // and provide it with a base address. 
            ServiceHost serviceHostNormalClient = new ServiceHost(typeof(NormalClientServis), baseAddressNormalClient);
            serviceHostNormalClient.AddServiceEndpoint(typeof(INormalClientServis), bindingNormalClient, baseAddressNormalClient);
            // Open the ServiceHostBase to create listeners 
            // and start listening for messages. 

            ServiceMetadataBehavior smbNormalClient = new ServiceMetadataBehavior();
            smbNormalClient.HttpGetEnabled = true;
            smbNormalClient.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
            serviceHostNormalClient.Description.Behaviors.Add(smbNormalClient);


            serviceHostNormalClient.Description.Behaviors.Remove(
                typeof(ServiceDebugBehavior));
            serviceHostNormalClient.Description.Behaviors.Add(
                new ServiceDebugBehavior { IncludeExceptionDetailInFaults = true });


            // Add MEX endpoint
            serviceHostNormalClient.AddServiceEndpoint(
                ServiceMetadataBehavior.MexContractName,
                MetadataExchangeBindings.CreateMexHttpBinding(),
                "mex"
            );

            serviceHostNormalClient.Open();




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
