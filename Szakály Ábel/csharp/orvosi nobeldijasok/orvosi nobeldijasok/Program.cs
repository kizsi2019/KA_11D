using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace orvosi_nobeldijasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.feladat
            List<dijazott> dijazottak = new List<dijazott>();
            foreach ( var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                dijazottak.Add(new dijazott(i));
            }

            //3.feladat
            Console.WriteLine($"3.feladat: A díjazottak száma: {dijazottak.Count} fő");

            //4.feladat
            int utolsoEv = dijazottak.First().Év;
            foreach (var i in dijazottak)
            {
                if(i.Év > utolsoEv)
                {
                    utolsoEv = i.Év;
                }
            }
            Console.WriteLine($"4.feladat: Utolsó Év: {utolsoEv}");

            //5.feladat

            Console.WriteLine("5.feladat: Kérem adja meg az ország kódját: ");
            string inputOrszagkod = Console.ReadLine().ToUpper();
            List<dijazott> inputOrszagDijazottai = new List<dijazott>();
            foreach (var i in dijazottak)
            {
                if (i.Országkód == inputOrszagkod)
                {
                    inputOrszagDijazottai.Add(i);
                }
            }
            if(inputOrszagDijazottai.Count == 0)
            {
                Console.WriteLine("\t A megadott országból nem volt díjazott!");
            }
            if ( inputOrszagDijazottai.Count == 1)
            {
                Console.WriteLine($"A megadott ország dijazottaji:");
                Console.WriteLine($"\tNév {inputOrszagDijazottai.First().Név}");
                Console.WriteLine($"\tÉv {inputOrszagDijazottai.First().Év}");
                Console.WriteLine($"\tSZ/H {inputOrszagDijazottai.First().SzületésiHalálozás}");
            }
            if(inputOrszagDijazottai.Count > 0)
            {
                Console.WriteLine($"\t A megadott otszágból {inputOrszagDijazottai.Count} fő díjazott volt");
            }

            //6.feladat
            Console.WriteLine("6.feladat: Statisztika");
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var i in dijazottak)
            {
                if (stat.ContainsKey(i.Országkód))
                {
                    stat[i.Országkód]++;
                }
                else
                {
                    stat.Add(i.Országkód, 1);
                }
            }
            foreach (var i in stat)
            {
                if (i.Value > 5)
                {
                    Console.WriteLine($"\t {i.Key} - {i.Value} fő");
                }
            }

            //7.feladat

            int élethosszÖsszeg = 0;
            int ismertÉlethosszFő = 0;
            foreach (var i in dijazottak)
            {
                Elethossz aktivDijazottakEletkora = new Elethossz(i.SzületésiHalálozás);
                if (aktivDijazottakEletkora.IsmertAzElethossz)
                {
                    élethosszÖsszeg += aktivDijazottakEletkora.ElethosszEvekben;
                    ismertÉlethosszFő++;
                }
            }
            Console.WriteLine($"7.feladat: A keresett átlag: {(double)élethosszÖsszeg/ismertÉlethosszFő: F1} év");

            Console.ReadKey();
        }
    }
}
