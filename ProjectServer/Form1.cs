using System;
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


        [ServiceContract]
        public interface ISistemServis
        {
            [OperationContract]
            bool Temperatura(string stanica, double vrednost, DateTime vreme);
        }


        [ServiceContract]
        public interface IJavniServis
        {
            [OperationContract]
            double ProsecneTemperature(string stanica, DateTime pocetak, DateTime kraj);
        }


        public class SistemServis : ISistemServis
        {
            public bool Temperatura(string stanica, double vrednost, DateTime vreme)
            {
                return true;
            }
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

            Uri baseAddress = new Uri("http://localhost:8732/MeteoServis/SistemServis");
            Uri baseAddress2 = new Uri("http://localhost:8732/MeteoServis/JavniServis");

            // Create the ServiceHost.
            ServiceHost host = new ServiceHost(typeof(SistemServis), baseAddress);

            // Enable metadata publishing.
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
            host.Description.Behaviors.Add(smb);

            // Open the ServiceHost to start listening for messages. Since
            // no endpoints are explicitly configured, the runtime will create
            // one endpoint per base address for each service contract implemented
            // by the service.
            host.Open();


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
