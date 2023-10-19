using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace lancoscumo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* LinkedList<string> lancoltlista = new LinkedList<string>();
             lancoltlista.AddLast("vár");
             lancoltlista.AddLast("kávé");
             lancoltlista.AddFirst("autó");
             lancoltlista.RemoveFirst();
             LinkedListNode<string> csomópont = lancoltlista.First;
             foreach (string item in lancoltlista)
             {
                 Console.WriteLine(item);
             }
             Console.ReadKey();*/
            Dictionary<string, string> dic = new Dictionary<string, string>();  
            {
                { "piros", "red"}, { "kék", "blue"} //...
            };
        foreach (KeyValuePair<string, string> item in szótár)
            {
                Console.WriteLine("kulcs: {0}, értéle: {1}", item.Key, item.Value);
            }
            if (szótár.containskey("zöld")) Console.WriteLine("van zöld");
            else Console.WriteLine()
        }
    }
}
