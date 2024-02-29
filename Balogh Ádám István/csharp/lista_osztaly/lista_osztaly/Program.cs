using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_osztaly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            var lista = new List<int>();

            lista.Add(33);
            lista.Add(44);
            lista.Add(55);

            try
            {
                var x = lista[1];
                var y = lista[33];

                Console.WriteLine(x);
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Hiba történt: {0}", ex.Message);
            }
            */

            /*
            var verem = new Stack<char>();
            var be = "VEREM RULEZ";

            Console.WriteLine("Verembe írás: {0}", be);

            foreach (var item in be) {
                verem.Push(item);
            }


            Console.WriteLine("Veremből kiolvasás: ");

            while (verem.Count > 0)
            {
                var karakter = verem.Pop();
                Console.Write(karakter);
            }
            */

            var sor = new Queue<char>();
            var be = "SOR RULEZ";

            Console.WriteLine("Sorba írás: {0}", be);

            foreach (char c in be)
            {
                sor.Enqueue(c);
            }

            Console.WriteLine("Sorból kiolvasás: ");

            while (sor.Count > 0)
            {
                var karakter = sor.Dequeue();
                Console.Write(karakter);
            }

            Console.ReadKey();
        }
    }
}
