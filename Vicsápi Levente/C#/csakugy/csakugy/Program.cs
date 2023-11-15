using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csakugy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            Random rnd = new Random();

            while (set.Count < 5)
            {
                int random_num = rnd.Next(1, 11);
                set.Add(random_num);
            }
                
            foreach(int item in set)
            {
                Console.WriteLine("{0} ", item);
            }

            Console.ReadKey();
        }
    }
}
