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
            // 2. feladat
            List<Dijazott> dijazottak = new List<Dijazott>();
            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                dijazottak.Add(new Dijazott(i));
            }
            // 3. feladat
            Console.WriteLine($"3. feladat: A díjazottak száma: {dijazottak.Count} fő");

            // 4. feladat
            int utolsoEv = dijazottak.First().Év;
            foreach (var i in dijazottak)
            {
                if (i.Év > utolsoEv)
                {
                    utolsoEv = i.Év;
                }
            }
            Console.WriteLine($"4. feladat: Utolsó év {utolsoEv} ");
            Console.ReadKey();
        }
    }
}
