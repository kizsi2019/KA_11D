using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace még_egy_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proba pelda = new Proba("5");

            Console.WriteLine(pelda.Szam);

            Console.ReadKey();
        }
    }
}
