using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proba pelda = new Proba(5, 5);

            Console.WriteLine(pelda.Number3);

            Console.ReadKey();
        }
    }
}
