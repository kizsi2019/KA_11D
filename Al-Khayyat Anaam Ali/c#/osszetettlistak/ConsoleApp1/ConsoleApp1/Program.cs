using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                LinkedList<string> láncoltlista = new LinkedList<string>();
                láncoltlista.AddLast("vár");
                láncoltlista.AddLast("kávé");
                láncoltlista.AddFirst("autó");
                foreach (string item in láncoltlista){
                    láncoltlista.RemoveFirst();
                    Console.WriteLine(item);
                    
            LinkedList<string> láncoltlista = new LinkedList<string>();
            láncoltlista.AddLast("vár");
            láncoltlista.AddLast("kávé");
            láncoltlista.AddFirst("autó");
            LinkedListNode<string> csomópont = láncoltlista.First;
            {
                láncoltlista.RemoveFirst();
                Console.WriteLine(csomópont);
                Console.ReadKey();
            }
        }
    }
}
