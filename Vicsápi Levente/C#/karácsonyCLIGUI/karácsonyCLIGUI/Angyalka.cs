using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karácsonyCLIGUI
{
    public class Angyalka
    {
        public string Nap { get; set; }
        public string Elkeszitett { get; set; }
        public string Eladott { set; get; }
        public string Maradt { set; get; }
        public Angyalka(string nap, string elkeszitett, string eladott, string maradt) 
        {
            Nap = nap;
            Elkeszitett = elkeszitett;
            Eladott = eladott;
            Maradt = maradt;
        }
        
    }
}
