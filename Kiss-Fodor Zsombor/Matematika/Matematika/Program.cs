﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int a = Math.Abs(-3);
            Console.WriteLine(a);
            double b = Math.Ceiling(1.23);
            Console.WriteLine(b);
            double c = Math.Floor(1.23);
            Console.WriteLine(c);
            double d = Math.Round(1.56);
            Console.WriteLine(d);
           

            var sugar = 12;
            Console.WriteLine("Kör kerület és terület számító.");
            Console.WriteLine("Kör sugara: {0}", sugar);

            var kerulet = Math.Round(Math.PI * 2 * sugar, 2);
            var terulet = Math.Pow(sugar, 2) * Math.PI;

            Console.WriteLine("A kör kerülete: {0}", Math.Round(kerulet, 3));
            Console.WriteLine("A kör területe: {0}", Math.Round(terulet, 3));
            

            int max = Math.Max(10, 20);
            Console.WriteLine(max);
            */

            Console.WriteLine("Menü program");
            Console.WriteLine("Opciók:");
            Console.WriteLine("A: Kis kávé, B: Nagy kávé");
            Console.WriteLine("C: Nem iszom semmit");
            Console.Write("Kérem válasszon!: ");
            var gomb = (char)Console.Read();

            if (gomb == 'A' || gomb == 'a')
            {
                Console.WriteLine("Kis kávét választott");
            }
            else if (gomb == 'B' || gomb == 'b')
            {
                Console.WriteLine("Nagy kávét választott");
            }
            else if (gomb == 'C' || gomb == 'c')
            {
                Console.WriteLine("Kár");
            }
            else
            {
                Console.WriteLine("Nem jó gombot nyomott!");
            }


            Console.ReadKey();
        }
    }
}
