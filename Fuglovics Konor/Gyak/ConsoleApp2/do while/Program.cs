using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = -1;
            do
            {
                try
                {
                    Console.WriteLine("Adj meg egy páros számot 1 és 10 között!");
                    string text = Console.ReadLine();
                    num = Convert.ToInt32(text);
                }
                catch (Exception)
                {
                    num = -1;
                }
            }
            while ((num < 1) || (num > 10) || ((num % 2) != 0));

            Console.WriteLine($"A megadott szám: {num}");
            Console.ReadKey();
        }
    }
}
