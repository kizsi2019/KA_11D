using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_gyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proba pelda = new Proba("Józsi");

            Console.WriteLine(pelda.Nev);
            Console.ReadKey();
        }
    }
}
