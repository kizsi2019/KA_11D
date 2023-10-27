using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halmaz_kulonbseg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 6};
            HashSet<int> set2 = new HashSet<int>() { 2, 4, 7, 5, 8, 9, 10};

            var difference = set1.Except(set2);


            Console.Write("Két halmaz különbsége: ");
            foreach (var item in difference)
            {
                Console.Write("{0}, ", item);
            }

            Console.ReadKey();

        }
    }
}
