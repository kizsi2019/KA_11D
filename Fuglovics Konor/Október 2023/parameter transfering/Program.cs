using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameter_transfering
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> oldlist = new List<int>() { 35, 23, 8};
            List<int> newlist = oldlist;
            newlist.Add(40);
            Console.Write("Contents of the old list: ");
            foreach (int item in oldlist)
            {
                Console.Write($"{item}, ");
            }
            Console.Write("\nContents of the new list: ");
            foreach (int item in newlist)
            {
                Console.Write($"{item}, ");
            }*/

            /*LinkedList<string> linkedlist1 = new LinkedList<string>();
            linkedlist1.AddLast("castle");
            linkedlist1.AddLast("coffee");
            linkedlist1.AddFirst("car");
            foreach (string item in linkedlist1)
            {
                Console.WriteLine(item);
            }
            linkedlist1.RemoveFirst();
            Console.WriteLine("");
            foreach (string item2 in linkedlist1)
            {
                Console.WriteLine(item2);
            }*/

            /*LinkedList<string> linkedlist2 = new LinkedList<string>();
            linkedlist2.AddLast("castle");
            linkedlist2.AddLast("coffee");
            linkedlist2.AddFirst("car");
            LinkedListNode<string> node1 = linkedlist2.First;
            Console.WriteLine(node1);*/

            /*LinkedList<string> linkedlist3 = new LinkedList<string>();
            linkedlist3.AddLast("castle");
            linkedlist3.AddLast("coffee");
            linkedlist3.AddFirst("car");
            LinkedListNode<string> node2 = linkedlist3.First;
            while (node2 != null)
            {
                Console.WriteLine(node2.Value);
                node2 = node2.Next;
            }*/

            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"color1", "piros"}, {"color2", "kék"}
            };
            foreach (KeyValuePair<string, string> item in dict)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            if (dict.ContainsKey("green"))
            {
                Console.WriteLine("There's green in the dictionary.");
            }
            else
            {
                Console.WriteLine("There's no green.");
            }

            Console.ReadKey();
        }
    }
}
