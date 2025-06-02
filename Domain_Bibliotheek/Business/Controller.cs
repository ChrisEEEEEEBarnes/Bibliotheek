using Domain_Bibliotheek.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Bibliotheek.Business
{
    public class Controller
    {
        //declaratie variabelen
        private Persistence.BoekenMapper _boekmap;
        private Boeken _boek;
        private List<Boeken> _boekLijst;

        private Gebruiker _gebruiker;
        private Persistence.GebruikersMapper _gebruikermap;
        private List<Gebruiker> _gebruikerLijst;
        public Controller()
        {
            _boek = new Boeken();
            _boekmap = new Persistence.BoekenMapper();
            _boekLijst = _boekmap.Overzicht_Boeken();
            _gebruiker = new Gebruiker();
            _gebruikermap= new Persistence.GebruikersMapper();
            _gebruikerLijst = _gebruikermap.Overzicht_Gebruikers();
        }
        //Roept je boekenlijst op
        public List<Boeken> GetBoeken
        {
            get { return _boekLijst; }
            set { _boekLijst = value; }
        }
        public void AddBoek(string Titel, string ISBN, int Graad, int Blz, int GenreID)
        {
            Boeken b = new Boeken();
            b.Titel = Titel;
            b.ISBN = ISBN;
            b.Graad = Graad;
            b.Blz = Blz;
            b.GenreID = GenreID;
            _boekmap.AddBoek(b);
        }
        public void RemoveBoek(int bID)
        {
            Boeken b = new Boeken();
            b.BoekID = bID;
            _boekmap.DeleteBoek(b);
        }
        public List<Gebruiker> GetGebruikers
        {
            get { return _gebruikerLijst; }
            set { _gebruikerLijst = value; }
        }
        public void AddGebruiker(string NaamC, string VoornaamC, string MailC, string WachtwoordC)
        {
            Gebruiker g = new Gebruiker();
            g.Naam = NaamC;
            g.Voornaam = VoornaamC;
            g.Mail = MailC;
            g.Wachtwoord = WachtwoordC;
            _gebruikermap.AddGebruiker(g);
        }
        public void RemoveGebruiker(int gID)
        {
            Gebruiker g = new Gebruiker();
            g.ID = gID;
            _gebruikermap.DeleteGebruiker(g);
        }
    }
} 