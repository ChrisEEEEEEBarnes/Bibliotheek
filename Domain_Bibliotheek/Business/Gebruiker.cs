using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Bibliotheek.Business
{
    public class Gebruiker
    {
        private int _userId;
        private string _naam, _voornaam, _mail, _wachtwoord;

        public int ID
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        public string Wachtwoord
        {
            get { return _wachtwoord; }
            set { _wachtwoord = value; }
        }

        public override string ToString()
        {
            return _naam + " | " + _voornaam + " | " + _mail;
        }

        public Gebruiker()
        {
            ID= 0;
            Naam = "";
            Voornaam = "";
            Mail = "";
            Wachtwoord = "";
        }
        public Gebruiker(string naam, string voornaam, string mail, string wachtwoord)
        {
            Naam = naam;
            Voornaam = voornaam;
            Mail = mail;
            Wachtwoord = wachtwoord;
        }
    }
}
