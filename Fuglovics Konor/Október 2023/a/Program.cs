using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osszetett
{
    class Program
    {
        static void Main(string[] args)
        {
          /*List<int> Vlist = new List<int>(8);
            Vlist.Add(24);
            Vlist.Add(36);
            Vlist.Add(5);
            for (int i=0; i<Vlist.Count; i++)
            {
                Console.WriteLine(Vlist[i]);
            }
            foreach (var item in Vlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Capacity: {Vlist.Capacity}");
            Console.WriteLine($"Size: {Vlist.Count}");*/

            List<int> lista = new List<int>();
            lista.Add(45); lista.Add(23); lista.Add(1);
            lista.Insert(1, 53);

            Console.ReadKey();
        }
    }
}
