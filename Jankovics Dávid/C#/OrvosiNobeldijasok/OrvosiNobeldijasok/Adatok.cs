using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrvosiNobeldijasok
{
    public class Adatok
    {
        public int Ev { get; private set; }
        public string Nev { get; private set; }
        
        public string SzuletesHalalozas { get; private set; }
        public string Orszagkod { get; private set; }

        public Adatok(string sor)
        {
            string[] adatok = sor.Split(';');
            Ev = int.Parse(adatok[0]);
            Nev = adatok[1];
            SzuletesHalalozas = adatok[2];
            Orszagkod = adatok[3];
        }
    }
}
