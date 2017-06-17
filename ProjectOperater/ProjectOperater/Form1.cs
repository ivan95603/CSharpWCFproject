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

        Korisnik izabraniKorisnik;
        Automobil izabraniAutomobil;
        Popravka izabranaPopravka;

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
            ocistiKontrole();
        }

        private void Delovi_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //*/*/*/*/*/*/*/*/*/**********

            listBoxAutomobili.Items.Clear();
            listBoxPopravke.Items.Clear();
            listBoxDeloviZaPopravku.Items.Clear();

            string selektovan = "";

            try
            {
                selektovan = listBoxKorisnici.SelectedItem.ToString().Split(':')[1];
            }
            catch (Exception exception)
            {
                selektovan = listBoxKorisnici.SelectedItem.ToString();
            }

            

            foreach (var Korisnici in KorisniciPovuceni)
            {


                if (Korisnici.korisnicko_ime == selektovan)
                {
                    textBox1.Text = Korisnici.korisnicko_ime;

                    izabraniKorisnik = Korisnici;

                    foreach (var Auti in Korisnici.Automobili)
                    {
                        listBoxAutomobili.Items.Add(Auti.id_automobil.ToString() + ':' + Auti.podaci);
                    }
                    
                }



            }
            DeloviPovuceni = servis.PovuciDelove();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            listBoxPopravke.Items.Clear();
            listBoxDeloviZaPopravku.Items.Clear();
            foreach (var AutomobilFor in izabraniKorisnik.Automobili)
            {



                try
                {
                    if (AutomobilFor.podaci == listBoxAutomobili.SelectedItem.ToString().Split(':')[1])
                    {
                        izabraniAutomobil = AutomobilFor;
                        foreach (var Auti in izabraniKorisnik.Automobili)
                        {
                            foreach (var VARIABLE in Auti.popravke)
                            {
                                listBoxPopravke.Items.Add(VARIABLE.id_popravke + ":" + VARIABLE.statusPopravke);
                            }

                        }

                    }
                }
                catch (Exception)
                {

                    
                }

            }
            DeloviPovuceni = servis.PovuciDelove();
        }

        private void listBoxPopravke_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                listBoxDeloviZaPopravku.Items.Clear();
                foreach (var VARIABLE in izabraniAutomobil.popravke)
                {
                    var selektovan = listBoxPopravke.SelectedItem.ToString().Split(':')[0];
                    var idPopravkeString = VARIABLE.id_popravke.ToString();
                     if (selektovan == idPopravkeString)
                     {
                    Debug.WriteLine(VARIABLE.delovi[0]);
                    //listBoxDeloviZaPopravku.Items.Add(VARIABLE.id_popravke + VARIABLE.deloviZaPoravku[0].nazivDela);
                        foreach (var delovi in VARIABLE.delovi)
                        {
                            listBoxDeloviZaPopravku.Items.Add(delovi.id + ":" + delovi.nazivDela);
                        }
                    }
                }
            }
            catch (Exception)
            {

                
            }
        }

        void ocistiKontrole()
        {
            listBox1.Items.Clear();
            listBoxDelovi.Items.Clear();
            listBoxKorisnici.Items.Clear();
            listBoxAutomobili.Items.Clear();
            listBoxPopravke.Items.Clear();
            listBoxDeloviZaPopravku.Items.Clear();

            if (!servis.proveriLogin())
            {
                servis.Login("ivan", "pass");
            }

            DeloviPovuceni = servis.PovuciDelove();
            foreach (var VARIABLE in DeloviPovuceni)
            {
                listBoxDelovi.Items.Add(VARIABLE.id.ToString() + ':' + VARIABLE.nazivDela);
                Debug.WriteLine(VARIABLE.nazivDela);
            }


            listBoxKorisnici.Items.Clear();

            if (!servis.proveriLogin())
            {
                servis.Login("ivan", "pass");
            }
            listBoxKorisnici.Items.Clear();

            KorisniciPovuceni = servis.PovuciKorisnike().ToList();
            foreach (var VARIABLE in KorisniciPovuceni)
            {
                listBoxKorisnici.Items.Add(VARIABLE.idKorisnika.ToString() + ':' + VARIABLE.korisnicko_ime);
                Debug.WriteLine(VARIABLE.korisnicko_ime);
            }

        }

        void CommandHelp()
        {
            commandOutputBox.Text += "Moguce komande: \n";
            commandOutputBox.Text += "help \n";
            commandOutputBox.Text += "adduser \n";
            commandOutputBox.Text += "deluser \n";
            commandOutputBox.Text += "addcar \n";
            commandOutputBox.Text += "delcar \n";
            commandOutputBox.Text += "addfix \n";
            commandOutputBox.Text += "delfix \n";
            commandOutputBox.Text += "addpart \n";
            commandOutputBox.Text += "delpart \n";
            commandOutputBox.Text += "For command help use commandName --help \n";

        }

        void CommandExecute()
        {

            if (!servis.proveriLogin())
            {
                return;
            }

            string komanda = commandBox.Text;

            string[] komandaDelovi = komanda.Split(' ');

            komandaDelovi[0] = komandaDelovi[0].ToLower();

            switch (komandaDelovi[0])
            {
                case "help": // adduser nameOfUser || returns user id and status
                {
                    CommandHelp();

                    break; /* optional */
                }


                case "adduser": // adduser nameOfUser || returns user id and status
                {
                    if (komandaDelovi[1] == "--help")
                    {
                        commandOutputBox.Text += "expecting  adduser nameOfUser password || returns user id and status \n";
                        break;
                    }

                    if (komandaDelovi.Length != 3)
                    {
                        commandOutputBox.Text += "Niste lepo uneli komandu molimo konsultujte help\n";
                        return;
                    }

                    if (servis.DodajKorisnika(komandaDelovi[1], komandaDelovi[2]))
                    {
                        commandOutputBox.Text += "Uspesno dodat korisnik " + komandaDelovi[1] + "\n";
                        ocistiKontrole();
                        break;
                    }
                    else
                    {
                        commandOutputBox.Text += "Nije moguce dodati korisnika  " + komandaDelovi[1] + " moguce da vec postoji\n";
                        ocistiKontrole();
                    }

                    break; /* optional */
                }

                case "deluser": // deluser nameOfUser || returns user id and status
                {
                    if (komandaDelovi[1] == "--help")
                    {
                        commandOutputBox.Text += "expecting deluser nameOfUser || returns user id and status\n";
                        ocistiKontrole();
                        break;
                    }

                    ;

                    if (servis.ObrisiKorisnika(komandaDelovi[1]))
                    {
                        commandOutputBox.Text += "Uspesno obrisan korisnik " + komandaDelovi[1] + "\n";
                            ocistiKontrole();
                        break;
                    }
                    else
                    {
                        commandOutputBox.Text += "Nije moguce obrisati korisnika  " + komandaDelovi[1] + "\n"; 
                        ocistiKontrole();
                    }
                    break; /* optional */
                }




                case "addcar":// addcar nameOfUser nameOfCar || returns status
                { 
                    if (komandaDelovi[1] == "--help")
                    {
                        commandOutputBox.Text += "expecting addcar userID nameOfCar || returns user id and status \n";
                        ocistiKontrole();
                        break;
                    }

                    if (servis.DodajAutomobilZaKorisnikaID(Convert.ToInt32(komandaDelovi[1]), komandaDelovi[2]))
                    {
                        commandOutputBox.Text += "Uspesno dodat automobil za korisnika " + komandaDelovi[1] + " sa nazivom " + komandaDelovi[2] + "\n";
                        ocistiKontrole();
                        break;
                    }
                    else
                    {
                        commandOutputBox.Text += "Nije moguce dodati automobil za korisnika  " + komandaDelovi[1] + " sa nazivom " + komandaDelovi[2] + "\n";
                        ocistiKontrole();
                    }
                    break; 
               }


                case "remcar":// addcar nameOfUser nameOfCar || returns status
                {
                    if (komandaDelovi[1] == "--help")
                    {
                        commandOutputBox.Text += "expecting remcar userID carID || returns user id and status \n";
                        ocistiKontrole();
                        break;
                    }

                    if (servis.ObrisiAutomobilZaKorisnikaID(Convert.ToInt32(komandaDelovi[1]), Convert.ToInt32(komandaDelovi[2])))
                    {
                        commandOutputBox.Text += "Uspesno obrisan automobil za korisnika " + komandaDelovi[1] + " sa nazivom " + komandaDelovi[2] + "\n";
                        ocistiKontrole();
                        break;
                    }
                    else
                    {
                        commandOutputBox.Text += "Nije moguce obrisati automobil za korisnika  " + komandaDelovi[1] + " sa nazivom " + komandaDelovi[2] + "\n";
                        ocistiKontrole();
                    }
                    break;
                }




                case "addfix":// addcar nameOfUser nameOfCar || returns status
                {
                    if (komandaDelovi[1] == "--help")
                    {
                        commandOutputBox.Text += "expecting addfix userID carID  || returns user id and status \n";
                        ocistiKontrole();
                        break;
                    }

                    if (servis.DodajPopravkuZaAutoZaKorisnika(/*UserID*/Convert.ToInt32(komandaDelovi[1]), /*CarID*/Convert.ToInt32(komandaDelovi[2]), /*statusID*/ Convert.ToInt32(komandaDelovi[3])))
                    {
                        commandOutputBox.Text += "Uspesno dodata popravka za automobil" + komandaDelovi[2] + "za korisnika " + komandaDelovi[0] + "\n";
                        ocistiKontrole();
                        break;
                    }
                    else
                    {
                        commandOutputBox.Text += "Nije moguce dodati popravku za automobil" + komandaDelovi[2] + "za korisnika " + komandaDelovi[0] + "\n";
                        ocistiKontrole();
                    }
                    break;
                }


                case "remfix":// addcar nameOfUser nameOfCar || returns status
                {
                    if (komandaDelovi[1] == "--help")
                    {
                        commandOutputBox.Text += "expecting remfix userID carID || returns user id and status \n";
                        ocistiKontrole();
                        break;
                    }

                                       
                    if (servis.ObrisiPopravkuZaAutoZaKorisnika(Convert.ToInt32(komandaDelovi[1]), Convert.ToInt32(komandaDelovi[2]), Convert.ToInt32(komandaDelovi[3])))
                    {
                        commandOutputBox.Text += "Uspesno obrisana popravka za korisnika " + komandaDelovi[1] + " automobil " + komandaDelovi[2] + " idPopravke " + komandaDelovi[3] + "\n";
                        ocistiKontrole();
                        break;
                    }
                    else
                    {
                        commandOutputBox.Text += "Neuspesno obrisana popravka za korisnika " + komandaDelovi[1] + " automobil " + komandaDelovi[2] + " idPopravke " + komandaDelovi[3] + "\n";
                            ocistiKontrole();
                    }
                    break;
                }




                case "addpart":// addcar nameOfUser nameOfCar || returns status
                {
                    if (komandaDelovi[1] == "--help")
                    {
                        commandOutputBox.Text += "expecting addpart userID carID popravkaID deoID || returns user id and status \n";
                        ocistiKontrole();
                        break;
                    }

                        if (servis.DodajDeoZaPopravkuZaAutoZaKorisnika(/*UserID*/Convert.ToInt32(komandaDelovi[1]), /*CarID*/Convert.ToInt32(komandaDelovi[2]), /*fixID*/ Convert.ToInt32(komandaDelovi[3]), /*partID*/ Convert.ToInt32(komandaDelovi[4])))
                        {
                            commandOutputBox.Text += "Uspesno dodat deo za popravku za automobil" + komandaDelovi[2] + "za korisnika " + komandaDelovi[0] + "\n";
                            ocistiKontrole();
                            break;
                        }
                        else
                        {
                            commandOutputBox.Text += "Nije moguce dodati deo u popravku za automobil" + komandaDelovi[2] + "za korisnika " + komandaDelovi[0] + "\n";
                            ocistiKontrole();
                        }
                        break;
                }


                case "rempart":// addcar nameOfUser nameOfCar || returns status
                {
                    if (komandaDelovi[1] == "--help")
                    {
                        commandOutputBox.Text += "expecting rempart userID carID fixID partID || returns user id and status \n";
                        ocistiKontrole();
                        break;
                    }


                        if (servis.ObrisiDeoZaPopravkuZaAutoZaKorisnika(/*UserID*/Convert.ToInt32(komandaDelovi[1]), /*CarID*/Convert.ToInt32(komandaDelovi[2]), /*fixID*/ Convert.ToInt32(komandaDelovi[3]), /*partID*/ Convert.ToInt32(komandaDelovi[4])))
                        {
                            commandOutputBox.Text += "Uspesno obrisan deo za popravku za auto za korisnika " + komandaDelovi[1] + " automobil " + komandaDelovi[2] + " idPopravke " + komandaDelovi[3] + "\n";
                            ocistiKontrole();
                            break;
                        }
                        else
                        {
                            
                            commandOutputBox.Text += "Neuspesno obrisan deo za popravku za  za korisnika " + komandaDelovi[1] + " automobil " + komandaDelovi[2] + " idPopravke " + komandaDelovi[3] + "\n";
                            ocistiKontrole();
                        }
                        break;
                }








                /* you can have any number of case statements */
                default:
                {
                    commandOutputBox.Text += "Pogresan format komande molimo konsultujte help\n";
                        break;
                } /* Optional */
                //statement(s);
            }


        }


        private void buttonExecute_Click(object sender, EventArgs e)
        {

            CommandExecute();    
        
        }

        private void commandBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                CommandExecute();
                commandBox.Text = "";
            }
        }

        private void listBoxDeloviZaPopravku_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxDelovi_SelectedIndexChanged(object sender, EventArgs e)
        {

                foreach (var VARIABLE in DeloviPovuceni)
                {

                    try
                    {

                    if (VARIABLE.nazivDela == listBoxDelovi.SelectedItem.ToString().Split(':')[1])
                    {
                        textBox1.Text = VARIABLE.nazivDela;
                        numericUpDown1.Text = VARIABLE.cena_dela.ToString();
                        numericUpDown2.Text = VARIABLE.id.ToString();

                    }
                    }
                    catch (Exception)
                    {

                    }
            }
                DeloviPovuceni = servis.PovuciDelove();


        }

        private void buttonSacuvajDeo_Click(object sender, EventArgs e)
        {
            int ID = (int)numericUpDown2.Value;
            double Cena = (Double)numericUpDown1.Value;
            servis.PromeniCenuZaIDOdDeo(ID, Cena);
            DeloviPovuceni = servis.PovuciDelove();
            int a = 2;
        }
    }
}
