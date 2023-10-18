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
            List<int> lista = new List<int>(8);
            lista.Add(12);
            lista.Add(43);
            lista.Add(2);

            Console.WriteLine("kapcítás: " + lista.Capacity);
            Console.WriteLine("tagok száma:" + lista.Count);

            Console.WriteLine("------");
            Console.WriteLine("lista tagjai: ");
            for (int i = 0; i < lista.Count; i++) 
            {
                Console.WriteLine(lista[i]);
            }

            /*
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }
            */

            Console.WriteLine("------");
            Console.WriteLine("első helyre (0. index) elhelyeztünk egy számot (1)");
            lista.Insert(0, 1);

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.WriteLine("------");

            lista.Remove(0);

            Console.WriteLine("kitörültük a lista első tagját");

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.WriteLine("kapcítás: " + lista.Capacity);
            Console.WriteLine("tagok száma:" + lista.Count);
            Console.WriteLine("------");

            Console.WriteLine("eltöröltük a lista összes tagját");
            lista.Clear();
            Console.WriteLine("kapcítás: " + lista.Capacity);
            Console.WriteLine("tagok száma:" + lista.Count);

            Console.WriteLine("------");
            Console.WriteLine("stringes lita");
            Console.WriteLine("------");

            List<string> stringa = new List<string>()
            {
                "gheci", "akma"
            };
            stringa.Sort();
            foreach (string s in stringa) 
            { 
                Console.WriteLine(s); 
            }

            int index = stringa.IndexOf("akma");
            if ( index != -1 )
            {
                Console.WriteLine(index);
                Console.WriteLine("az akma szó indexe: " + index);
            }
            Console.WriteLine("------");

            int[] tomb = lista.ToArray();

            Console.WriteLine("tömb tagjai");
            foreach (int i in tomb) 
            { 
                Console.WriteLine(i); 
            }

            Console.WriteLine("------");
            Console.WriteLine("paraméter átadás");
            List<int> regilista = new List<int>() { 20, 31, 10};
            List<int> ujlista = regilista;
            ujlista.Add(40);
            Console.Write("régi lista tartalma: ");
            foreach(int i in regilista)
            {
                Console.Write(i + ", ");
            }



            Console.ReadLine();
        }
    }
}
