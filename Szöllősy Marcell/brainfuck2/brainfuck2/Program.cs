﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brainfuck2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<int> régilista = new List<int>() { 20, 31, 10 };
            List<int> újlista = régilista;
            újlista.Add(40);
            Console.Write("régilista tartalma: ");
            foreach (int item in régilista)
            {
                Console.Write(item + ",");
            }
            Console.Write("újlista tartalma: ");
            foreach (int item in újlista)
            {
                Console.Write(item + ", ");
            }*/

            /*LinkedList<string> láncoltlista = new LinkedList<string>();
            láncoltlista.AddLast("Vár");
            láncoltlista.AddLast("Kávé");
            láncoltlista.AddFirst("Autó");
            foreach (string item in láncoltlista)
                láncoltlista.RemoveFirst();
            {
                Console.WriteLine(item);
            }*/

            /*LinkedList<string> láncoltlista = new LinkedList<string>();
            láncoltlista.AddLast("Vár");
            láncoltlista.AddLast("Kávé");
            láncoltlista.AddFirst("Autó");
            LinkedListNode<string> csomópont = láncoltlista.First;
            Console.WriteLine(csomópont);
            Console.ReadKey();*/

            /*LinkedList<string> láncoltlista = new LinkedList<string>();
            láncoltlista.AddLast("Vár");
            láncoltlista.AddLast("Kávé");
            láncoltlista.AddFirst("Autó");
            LinkedListNode<string> csomópont = láncoltlista.First;
            while (csomópont != null)
            {
                Console.WriteLine(csomópont.Value);
                csomópont = csomópont.Next;
            }
            Console.WriteLine(csomópont);
            Console.ReadKey();*/

            /*Dictionary<string, string> szótár = new Dictionary<string, string>()
            {
                { "piros", "red"}, {"kék", "blue"} //...
            };
            Console.WriteLine();
            Console.ReadKey();*/

            /*foreach (KeyValuePair<string, string> item in szótár)
            {
                Console.WriteLine("Kulcs: {0}, értéke: {1}", item.Key, item.Value);
            }*/

            if (szótár.ContainsKey("Zöld")) Console.WriteLine("Van Zöld");
            else Console.WriteLine("Nincs Zöld");

        }
    }
}
