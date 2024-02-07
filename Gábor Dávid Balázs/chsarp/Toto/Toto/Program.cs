using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Toto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. feladat
            List<EredmenyElemzo> eredmenyelemzo = new List<EredmenyElemzo>();
            foreach (var i in File.ReadAllLines("toto.txt").Skip(1))
            {
                eredmenyelemzo.Add(new EredmenyElemzo(i));
            }
            // 3. feladat
            Console.WriteLine($"3. feladat: Fordulók száma: {eredmenyelemzo.Count}");

            // 4. feladat

            Console.ReadKey();
        }
    }
}
