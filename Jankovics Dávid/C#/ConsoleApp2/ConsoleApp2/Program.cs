using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*LinkedList<string> láncoltlista = new LinkedList<string>();
             láncoltlista.AddLast("vár"); láncoltlista.AddLast("kávé");láncoltlista.AddFirst("autó");
             LinkedListNode<string> csomópont = láncoltlista.First;*/
            Dictionary<string, string> szótár = new Dictionary<string, string>()
           {
               {"piros", "red" }, {"kék", "blue"} //...
           };
            foreach (KeyValuePair<string, string> item in szótár)
            {
                Console.WriteLine("Kulcs: {0} Értéke{1}", item.Key, item.Value);
            }
            if (szótár.ContainsKey("zőld")) Console.WriteLine("van zöld");
            else Console.WriteLine("nincs zöld");
            Console.ReadKey();
        }
    }
}
