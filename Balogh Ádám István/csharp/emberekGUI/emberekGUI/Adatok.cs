using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emberekGUI
{
    public class Adatok
    {
        public string Nev { get; set; }

        public string Kor { get; set;}

        public string Varos { get; set;}

        public Adatok(string nev, string kor, string varos) 
        {
            Nev = nev; 
            Kor = kor; 
            Varos = varos;
        }

    }
}
