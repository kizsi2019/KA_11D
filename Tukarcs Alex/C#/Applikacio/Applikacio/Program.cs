using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Applikacio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Queue<int> sor = new Queue<int>();
            // sor.Enqueue(1); sor.Enqueue(2); sor.Enqueue(3); sor.Enqueue(4);
            // while (sor.Count != 0)
            // {
            //    Console.WriteLine(sor.Dequeue());
            // }
            // Console.ReadKey();


            // Random r = new Random();
            // HashSet<int> lottószámok = new HashSet<int>();
            // while (lottószámok.Count < 5)
            // {
            //     lottószámok.Add(r.Next(0, 91));
            // }
            // Console.WriteLine("A sorolt lottószámok: ");
            // foreach (int item in lottószámok)
            // {
            //     Console.WriteLine(item + ", ");
            // }
            // Console.ReadKey();

            // HashSet<int> unio = new HashSet<int>() { 10, 32, 4, 8};
            // HashSet<int> halmaz1 = new HashSet<int>() { 20, 32, 12, 4};
            // unio.UnionWith(halmaz1);
            // foreach (int item in unio)
            // {
            //     Console.WriteLine(item);
            // }
            
            HashSet<int> alaphalmaz = new HashSet<int>() {  10, 32, 4, 8};
            HashSet<int> halmaz1 = new HashSet<int>() { 20, 32, 12, 4 };
            alaphalmaz.SymmetricExceptWith(halmaz1);
            foreach (int i in alaphalmaz)
            {
                Console.WriteLine(i);
            }


            Console.ReadKey();

        }
    }
}
