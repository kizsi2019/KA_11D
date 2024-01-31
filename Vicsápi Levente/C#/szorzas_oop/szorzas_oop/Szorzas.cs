using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szorzas_oop
{
    public class Szorzas
    {
        public int Szam1 { get; private set; }
        public int Szam2 { get; private set; }

        private int eredmeny;
        public int Eredmeny 
        {
            get
            {
                return eredmeny;
            }

            set
            {
                if (Szam1.ToString().Length != 0 && Szam2.ToString().Length != 0)
                {
                    eredmeny = value;
                }
            }

        }

        public Szorzas(int szam1, int szam2)
        {
            Szam1 = szam1;
            Szam2 = szam2;
            Eredmeny = szam1 * szam2;
        }
    }
}
