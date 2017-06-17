using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Runtime.Serialization;
using ProjectLibrary;


namespace ProjectLibrary
{


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

        /**
        * 
        * Funkcije za Popravke dodavanje delova
        *
        */

        [OperationContract]
        bool DodajDeoZaPopravkuZaAutoZaKorisnika(/*UserID*/ int userID, /*CarID*/ int carID, /*fixID*/ int fixID, /*partID*/ int partID);

        [OperationContract]
        bool ObrisiDeoZaPopravkuZaAutoZaKorisnika(/*UserID*/ int userID, /*CarID*/ int carID, /*fixID*/ int fixID, /*partID*/ int partID);

    }




}
