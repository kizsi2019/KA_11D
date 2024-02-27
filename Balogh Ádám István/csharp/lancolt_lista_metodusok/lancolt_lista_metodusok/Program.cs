using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lancolt_lista_metodusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            LinkedList <int> lista = new LinkedList<int>();

            
            lista.AddLast(2);
            lista.AddLast(3);
            lista.AddLast(4);
            lista.AddFirst(1);

            Console.Write("A lista:");
            foreach (var item in lista)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
            Console.Write("A lista visszafele:");
            var vissza = lista.Last;

            while (vissza != null)
            {
                Console.Write("{0} ", vissza.Value);
                vissza = vissza.Previous;
            }
            */

            /*
            LinkedList<int> szamok = new LinkedList<int>();

            //Elem hozzádása
            szamok.AddLast(1);
            szamok.AddLast(2);
            szamok.AddLast(3);

            LinkedListNode<int> sorrend = szamok.First;
            
            //Bejárás és kiírás sorrendben
            while (sorrend != null)
            {
                Console.WriteLine(sorrend.Value);
                sorrend = sorrend.Next;
            }

            Console.WriteLine();

            LinkedListNode<int> forditott = szamok.Last;

            //Bejárás és kiírás visszafelé
            while (forditott != null)
            {
                Console.WriteLine(forditott.Value);
                forditott = forditott.Previous;
            }
            */

            List<int> lista = new List<int>(0);

            lista.Add(4);
            lista.Add(1);
            lista.Add(5);
            lista.Add(3);
            lista.Add(8);
            lista.Add(2);
            lista.Add(6);
            lista.Add(9);
            lista.Add(7);

            lista.Sort();

            Console.Write("Lista növekvő sorrendben: ");

            foreach (int i in lista) Console.Write("{0} ", i);

            lista.Reverse();

            Console.Write("\nLista visszafelé: ");

            foreach(int i in lista) Console.Write("{0} ", i);

            Console.WriteLine("\nA lista kapacitása: {0}", lista.Capacity);
            Console.ReadKey();
        }

    }
}
