﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halmaz
{
    internal class Program
    {
        
        static void Kiir<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.Write("{0}, ", item);
            }
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            var set1 = new HashSet<int>(new int[] { 2, 3, 4, 5, 6, 8, 1, 1 });
            var set2 = new HashSet<int>(new int[] { 1, 2, 3, 4});

            set2.Add(99);
            set2.Add(99);

            Console.WriteLine("set1:");
            Kiir(set1);
            Console.WriteLine("set2:");
            Kiir(set2);

            Console.WriteLine("set1 unio set2:");
            set1.UnionWith(set2);

            Kiir(set1);


            Console.WriteLine("set2 metszet set1:");
            set2.IntersectWith(set1);

            Kiir(set2);

            Console.ReadKey();
        }
    }
}
