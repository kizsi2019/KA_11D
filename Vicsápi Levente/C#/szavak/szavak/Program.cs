using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace szavak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> szavak = new List<string>();

            foreach (string sor in File.ReadAllLines("szoveg.txt")) 
            {
                szavak.Add(sor);
            }

            //1.feladat
            Console.WriteLine("1.feladat");

            Console.Write("Adjon meg egy szót! ");
            string szo = Console.ReadLine();
            bool tartalmaz = false;

            
            for (int i = 0; i < szo.Length; i++)
            {

                if (szo[i] == 'a' || szo[i] == 'e' || szo[i] == 'i' || szo[i] == 'o' || szo[i] == 'u') 
                {
                    tartalmaz = true;
                }
               
            }

            if (tartalmaz)
            {
                Console.WriteLine("Van benne magánhangzó.");
            }

            else
            {
                if (!tartalmaz)
                {
                    Console.WriteLine("Nincsen benne magánhangzó.");
                }
                
            }

            //2.feladat
            Console.WriteLine();
            Console.WriteLine("2.feladat");
            var leghosszabbSzoIndex = szavak[0].Length;
            string leghosszabbSzo = "";

            for(int i = 0; i < szavak.Count; i++) 
            {
                if (szavak[i].Length  > leghosszabbSzoIndex)
                {
                    leghosszabbSzoIndex = szavak[i].Length;
                    leghosszabbSzo = szavak[i];
                }
           
            }
            Console.WriteLine($"A leghosszabb szó a(z) {leghosszabbSzo}, és {leghosszabbSzoIndex} betűből áll.");

            //3.feladat
            Console.WriteLine();
            Console.WriteLine("3.feladat");


            int kulonlegesSzavak = 0;

            for (int i = 0; i < szavak.Count; i++)
            {
                int maganhangzokSzama = 0;
                int massalhangzokSzama = 0;

                foreach (char c in szavak[i])
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        maganhangzokSzama++;
                    }
                    else
                    {
                        massalhangzokSzama++;
                    }
                }

                if (maganhangzokSzama > massalhangzokSzama)
                {
                    kulonlegesSzavak++;
                }
            }

            Console.WriteLine();
            Console.WriteLine(kulonlegesSzavak);
            Console.ReadKey();
        }
    }
}
