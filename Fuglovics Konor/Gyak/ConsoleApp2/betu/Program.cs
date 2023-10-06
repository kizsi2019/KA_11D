using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace betu
{
    class Program
    {
        static void Main(string[] args)
        {
            var abc = "abcdefghijklmnopqrstuvwxyz";
            foreach (var letter in abc)
            {
                Console.Write($"{letter}, ");
            }
            Console.ReadKey();
        }
    }
}
