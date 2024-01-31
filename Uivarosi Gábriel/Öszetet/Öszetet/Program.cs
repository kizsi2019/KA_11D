using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öszetet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   Random rand = new Random();
               while (true)
               {
                   int w = rand.Next(1, 59);
                   int h = rand.Next(1, 59);
                   Console.SetWindowSize(w, h);
               }
            */
            /*
           List<int> lista = new List<int>(8);
               lista.Add(12);
               lista.Add(43);
               lista.Add(2);
               Console.WriteLine("Kapacítás" +lista.Capacity);
               Console.WriteLine("MÉRETE" +lista.Count);
               foreach (int i in lista) Console.WriteLine(i);
               for (int i = 0; i < lista.Count; i++) Console.WriteLine(lista[i]);
               Console.ReadLine();
              */
              /*
            List<int> list = new List<int>();
            list.Add(12); list.Add(43); list.Add(2);
            Console.WriteLine("EREDETI");
            foreach (int i in list) Console.WriteLine(i);
            list.Insert(1, 31);
            Console.WriteLine("Módositót");
            foreach (int i in list) Console.WriteLine( i);
            list.Remove(12);
            list.RemoveAt(2);
            Console.WriteLine("REMOVED");
            foreach (int i in list) Console.WriteLine(i);

            List<int> list2 = new List<int>() { 10, 23 ,4, 30 ,12};
            Console.WriteLine("KK" +list2.Capacity);
            list2.Clear();
            // Nem Törli a kapacítást csak az elemektet!
            Console.WriteLine("KK" + list2.Capacity);
            */

            List<string> list = new List<string>() { "banán", "alma", "Körte", "Narancs", "Kiwi"};
            list.Sort();
            foreach (string s in list) Console.WriteLine(s);
            if (list.Contains("Körte"))
            {
                Console.WriteLine("Van Körte, Indexe:" +list.LastIndexOf("Körte"));
            } else
            {
                Console.WriteLine("NINCS KÖRTE :(");
            }
            string[] tömb = list.ToArray();
            foreach (string item in tömb) Console.WriteLine(item);
            List<string> list2 = tömb.ToList();
            foreach (string item in list2) Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
