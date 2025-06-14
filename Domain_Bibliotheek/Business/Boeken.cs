﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Bibliotheek.Business
{
    public class Boeken
    { 
        private int  _graad, _blz, _boekId, _genreID;
        private string _titel, _ISBNNummer, _genre, _oISBN;

        public string OISBN
        {
            get { return _oISBN; }
            set { _oISBN = value; }
        }
        public string ISBN
        {
            get { return _ISBNNummer; }
            set { _ISBNNummer = value; }
        }
        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
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

        public override string ToString()
        {
            return _titel + " | " + _genre + " | " + _blz.ToString() + " | " + _graad.ToString() + " | " + _ISBNNummer.ToString();        
        }

        public Boeken()
        {
            Titel = "";
            ISBN = "";
            Graad = 0;
            Blz = 0;
            Genre = "";
        }

        public Boeken(string isbn, string titel, int blz,int graad, string genre)
        {
            Titel = titel;
            ISBN = isbn;
            Blz = blz;
            Graad = graad;
            Genre= genre;
        }
        //toevoegen boeken
        public Boeken(string isbn, string titel,  int graad, int blz, int genreid)
        {
            Titel = titel;
            ISBN = isbn;
            Blz = blz;
            Graad = graad;
            GenreID = genreid;
        }
        //update boeken
        public Boeken(string oisbn,string titel, string isbn, int graad, int blz, int genreid)
        {
            OISBN = oisbn;
            Titel = titel;
            ISBN = isbn;
            Blz = blz;
            Graad = graad;
            GenreID = genreid;
        }

        public Boeken(int boekid)
        {
            BoekID=boekid;
        }
    }
}
