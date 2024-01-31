using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace még_egy_oop
{
    internal class Proba
    {
        public Proba(string n) 
        {
            Szam = n;
        }

        private string szam;
        public string Szam
        {
            get
            {
                return szam;
            }

            set
            {
                if (value.Length != 0) szam = value;
            }
        }

        public void Kiiiras()
        {
            Console.WriteLine(szam);
        }
    }
}
