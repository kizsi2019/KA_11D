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

            /*List<int> lista = new List<int>();
            lista.Add(45); lista.Add(23); lista.Add(1);
            lista.Insert(1, 53);
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }*/

            /*List<int> list2 = new List<int>() { 12,24,3 };
            list2.Remove(24);
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }*/

            /*List<int> list3 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            list3.Clear();
            Console.WriteLine($"Capacity after deleting: {list3.Capacity}, and size: {list3.Count}");*/

            /*List<string> list4 = new List<string>() { "banana", "apple", "pear", "orange", "kiwi"};
            list4.Sort();
            foreach (string item in list4)
            {
                Console.WriteLine(item);
            }
            if (list4.Contains("pear"))
            {
                Console.WriteLine("There's pear in the list.");
            }
            int index = list4.IndexOf("pear");
            if (index != -1)
            {
                Console.WriteLine($"There is a string called 'pear'. Index: {index}");
            }*/

            List<int> list5 = new List<int>() {84, 1, 40};
            int[] tomb = list5.ToArray();
            foreach (var item in tomb)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
