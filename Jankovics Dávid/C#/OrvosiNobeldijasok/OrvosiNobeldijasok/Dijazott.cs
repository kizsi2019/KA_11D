using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrvosiNobeldijasok
{
    internal class Dijazott
    {
        public int Év { get; private set; }
        public string Név { get; private set; }
        public string SületésHalálozás { get; private set; }
        public string Országkód { get; private set; }
        public Dijazott(string sor) 
        {
            string[] m = sor.Split(';');
            Év = int.Parse(m[0]);
            Név = m[1];
            SületésHalálozás = m[2];
            Országkód = m[3];
        }
    }
}
