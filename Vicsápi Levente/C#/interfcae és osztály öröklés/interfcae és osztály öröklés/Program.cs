using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfcae_és_osztály_öröklés
{
    class Alaposztály 
    {
        public void Metódus() { Console.WriteLine("Metódus1 hívva"); }
    }

    interface IInterfész1
    {
        void Metódus2();
    }

    interface IInterfész2
    {
        void Metódus3();
    }

    class Örököltosztály : Alaposztály, IInterfész1, IInterfész2 
    {
        public void Metódus2() { Console.WriteLine("Metódus2 hívva"); }
        public void Metódus3() { Console.WriteLine("Metódus3 hívva"); }
    }

    class Program
    {
        static void Main(string[] args) 
        {
            Örököltosztály örökölt = new Örököltosztály();

            örökölt.Metódus();
            örökölt.Metódus2();
            örökölt.Metódus3();

            Console.ReadKey();
        }
    }
}
