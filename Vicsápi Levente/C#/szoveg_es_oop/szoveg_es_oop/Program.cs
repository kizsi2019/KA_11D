using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szoveg_es_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ember pelda = new Ember("Józsi", 12);
            Console.WriteLine(pelda.Nev + " " + pelda.Kor);

            Console.ReadKey();
        }

    }
}
