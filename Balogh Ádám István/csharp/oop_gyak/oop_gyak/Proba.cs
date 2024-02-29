using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_gyak
{
    public class Proba
    {
        public Proba(string n)
        {
            Nev = n;
        }

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
                else 
                {
                    throw new Exception("A név mező nem lehet üres");
                }
            }
        }

    }
}
