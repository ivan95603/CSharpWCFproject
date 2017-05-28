using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOperater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OperaterServis.OperaterServisClient servis = new OperaterServis.OperaterServisClient();
            /*textBox1.Text = */servis.Login("ivan", "pass");//   ProsecneTemperature(textNazivStanice.Text, dateTimePicker1.Value, dateTimePicker2.Value).ToString();

        }
    }
}
