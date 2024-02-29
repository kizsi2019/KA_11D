using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlo_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //sor cuccos
            //létrehozunk egy sort
            Queue<int> sor = new Queue<int>();

            //hozzárakunk tagokat
            sor.Enqueue(1);
            sor.Enqueue(2);
            sor.Enqueue(3);
            sor.Enqueue(4);

            //mikor kiírjuk minding kiosztási sorrendben jön ki
            foreach (int i in sor)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-------");
            //halmaz
            //halmazt hozunk létre
            HashSet<int> halmaz = new HashSet<int>() { 17, 18, 19, 20 };
            Console.WriteLine("Hozzáadás előtt: " + halmaz.Count);
            //hozzáadjuk a 17-et
            halmaz.Add(17);
            //nem változik mert már van benne egy tag ami 17
            Console.WriteLine("Hozzáadás után: " + halmaz.Count);

            Console.WriteLine("-------");
            //lottó
            //random változó
            Random r = new Random();
            //lottós halmaz
            HashSet<int> lottoszamok = new HashSet<int>();
            //hozzáadunk 5 random számot
            while (lottoszamok.Count < 5) 
            {
                lottoszamok.Add(r.Next(0, 91));
            }
            Console.WriteLine("A nyertes számok:");
            //kiírjuk azokat
            foreach (int i in lottoszamok)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-------");
            //unió
            //kettő halmazt hozunk létre
            HashSet<int> halmaz1 = new HashSet<int>() { 10, 32, 4, 8};
            HashSet<int> unio = new HashSet<int>() { 20, 32, 12, 4};
            //
            unio.UnionWith(halmaz1);
            //
            foreach (int i in unio)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-------");
            //más halmaz logikai dolgok
            //
            HashSet<int> alaphalmaz = new HashSet<int>() { 10, 32, 4, 8 };
            alaphalmaz.SymmetricExceptWith(halmaz1);

            //
            alaphalmaz.ExceptWith(halmaz1);

            //
            alaphalmaz.IntersectWith(halmaz1);

            //
            */
            var verem = new Stack<int>();

            for (int i = 1; i <= 6; i++) {
                verem.Push(i);    
            }

            int[] tömb = verem.ToArray();

            foreach (int i in tömb)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------");
            int piik = verem.Peek();
            Console.WriteLine(piik);
            Console.WriteLine("-------");

            verem.Pop();

            piik = verem.Peek();
            Console.WriteLine(piik);
            Console.WriteLine("-------");
            while (verem.Count > 0)
            {
                verem.Pop() ;
            }

            tömb = verem.ToArray();

            foreach (int i in tömb)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
