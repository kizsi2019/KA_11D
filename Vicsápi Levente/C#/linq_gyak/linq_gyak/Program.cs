using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace linq_gyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int> { 1, 2, 3, 4, 5 };

            //lista elemeinek kiiratása lambda kifejezéssel
            //lista.ForEach(x => Console.WriteLine(x));

            int osszeg = lista.Aggregate((x, y) =>  x + y);

            Console.WriteLine($"A lista elemeinek összege: {osszeg}");

            Console.ReadKey();
        }
    }
}
