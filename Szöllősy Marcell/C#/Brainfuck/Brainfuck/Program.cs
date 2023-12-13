using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brainfuck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<int> lista = new List<int>(8);
            lista.Add(12);
            lista.Add(43);
            lista.Add(2);
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            //Console.WriteLine("Kapacitása:" + lista.Capacity);
            //Console.WriteLine("Mérete:" + lista.Count);
            Console.ReadLine();

            /*List<int> lista = new List<int>();
            lista.Add(12); lista.Add(43); lista.Add(2);
            lista.Insert(1, 31);*/

            //List<int> lista = new List<int>() { 10, 23, 4};
            //lista.Remove(23);

            //List<int> lista = new List<int>() { 10, 23, 4, 30, 10, 16, 19, 20, 34, 10};
            //lista.Clear();
            //Console.WriteLine("Törlés után a kapacitása: {0}, mérete:{1}", lista.Capacity, lista.Count);

            /*List<string> list = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi"};
            list.Sort();
            foreach (string item in lista)
            {
                Console.Writeline(item);
            }*/

            //List<string> lista = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi"};
            //if (lista.Contains("körte")) Console.WriteLine("Van körte");

            //List<string> lista = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi" };
            //int index = lista.IndexOf("körte");
            //if (index != -1) Console.WriteLine("Van körte, indexe:" + index);

            List<int> lista = new List<int>() { 20, 31, 10 };
            int[] tömb = lista.ToArray();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            {

            }
        }
    }
}
