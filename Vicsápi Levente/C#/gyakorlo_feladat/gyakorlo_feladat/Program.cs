using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlo_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Queue<int> sor = new Queue<int>();

            sor.Enqueue(1);
            sor.Enqueue(2);
            sor.Enqueue(3);
            sor.Enqueue(4);

            foreach (int i in sor)
            {
                Console.WriteLine(i);
            }
            */

            /*
            HashSet<int> halmaz = new HashSet<int>() { 17, 10, 20, 43};

            Console.WriteLine("Hozzáadás előtt: " + halmaz.Count);
            halmaz.Add(17);
            Console.WriteLine("Hozzáadás után: " + halmaz.Count);
            */

            /*
            Random r = new Random();
            HashSet<int> lottószámok = new HashSet<int>();

            while (lottószámok.Count < 5)
            {
                lottószámok.Add(r.Next(0, 91));
            }

            foreach (int item in lottószámok)
            {
                Console.WriteLine(item);
            }
            */

            /*
            HashSet<int> a = new HashSet<int>() { 10, 22, 4, 8};
            HashSet<int> b = new HashSet<int>() { 10, 32, 12, 4};

            a.UnionWith(b);

            foreach (int item in a) Console.WriteLine(item);
            */

            /*
            HashSet<int> a = new HashSet<int>() { 10, 32, 4, 8};
            HashSet<int> b = new HashSet<int>() { 20, 32, 12, 4};

            a.SymmetricExceptWith(b);

            foreach (int item in a) Console.WriteLine(item);
            */


            Console.ReadKey();
            
        }
    }
}
