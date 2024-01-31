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
            //2.feladat
            List<Adatok> dijazottak = new List<Adatok>();

            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                dijazottak.Add(new Adatok(i));
            }
            //3feladat
            Console.WriteLine($"3. feladat: A díjazottak száma: {dijazottak.Count}                         fő");
            //4feladat
            int utolsoEv = dijazottak.First().Ev;
            foreach (var i in dijazottak)
            {
                if (i.Ev > utolsoEv)
                {
                    utolsoEv = i.Ev;
                }

            }
            Console.WriteLine($"4.feladat: Utolsó év: {utolsoEv}");
            //5.feladat
            Console.Write("5. feladat: Kérem adja meg az ország kódját: ");
            string inputOrszagKod = Console.ReadLine().ToUpper();
            List<Adatok> inputOrszagDijazottai = new List<Adatok>();
            foreach (var i in dijazottak)
            {
                if (i.Orszagkod == inputOrszagKod)
                {
                    inputOrszagDijazottai.Add(i);
                }
            }
            if (inputOrszagDijazottai.Count == 0)
            {
                Console.WriteLine("\tA megadott országból nem volt dijazott!");
            }
            if (inputOrszagDijazottai.Count == 1)
            {
                Console.WriteLine($"A megadott ország díjazottai:");
                Console.WriteLine($"\tNév {inputOrszagDijazottai.First().Nev}");
                Console.WriteLine($"\tÉv {inputOrszagDijazottai.First().Ev}");
                Console.WriteLine($"\tSz/H {inputOrszagDijazottai.First().SzuletesHalalozas}");
            }
            if (inputOrszagDijazottai.Count > 1)
            {
                Console.WriteLine($"\tA megadott országból {inputOrszagDijazottai.Count} fő dijazott volt");
            }
            //6.feladattr
            Console.WriteLine("6feladta statisztika");
            Dictionary < string,int> stat = new Dictionary<string,int>();
            foreach (var i in dijazottak)
            {
                if (stat.ContainsKey(i.Orszagkod))
                {
                    stat[i.Orszagkod]++;
                }
                else
                {
                    stat.Add(i.Orszagkod, 1);
                }
            }
            foreach (var i in stat)
            {
                if (i.Value > 5)
                {
                    Console.WriteLine($"\t{i.Key} - {i.Value} fő");
                }
            }
            //7.feladat
            int élethosszÖsszeg = 0;
            int ismertÉlethosszFő = 0;
            foreach (var i in dijazottak)
            {
                Elethossz aktivDijazottakEletkora = new Elethossz(i.SzuletesHalalozas);
                if (aktivDijazottakEletkora.IsmertAzElethossz)
                {
                    élethosszÖsszeg += aktivDijazottakEletkora.ElethosszEvekben;
                    ismertÉlethosszFő++;
                }
            }
            Console.WriteLine($"7.feladat: A keresett átlag: {(double)élethosszÖsszeg / ismertÉlethosszFő:F1} év");





            Console.ReadKey();
        }
    }
}
