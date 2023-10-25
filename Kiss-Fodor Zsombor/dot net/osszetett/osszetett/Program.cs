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
            //új számos listát hozunk létre amibe 8 számot helyezhetünk
            List<int> lista = new List<int>(8);
            //hozzáadunk számokat
            lista.Add(12);
            lista.Add(43);
            lista.Add(2);

            //szerintem ezek self-explanatory de sebaj
            //a lista kapacítását írjuk ki
            Console.WriteLine("kapcítás: " + lista.Capacity);
            //a listában szereplő számok mennyiségét írjuk ki
            Console.WriteLine("tagok száma:" + lista.Count);

            Console.WriteLine("------");
            Console.WriteLine("lista tagjai: ");
            //leírjuk a lista tagjait
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
            //első helyre (0. index) elhelyeztünk egy számot (1)
            lista.Insert(0, 1);

            //újra leírjuk a listát
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.WriteLine("------");

            //kitörüljük a lista első tagját
            lista.Remove(0);

            Console.WriteLine("kitörültük a lista első tagját");

            //újra leírjuk a listát
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            //nem fogom ugyanazt ide írni amit már leírtam lmao
            Console.WriteLine("kapcítás: " + lista.Capacity);
            Console.WriteLine("tagok száma:" + lista.Count);
            Console.WriteLine("------");

            Console.WriteLine("eltöröltük a lista összes tagját");
            //olvasd el ami e felett van hogy tudd az alatta lévő szöveg mit csinál
            lista.Clear();
            Console.WriteLine("kapcítás: " + lista.Capacity);
            Console.WriteLine("tagok száma:" + lista.Count);

            Console.WriteLine("------");
            Console.WriteLine("stringes lita");
            Console.WriteLine("------");

            //létre hozunk egy szöveges listát és elhelyezünk benne tagokat
            List<string> stringa = new List<string>()
            {
                "gheci", "akma"
            };

            //ABC sorrendbe rakjuk a tagokat
            stringa.Sort();

            //leírjuk a tagokat, WOW!!!
            foreach (string s in stringa)
            {
                Console.WriteLine(s);
            }

            //megnézzük ha van "akma" szó akkor az hanyadik tag
            int index = stringa.IndexOf("akma");
            if (index != -1)
            {
                Console.WriteLine(index);
                Console.WriteLine("az akma szó indexe: " + index);
            }
            Console.WriteLine("------");

            //egy tömböt huzunk létra amiben benne vannak a lista tagjai
            int[] tomb = lista.ToArray();

            Console.WriteLine("tömb tagjai");
            //kiírju-
            foreach (int i in tomb)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------");
            Console.WriteLine("paraméter átadás");
            //lista tagokat adunk át egy másik listának
            List<int> regilista = new List<int>() { 20, 31, 10 };
            List<int> ujlista = regilista;
            ujlista.Add(40);

            Console.Write("régi lista tartalma: ");
            foreach (int i in regilista)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine("------");
            Console.WriteLine("linked listák");

            //láncolt listát hozunk létre
            LinkedList<string> lancoltlista = new LinkedList<string>();

            //hozzáadunk tagokat
            lancoltlista.AddLast("vár");
            lancoltlista.AddLast("kávé");
            lancoltlista.AddFirst("autó");

            //kiírjuk a linked lista tagjait
            foreach (string item in lancoltlista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------");
            Console.WriteLine("linked listák RemoveFirst/Last");

            //eltöröljük az első és utolsó tagjait
            lancoltlista.RemoveFirst();
            lancoltlista.RemoveLast();

            //kiírjuk a linked lista tagjait
            foreach (string item in lancoltlista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------");
            Console.WriteLine("linked listák Node");

            //létrehozunk egy csomópontot amibe belehelyezzük a 
            LinkedListNode<string> csomopont = lancoltlista.First;

            //csomópontnak a tagjait leírjuk
            Console.WriteLine(csomopont.Value);

            Console.WriteLine("------");
            Console.WriteLine("Szótár");

            //létrehozunk egy szótárat
            Dictionary<string, string> dic = new Dictionary<string, string>()
            {
                {"szín", "pirons" }, {"szín", "kék"}
            };

            //leírjuk a szótárnak a tagjait meg ilyenek
            foreach (KeyValuePair<string, string> item in dic)
            {
                Console.WriteLine("Kulcs: {0}, értéke: {1}", item.Key, item.Value);
            }

            Console.ReadLine();
        }
    }
}
