using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Bibliotheek.Business
{
    public class Boeken
    { 
        private int  _graad, _blz, _boekId;
        private string _titel, _ISBNNummer;


        public string ISBN
        {
            get { return _ISBNNummer; }
            set { _ISBNNummer = value; }
        }

        public int Graad
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
            return _titel + " | " + _ISBNNummer.ToString() + " | " + _graad.ToString() + _blz.ToString();        
        }

        public Boeken()
        {
            Titel = "";
            ISBN = "";
            Graad= 0;
            Blz= 0;
        }

        public Boeken(string titel, string isbn, int graad,int blz)
        {
            Titel = titel;
            ISBN = isbn;
            Graad = graad;
            Blz = blz;
        }

        public Boeken(int boekid)
        {
            BoekID=boekid;
        }
    }
}
