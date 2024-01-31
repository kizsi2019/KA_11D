using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace orvosi_nobeldijasok
{
    internal class dijazott
    {
        public int Év { get; private set; }
        public string Név { get; private set; }
        public string SzületésHalálozás { get; private set; }
        public string Országkód { get; private set; }
        public dijazott(string sor)
        {
            string[] m = sor.Split(';');
            Év = int.Parse(m[0]);
            Név = m[1];
            SzületésHalálozás = m[2];
            Országkód = m[3];
        }
    }
}
