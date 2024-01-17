using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Szuloosztaly szulo = new Szuloosztaly();
            szulo.Metodus();
            
            Leszarmazott gyerek = new Leszarmazott();
            gyerek.Metodus();
            gyerek.UjMetodus();

            Console.ReadKey();
        }
    }
}
