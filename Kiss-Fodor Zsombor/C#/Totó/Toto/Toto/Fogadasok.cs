using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    public class Fogadasok
    {
        public int Ev {  get; private set; }
        public int Het { get; private set; }
        public int Fordulo { get; private set; }
        public int Telitalalat { get; private set; }
        public int NyertPenz { get; private set; }
        public string Eredmenyek { get; private set; }

        public Fogadasok(string sor) 
        {
            string[] mezok = sor.Split(';');
            int Ev = int.Parse(mezok[0]);
            int Het = int.Parse(mezok[1]);
            int Fordulo = int.Parse(mezok[2]);
            int Telitalalat = int.Parse(mezok[3]);
            int NyertPenz = int.Parse(mezok[4]);
            Eredmenyek = mezok[5];
        }
    }
}
