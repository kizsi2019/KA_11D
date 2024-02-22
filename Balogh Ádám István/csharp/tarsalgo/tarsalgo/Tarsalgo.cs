using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarsalgo
{
    public class Tarsalgo
    {
        public string Ora { get; set; }
        public string Perc { get; set; }
        public string Azonosito { get; set; }

        public string BeVagyKi { get; set; }

        public Tarsalgo(string sor)
        {
            string[] m = sor.Split(' ');
            Ora = m[0];
            Perc = m[1];
            Azonosito = m[2];
            BeVagyKi = m[3];
        }
    }
}
