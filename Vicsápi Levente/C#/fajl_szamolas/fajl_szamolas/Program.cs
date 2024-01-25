using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fajl_szamolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            foreach (string s in File.ReadAllLines("darab.txt"))
            {
                list.Add(s);
            }

            // Megszámoljuk, hány darab "z" karakter található a listában
            int zBetuDarab = list.Sum(s => s.Count(c => c == 'z'));

            Console.WriteLine($"A listában összesen {zBetuDarab} darab 'z' karakter található.");

            Console.ReadKey();
        }
    }
}
