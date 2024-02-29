using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adatbekeres
{
    public class Adatbekeres
    {
        private string nev;
        public string Nev
        {
            get
            {
                return nev;
            }

            set
            {
                if (value.Length != 0) nev = value;
                else throw new Exception("A mező nem lehet üres");
            }
        }

        private int kor;
        public int Kor
        {
            get
            {
                return kor;
            }

            set
            {
                if (value.ToString().Length != 0) kor = value;
                else throw new Exception("A mező nem lehet üres");
            }
        }

        public Adatbekeres(string nev, int kor)
        {
            Nev = nev;
            Kor = kor;
        }
    }
}
