using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OrvosiNobeldijasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Adatok> dijazottak = new List<Adatok>();

            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1)) 
            {
                dijazottak.Add(new Adatok(i));
            }

            Console.WriteLine($"3. feladat: A díjazottak száma: {dijazottak.Count}fő");

            Console.ReadKey();
        }
    }
}
