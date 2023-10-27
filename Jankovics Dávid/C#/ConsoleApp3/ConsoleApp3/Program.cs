using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Queue<int> sor = new Queue<int>();
             sor.Enqueue(1);  sor.Enqueue(2); sor.Enqueue(3); sor.Enqueue(4);
            /* while (sor.Count != 0)
             {
                 Console.WriteLine(sor.Dequeue());
             }
             foreach (int item in sor)
             {
                 Console.WriteLine(item);
             }
            HashSet<int> halmaz = new HashSet<int>() { 17, 10, 20, 43};
             Console.WriteLine("hozzáadás elött:" + halmaz.Count);
             halmaz.Add(17);
             Console.WriteLine("hozzáadás után:" + halmaz.Count);


            Random r = new Random();
             HashSet<int> lottószámok = new HashSet<int>();
             while (lottószámok.Count < 5)
             {
                 lottószámok.Add(r.Next(0,91));
             }
             Console.WriteLine("A sorsolt lottószámok: ");
             foreach (int item in lottószámok)
             {
                 Console.WriteLine(item+",");
             }*/
            HashSet<int> unio = new HashSet<int>() { 10, 32, 4, 8 };
            HashSet<int> halmaz1 = new HashSet<int>() { 20, 32, 12, 4 };
            unio.UnionWith(halmaz1);
            foreach (int item in unio)
            Console.ReadKey();
        }
    }
}
