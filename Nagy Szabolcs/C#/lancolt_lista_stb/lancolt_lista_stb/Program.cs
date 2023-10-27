using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lancolt_lista_stb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            LinkedList<string> láncoltlista = new LinkedList<string>();

            láncoltlista.AddLast("vár");
            láncoltlista.AddLast("kávé");
            láncoltlista.AddFirst("autó");

            Console.Write("A lista: ");
            foreach(string item in láncoltlista)
            {
                Console.Write(item + " ");
            }

            láncoltlista.RemoveFirst();

            Console.WriteLine();
            Console.Write("A lista első eleme törölve: ");
            foreach (string item in láncoltlista)
            {
                Console.Write(item + " ");
            }
            */

            /*
            LinkedList<string> láncoltlista = new LinkedList<string>();
            láncoltlista.AddLast("vár"); láncoltlista.AddLast("kávé"); láncoltlista.AddFirst("autó");
            LinkedListNode<string> csomópont = láncoltlista.Last;

            Console.WriteLine(csomópont.Value);
            */
            

            /*
            Dictionary<string, string> szótár = new Dictionary<string, string>(){
                {"szín1", "red"}, {"szín2", "blue"}
            };

            foreach(KeyValuePair<string, string> item in szótár)
            {
                Console.WriteLine("Kulcs: {0}, érték: {1}", item.Key, item.Value);
            }
            */

            Console.ReadKey();
        }
    }
}
