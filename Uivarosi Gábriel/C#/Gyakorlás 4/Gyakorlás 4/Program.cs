﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Gyakorlás_4
{
    internal class Program
    {
        enum Hetnapjai : byte
        {
            Hetfo = 1,
            Kedd,
            Szerda,
            Csutortok,
            Pentek,
            Szombat,
            Vasarnap
        }
        static void Main(string[] args)
        {
            //  Console.WriteLine("SEX");
            //   Console.SetWindowSize(1, 1);
            /*
                          while(true)
                          {
                            Console.SetWindowSize(1, 1);
                            Console.WriteLine("SEX");
                            Console.SetWindowSize(54, 54);
                            //  System.Diagnostics.Process.Start("Notepad");
                            Console.SetWindowSize(23, 12);
                            // System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=9vCb_ZopT4A");
                            Console.SetWindowSize(56, 45);
                            Console.SetWindowSize(23, 58);

                        }
                              */
            /*
            Random rnd = new Random();
            var wh = 1;
            var hi = 1;
            while (true)
            {
                wh = rnd.Next(1, 59);
                hi = rnd.Next(1, 59);
                Console.SetWindowSize(hi, wh);
            }

                /*
              */
            /*
          */
            /*
          */
            /*               
            var gyumolcsok = new string[]
           {
                "alma", "körte", "szilva"
           };

            var bevitelek = new string[3];

            for (int i = 0; i < bevitelek.Length; i++)
            {
                Console.WriteLine("{0}. bevitel: ", i);
                bevitelek[i] = Console.ReadLine();
            }

            foreach (var gyumolcs in gyumolcsok)
            {
                Console.WriteLine(gyumolcs);
            }
            foreach (var bevitel in bevitelek)
            {
                Console.WriteLine(bevitel);
            }

            Console.ReadLine();
           
            //tömb elemeinek meghatározása
            //minden sor külön zárójelet igényel
            var tomb2d = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine("Bejárás for ciklusokkal");
            //A length tulajdonság itt nem használható
            //mivel a tömb 2d kiterjedésű. 
            for (int i = 0; i < tomb2d.GetLength(0); i++)
            {
                for (int j = 0; j < tomb2d.GetLength(1); j++)
                {
                    Console.Write("{0} ", tomb2d[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Bejárás foreach ciklusokkal");
            foreach (var elem in tomb2d)
            {
                Console.Write("{0} ", elem);
            }
            Console.ReadLine();


           
                string[] tesztek = { "1", "7", "0", "99", "Hetfo", "Szerda", "Pentek", "pentek", "Hiba" };
                foreach (var teszt in tesztek)
                {
                    try
                    {
                        Hetnapjai nap = (Hetnapjai)Enum.Parse(typeof(Hetnapjai), teszt);
                        Console.WriteLine(nap);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Hiba: " + ex.Message);
                    }
                    Hetnapjai nap2 = Hetnapjai.Hetfo; //alap érték
                    Enum.TryParse(teszt, out nap2); //generikus tryparse hívás
                    Console.WriteLine(nap2);
                }
                Console.ReadKey();
            Random rnd = new Random();
            var wh = 1;
            var hi = 1;
            while (true)
            {
                wh = rnd.Next(1, 59);
                hi = rnd.Next(1, 59);
                Console.SetWindowSize(hi, wh);

            }
                         */
            /*
            int[] randomoltszamok_Vektor = new int[10];
            Random r = new Random();
            for (int i = 0; i < randomoltszamok_Vektor.Length; i++)
            {
                randomoltszamok_Vektor[i] = r.Next(0, 100);

            } foreach (int item in randomoltszamok_Vektor)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            */

            Random rszam = new Random();
            var Mátrix = new int[1, 1, 1];



            

        }
    }
}
