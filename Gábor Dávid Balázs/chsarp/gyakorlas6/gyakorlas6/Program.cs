using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> lista = new List<int>();
            lista.Add(12);
            lista.Add(43);
            lista.Add(2);
            for (int i = 0; i < lista.Count; i++){
                Console.WriteLine(lista[i]);
            }

            foreach (item in lista) {
                Console.WriteLine(item);
            }
                
            // Console.WriteLine("Kapacitása: " + lista.Capacity);
            // Console.WriteLine("Mérete: " + lista.Count);
            */

            /* 
            List<int> lista = new List<int>();
            lista.Add(12); lista.Add(43); lista.Add(2);
            foreach (int item in lista)
            {
                Console.WriteLine(item);
            }
            lista.Insert(1, 31);
            {
                Console.WriteLine(lista);
            }

            List<int> lista = new List<int>() { 10, 23, 4 };
            lista.Remove(23);

            List<int> lista = new List<int>() { 10, 23, 4, 30 };
            lista.RemoveAt(2);
            */

            /* 
            List<int> lista = new List<int>() { 10, 23, 4, 30, 10, 16, 19, 20, 34, 10 };
            lista.Clear();
            Console.WriteLine("Törlés után a kapacitása: {0}, mérete:{1}", lista.Capacity, lista.Count);
            */

            /*
            List<string> lista = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi" };
            lista.Sort();
            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

            */
            /* 
            List<string> lista = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi" };
            if (lista.Contains("körte")) Console.WriteLine("Van körte");
            */ 

            /* 
            List<string> lista = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi" };
            int index = lista.IndexOf("körte");
            if (index != -1) Console.WriteLine("Van körte, indexe: " + index);
            */ 

            /*
            List<int> lista = new List<int>() { 20, 31, 10 };
            int[] tömb = lista.ToArray();
            foreach (int item in tömb)
            {
                Console.WriteLine(item);
            }
            */

            Console.ReadKey();
        }
    }
}
