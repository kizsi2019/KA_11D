using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._10._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Queue<int> sor = new Queue<int>();
            sor.Enqueue(1);
            sor.Enqueue(2);
            sor.Enqueue(3);
            sor.Enqueue(4);
            while (sor.Count != 0) {
            
                Console.WriteLine(sor.Dequeue());
            }
            EZ VOLT A SOR*/

            /* HashSet<int> halmaz = new HashSet<int>() { 17, 10, 20, 43 };
             Console.WriteLine("Hozzáadás előtt" + halmaz.Count);
             halmaz.Add(17);
             Console.WriteLine("Hozzáadás után" + halmaz.Count); */

            /*Random r = new Random();
            HashSet<int> lottószámok = new HashSet<int>();
            while (lottószámok.Count > 5)
            {
                lottószámok.Add(r.Next(0, 91));
                {
                    Console.WriteLine("A sorolt lottószámok:");
                    foreach (int item in lottószámok) ;

                    Console.WriteLine(item + ",");
                } 
            } */
            HashSet<int> unió = new HashSet<int>() { 10, 32, 4, 8 };
            HashSet<int> halmaz1 = new HashSet<int>() { 20, 32, 12, 4};
            unió.UnionWith(halmaz1);

            foreach(int item in unió) Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
