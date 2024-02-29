using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public class Versenyzo
        {
            public string Rajtszam { get; private set; }
            public string Kategoria { get; private set; }
            public string Nev { get; private set; }
            public string Egyesulet { get; private set; }
            public string Tav { get; private set; }
            public TimeSpan Ido { get; private set; }
            public Versenyzo(string sor) 
            {
                string[] m = sor.Split(',');
                Rajtszam = m[0];
                Kategoria = m[1];
                Nev = m[2];
                Egyesulet = m[3];
                int ora = int.Parse(m[4].Split(':')[0]);
                int perc = int.Parse(m[4].Split(':')[0]);
                int mp = int.Parse(m[4].Split(':')[0]);
                Tav = m[4];
            }
        }
    }
}
