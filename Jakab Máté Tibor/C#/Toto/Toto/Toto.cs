using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
        class Csekold_Le
        {
            public int Ev { get; set; }
            public int Het { get; set; }
            public int Fordulo { get; set; }
            public int T13p1 { get; set; }
            public int Ny13p1 { get; set; }

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

            public Csekold_Le(string sor)
            {
                string[] m = sor.Split(';');
                Ev = int.Parse(m[0]);
                Het = int.Parse(m[1]);
                Fordulo = int.Parse(m[2]);
                T13p1 = int.Parse(m[3]);
                Ny13p1 = int.Parse(m[4]);
                Eredmenyek = m[5];
            }

        public static implicit operator int(Csekold_Le v)
        {
            throw new NotImplementedException();
        }
    }    
}
