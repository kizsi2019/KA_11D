using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osszetett
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> lista = new List<int>(8);

            lista.Add(12);
            lista.Add(43);
            lista.Add(2);
            
            
            Console.WriteLine("Kapacitása: " + lista.Capacity);
            Console.WriteLine("Mérete: " + lista.Count);
            

            
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }
            */

            /*
            List<int> lista = new List<int>() {10,23,4};

            Console.Write("Eredeti: ");
            foreach (int i in lista)
            {
                Console.Write(" " + i);
            }

            

            lista.Insert(1, 31);

            Console.WriteLine();

            Console.Write("Módosított: ");

            foreach (int i in lista)
            {
                Console.Write(" " + i);
            }

            lista.Remove(10);
            Console.WriteLine();
            Console.Write("Törölt: ");

            foreach (int i in lista)
            {
                Console.Write(" " + i);
            }


            lista.Clear();

            Console.WriteLine();
            Console.WriteLine("A lista kapacitása: {0}, Mérete: {1}", lista.Capacity, lista.Count);

            List<string> tömb = new List<string> { "banán", "alma", "körte", "narancs", "kiwi" };
            tömb.Sort();

            Console.WriteLine();
            Console.Write("Lista: ");

            foreach(string i in tömb)
            {
                Console.Write(" " + i);
            }
            */

            List<int> lista = new List<int>() {20, 31, 10};
            int[] tömb = lista.ToArray();


            List<string> gyümik = new List<string> { "banán", "alma", "körte", "narancs", "kiwi" };

            int index = gyümik.IndexOf("körte");
            if (index != -1) Console.WriteLine("Van körte, indexe: " + index);

            Console.WriteLine();
            foreach (int item in tömb)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
