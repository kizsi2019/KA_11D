using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heritance
{
    public class Leszarmazott : Szuloosztaly
    {
        public void UjMetodus()
        {
            Console.WriteLine("Ujmetodus");
        }

        public new void Metodus()
        {
            Console.WriteLine("Oroklott");
        }
    }
}
