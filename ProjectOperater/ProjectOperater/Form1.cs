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
using ProjectLibrary;

namespace ProjectOperater
{
    public partial class Form1 : Form
    {
        OperaterServis.OperaterServisClient servis;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {    
            

        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            servis = new OperaterServis.OperaterServisClient();
            Debug.WriteLine(servis.Login("ivan", "pass"));

            List<ProjectLibrary.status> popravkeList = servis.StatusPopravkiNaAutu(); // servis.StatusPopravkiNaAutu().ToList();
            double cenaTroskova = servis.SumaTroskovaNaAutuZaKorisnika();


            foreach (var VARIABLE in popravkeList)
            {
                listBox1.Items.Add("Status popravke: " + VARIABLE.ToString());
            }
            listBox1.Items.Add("Ukupni troskovi za auto: " + cenaTroskova.ToString());

        }
    }
}
