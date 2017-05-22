﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form1()
        {
            InitializeComponent();
        }


        [ServiceContract(SessionMode = SessionMode.Required)]
        public interface IOperaterServis
        {
            [OperationContract]
            void Login(string userName, string password);
           // bool Temperatura(string stanica, double vrednost, DateTime vreme);
        }


        [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Single)]
        public class OperaterServis : IOperaterServis
        {
            public void Login(string userName, string password)
            {
                throw new NotImplementedException();
            }
        }
















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


        private void Form1_Load(object sender, EventArgs e)
        {

            // Create a WSHttpBinding and set its property values. 
            WSHttpBinding binding = new WSHttpBinding();
            binding.Name = "binding1";
            binding.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;
            binding.Security.Mode = SecurityMode.Message;
            binding.ReliableSession.Enabled = false;
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
            host2.Open();

        }
    }
}
