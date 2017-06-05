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
        OperaterServis.OperaterServisClient servis = new OperaterServis.OperaterServisClient();
        List<Deo> DeloviPovuceni;
        List<Korisnik> KorisniciPovuceni;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {    
            

        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            
            Debug.WriteLine(servis.Login("ivan", "pass"));

            List<status> popravkeList = /*servis.StatusPopravkiNaAutu();*/ servis.StatusPopravkiNaAutu().ToList();
            double cenaTroskova = servis.SumaTroskovaNaAutuZaKorisnika();


            foreach (var VARIABLE in popravkeList)
            {
                listBox1.Items.Add("Status popravke: " + VARIABLE.ToString());
            }
            listBox1.Items.Add("Ukupni troskovi za auto: " + cenaTroskova.ToString());

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Debug.WriteLine(tabControl1.SelectedIndex);
            if (tabControl1.SelectedIndex == 1)
            {
                listBox2.Items.Clear();
                if (!servis.proveriLogin())
                {
                    servis.Login("ivan", "pass");
                }

                 DeloviPovuceni = servis.PovuciDelove();
                foreach (var VARIABLE in DeloviPovuceni)
                {
                    listBox2.Items.Add(VARIABLE.nazivDela);
                    Debug.WriteLine(VARIABLE.nazivDela);
                }
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                listBox3.Items.Clear();

                if (!servis.proveriLogin())
                {
                    servis.Login("ivan", "pass");
                }

                KorisniciPovuceni = servis.PovuciKorisnike().ToList();
                foreach (var VARIABLE in KorisniciPovuceni)
                {
                    listBox3.Items.Add(VARIABLE.korisnicko_ime);
                    Debug.WriteLine(VARIABLE.korisnicko_ime);
                }
            }






        }

        private void Delovi_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var VARIABLE in DeloviPovuceni)
            {
                if (VARIABLE.nazivDela == listBox2.SelectedItem.ToString())
                {
                    textBox1.Text = VARIABLE.nazivDela;
                    numericUpDown1.Text = VARIABLE.cena_dela.ToString();
                    numericUpDown2.Text = VARIABLE.id.ToString();

                }
            }
            DeloviPovuceni = servis.PovuciDelove();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = (int)numericUpDown2.Value;
            double Cena = (Double)numericUpDown1.Value;
            servis.PromeniCenuZaIDOdDeo(ID, Cena);
            DeloviPovuceni = servis.PovuciDelove();
            int a = 2;
        }
    }
}
