using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Bibliotheek.Business
{
    public class Boeken
    { 
        private int  _graad, _blz, _boekId, _genreID;
        private string _titel, _ISBNNummer, _genre;


        public string ISBN
        {
            get { return _ISBNNummer; }
            set { _ISBNNummer = value; }
        }
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public int Graad
        {
            get { return _genreID; }
            set { _genreID = value; }
        }
        public int GenreID
        {
            get { return _graad; }
            set { _graad = value; }
        }
        public int BoekID
        {
            get { return _boekId; }
            set { _boekId = value; }
        }

        public int Blz
        {
            get { return _blz; }
            set { _blz = value; }
        }

        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }

        public override string ToString()
        {
            return _titel + " | " + _genre + " | "+ _ISBNNummer.ToString() + " | " + _graad.ToString() + " | " + _blz.ToString();        
        }

        public Boeken()
        {
            Titel = "";
            ISBN = "";
            Graad= 0;
            Blz= 0;
            Genre = "";
        }

        public Boeken(string titel, string isbn, int graad,int blz, string genre)
        {
            Titel = titel;
            ISBN = isbn;
            Graad = graad;
            Blz = blz;
            Genre= genre;
        }

        public Boeken(string titel, string isbn, int graad, int blz, int genreid)
        {
            Titel = titel;
            ISBN = isbn;
            Graad = graad;
            Blz = blz;
            GenreID = genreid;
        }

        public Boeken(int boekid)
        {
            BoekID=boekid;
        }
    }
}
