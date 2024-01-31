using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrvosiNobeldijasok1
{
    internal class Díjazott
    {
        public int Év { get; private set; }
        public string Nev { get; private set; }

        public string SzuletesHalalozas { get; private set; }
        public string Orszagkod { get; private set; }

        public Díjazott(string sor)
        {
            string[] Díjazott = sor.Split(';');
            Év = int.Parse(Díjazott[0]);
            Nev = Díjazott[1];
            SzuletesHalalozas = Díjazott[2];
            Orszagkod = Díjazott[3];
        }

    }
}