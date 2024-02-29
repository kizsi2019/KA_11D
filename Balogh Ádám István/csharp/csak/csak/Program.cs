using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Masik pelda = new Masik(5);

            Console.WriteLine(pelda.Szam);

            Console.ReadKey();
        }
    }
}
