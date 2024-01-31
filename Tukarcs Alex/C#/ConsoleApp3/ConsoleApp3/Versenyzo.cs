using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukkMaraton2019
{
    public class Versenyzo
    {
        public string Rajtszam { get; private set; }
        public string Kategoria { get; private set; }
        public string Nev { get; private set; }
        public string Egyesület { get; private set; }
        public string Tav { get; private set; }

        public TimeSpan Ido { get; private set; }

        public bool NoiVersenyzo
        {
            get
            {
                return Kategoria.Last() == 'n';
            }
        }

        public Versenyzo(string sor)
        {
            string[]
        }
    }
}