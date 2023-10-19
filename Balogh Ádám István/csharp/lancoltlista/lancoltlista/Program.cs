using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lancoltlista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*LinkedList<string> láncoltlista = new LinkedList<string>();
            láncoltlista.AddLast("vár");
            láncoltlista.AddLast("kávé");
            láncoltlista.AddFirst("autó");
            //láncoltlista.RemoveFirst();
            LinkedListNode<string> csomópont = lancoltlista.First;
            foreach  (string item in láncoltlista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();*/
            Dictionary<string, string> szótár = new Dictionary<string, string>()
            {
                { "szín1", "red" },
                { "szín2", "blue" }

            };
            if (szótár.ContainsKey("blue")) Console.WriteLine("Van kék");
            else Console.WriteLine("Nincs kék");
            foreach (KeyValuePair<string, string> item in szótár)
            {
                Console.WriteLine("Kulcs: {0}, értéke: {1}", item.Key, item.Value);
            }
            Console.ReadKey();
        }

    }
}
