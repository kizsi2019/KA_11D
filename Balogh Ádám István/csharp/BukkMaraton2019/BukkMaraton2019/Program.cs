using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BukkMaraton2019
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //3. feladat
            List<Versenzyo> versenyzok = new List<Versenzyo>();
            foreach (var sor in File.ReadAllLines("bukkmaraton2019.txt").Skip(1)) 
            {
                versenyzok.Add(new Versenzyo(sor));
            }

            Console.WriteLine();
        }
    }
}
