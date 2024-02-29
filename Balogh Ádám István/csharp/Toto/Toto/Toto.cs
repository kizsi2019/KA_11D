using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
        class EredmenyElemzo
        {
            public int Ev { get; set; }
            public int Het { get; set; }
            public int Fordulo { get; set; }
            public int T13pl { get; set; }
            public int Ny13pl { get; set; }

            public string Eredmenyek;

            private int DontetlenekSzama
            {
                get
                {
                    return Megszamol('X');
                }
            }

            private int Megszamol(char kimenet)
            {
                int darab = 0;
                foreach (var i in Eredmenyek)
                {
                    if (i == kimenet) darab++;
                }
                return darab;
            }

            public bool NemvoltDontetlenMerkozes
            {
                get
                {
                    return DontetlenekSzama == 0;
                }
            }

            public EredmenyElemzo(string sor) // konstruktor
            {
                string[] m = sor.Split(';');
                Ev = int.Parse(m[0]);
                Het = int.Parse(m[1]);
                Fordulo = int.Parse(m[2]);
                T13pl = int.Parse(m[3]);
                Ny13pl = int.Parse(m[4]);
                Eredmenyek = m[5];
            }
        }    
}
