using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Basic
{
    class Klient
    {
        private string imie;
        private string nazwisko;
        private string pesel;
        private string adres;
        private string telefon;
        private string email;
        private string plec;

        public string Plec
        {
            get { return plec; }
            set { plec = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }

        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }


        public string Pesel
        {
            get { return pesel; }
            set { pesel = value; }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }
    }
}
