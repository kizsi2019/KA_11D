using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csakugy2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<char> sor = new Queue<char>();

            Console.Write("Adj meg egy mondatot ");
            string szo = Console.ReadLine();

            foreach (char s in szo) 
            {
                sor.Enqueue(s);
            }

            while (sor.Count > 0)
            {
                var karakter = sor.Dequeue();
                Console.Write(karakter);
            }

            Console.ReadKey();
        }
    }
}
