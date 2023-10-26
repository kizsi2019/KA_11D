using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameteratadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> regilista = new List<int>() { 20, 31, 10 };
            List<int> ujlista = regilista;
            ujlista.Add(40);
            Console.WriteLine("Régilista tartalma: ");
            foreach (int item in regilista)
            {
                Console.WriteLine(item + ", ");
            }
            Console.WriteLine("\nÚjlista tartalma: ");
            foreach (int item in ujlista)
            {
                Console.WriteLine(item + ", ");
            }
            */

            /*
            LinkedList<string> lancoltlista = new LinkedList<string>();
            lancoltlista.AddLast("vár");
            lancoltlista.AddLast("kávé");
            lancoltlista.AddFirst("autó");
            foreach (string item in lancoltlista)
            {
                Console.WriteLine(item);
            }
            lancoltlista.RemoveFirst();

            */

            /*
            LinkedList<string> lancoltlista = new LinkedList<string>();
            lancoltlista.AddLast("vár"); lancoltlista.AddLast("kávé"); lancoltlista.AddFirst("autó");
            LinkedListNode<string> csomopont = lancoltlista.First;
            Console.WriteLine(csomopont);
            while (csomopont != null)
            {
                Console.WriteLine(csomopont.Value);
                csomopont = csomopont.Next;
            }
            */

            Dictionary<string, string> szotar = new Dictionary<string, string>()
            {
                {"piros", "red"}, {"kék", "blue"}
            };

            foreach (KeyValuePair<string, string> item in szotar)
            {
                Console.WriteLine("Kulcs: {0}, értéke: {1}", item.Key, item.Value);
            }
            if (szotar.ContainsKey("kék")) Console.WriteLine("Van kék");
            else Console.WriteLine("Nincs kék");
            Console.ReadKey();
        }
    }
}
