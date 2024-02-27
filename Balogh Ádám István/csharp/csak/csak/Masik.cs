using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csak
{
    public class Masik
    {
        public Masik(int szam)
        {
           Szam = szam;
        }
        public int Szam { get; private set; }

        public int szam
        {
            get
            {
                return Szam;
            }

            set 
            {
                if (Szam.ToString().Length != 0) Szam = value;

            }
        }
    }
}
