using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paraméter_átadás
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
         List<int> Régilista = new List<int>() { 20, 31, 10};
            List<int> újralista = Régilista;
            újralista.Add(40);
            Console.WriteLine("Régilista Tartalma");
              foreach (int i in Régilista) Console.WriteLine(i);
            Console.WriteLine("Újgilista Tartalma");
            foreach (int i in újralista) Console.WriteLine(i);
       
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("vár");
            list.AddLast("káve");
            list.AddFirst("Autó");

            foreach (string item in list) Console.WriteLine(item);
            list.RemoveFirst();
            Console.WriteLine("Removed:");
            foreach (string item in list) Console.WriteLine(item);
                
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("vár");
            list.AddLast("káve");
            list.AddFirst("Autó");

            LinkedListNode<string> Csomi = list.First;
            Console.WriteLine(Csomi.Value);
             */


            Dictionary<string, string> Szótár = new Dictionary<string, string>()
            {
                {"Szín 1", "red" }, {"SzÍn2", "Blue"} , {"Álat1", "DOg"}//...
            };
            foreach (KeyValuePair<string, string> item in Szótár)
            {
                Console.WriteLine("Kulcs: {0}, Értéke {1}" ,item.Key, item.Value);
            }
            if (Szótár.ContainsValue("Blue")) Console.WriteLine("Van zöld");    

            Console.ReadKey();
            System.Diagnostics.Process.Start("Notepad");
            Random random = new Random();




            while (true)
            {
                int h = random.Next(1, 59);
                int w = random.Next(1, 59);
                Console.SetWindowSize(w, h);
            }
        }
    }
}
