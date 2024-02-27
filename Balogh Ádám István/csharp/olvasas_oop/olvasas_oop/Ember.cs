using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olvasas_oop
{
    public class Ember
    {
        public string Nev { get; private set; }
        public string Kor { get; private set; }
        public string Varos { get; private set; }

        public Ember(string sor) 
        {
            string[] m = sor.Split(',');
            Nev = m[0];
            Kor = m[1];
            Varos = m[2];
        }

    }
}
