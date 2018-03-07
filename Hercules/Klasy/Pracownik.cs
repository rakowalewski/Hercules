using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hercules.Klasy
{
    public class Pracownik
    {
        private int idPrzywilej;
        private string imie;
        private string nazwisko;
        private string login;
        private string haslo;

        public int IdPrzywilej
        {
            get { return idPrzywilej; }
            set { idPrzywilej = value; }
        }
        

        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }
        

        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }
        

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        

        public string Haslo
        {
            get { return haslo; }
            set { haslo = value; }
        }


    }
}
