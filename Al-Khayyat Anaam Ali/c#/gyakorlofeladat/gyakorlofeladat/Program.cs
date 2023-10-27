using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlofeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
         /*   Queue<int> sor = new Queue<int>();
            sor.Enqueue(1); sor.Enqueue(2); sor.Enqueue(3); sor.Enqueue(4);
            while (sor.Count != 0){
                Console.WriteLine(sor.Dequeue());
            }
            Console.ReadKey(); */

         /*   HashSet<int> halmaz = new HashSet<int>() { 17, 10, 20, 43};
            Console.WriteLine("hozzáadás előtt: " + halmaz.Count);
            halmaz.Add(17);
            Console.WriteLine("hozzáadás után" + halmaz.Count); */

            HashSet<int> unio = new HashSet<int> { 10, 32, 4, 8};
            HashSet<int> halmaz1 = new HashSet<int> { 20, 32, 12, 4 };
            unio.UnionWith(halmaz1);
            foreach (int item in unio)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
