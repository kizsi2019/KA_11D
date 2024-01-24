using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szoveg_es_oop
{
    public class Ember
    {
        public string Nev { get; private set; }
        public int Kor { get; private set; }

        public Ember(string nev, int kor)
        {
            Nev = nev;
            Kor = kor;
        }

    }
}
