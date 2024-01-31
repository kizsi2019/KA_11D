using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace orvosi_nobeldijasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. feladat
            List<dijazott> dijazottak = new List<dijazott>();
            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                dijazottak.Add(new dijazott(i));
            }

            //3.feladat
            Console.WriteLine($"3. feladat: A díjazott száma: {dijazottak.Count} fő");


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


            //5. feladat
            Console.WriteLine("5. feladat: Kérem adja meg az ország kódját:");
            string inputOrszagKod = Console.ReadLine().ToUpper();
            List<dijazott> inputOrszagDijazottjai = new List<dijazott>();
            foreach (var i in dijazottak)
            {
                if (i.Országkód == inputOrszagKod)
                {
                    inputOrszagDijazottjai.Add(i);
                }
            }
            if (inputOrszagDijazottjai.Count == 0)
            {
                Console.WriteLine("\tA megadott országból nem volt díjazott.");
            }
            if (inputOrszagDijazottjai.Count == 1)
            {
                Console.WriteLine($"A megadott ország díjazottjai:");
                Console.WriteLine($"\tNév: {inputOrszagDijazottjai.First().Név}");
                Console.WriteLine($"\tÉv: {inputOrszagDijazottjai.First().Év}");
                Console.WriteLine($"\tSZ/H: {inputOrszagDijazottjai.First().SzületésHalálozás}");
            }
            if (inputOrszagDijazottjai.Count > 1)
            {
                Console.WriteLine($"\tA megadott országból {inputOrszagDijazottjai.Count} fő díjazott volt.");
            }

            //6. feladat
            Console.WriteLine("6. feladat: Statisztika");
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
                if (i.Value > 5){
                    Console.WriteLine($"\t{i.Key} - {i.Value} fő");
                }
            }


            //7. feladat
            int élethosszÖsszeg = 0;
            int ismertÉlethosszFő = 0;
            foreach (var i in dijazottak)
            {
                Elethossz aktivDijazottakEletkora = new Elethossz(i.SzületésHalálozás);
                if (aktivDijazottakEletkora.IsmertAzElethossz)
                {
                    élethosszÖsszeg += aktivDijazottakEletkora.ElethosszEvekben;
                    ismertÉlethosszFő++;
                }
            }
            Console.WriteLine($"7.feladat: A keresett átlag{(double)élethosszÖsszeg / ismertÉlethosszFő:F1} év");


            Console.ReadKey();
        }
    }
}
