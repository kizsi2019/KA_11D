using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace nobeldij
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Feladat
            List<Díjazott> díjazottak = new List<Díjazott>();

            

            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1)) 
            {
              díjazottak.Add(new Díjazott(i));
            }

            //3. feladat
            Console.WriteLine($"3. feladat: A dijazottak száma {díjazottak.Count} f8*");

            //4. feladat
            int utolsoEv = díjazottak.First().Év;
            foreach (var i in díjazottak) 
            {
                if (i.Év > utolsoEv)
                {
                    utolsoEv = i.Év;
                }
            }

            Console.WriteLine("5. feladat: Kérem adja meg az ország kódját ");
            string importOrszagKod = Console.ReadLine().ToUpper();
            List<Díjazott> inputOrszagDijazottjai = new List<Díjazott>();
            foreach ( var i in díjazottak )
            {
                if (i.Országkód == inputOrszagKod)
                {
                    inputOrszagDijazottjai.Add(i);
                }
            }
            if (inputOrszagDijazottjai.Count == 0)
            {
                Console.WriteLine("\tA megadott országból nem volt díjazott!");
            }
            if (inputOrszagDijazottjai.Count == 1)
            {
                Console.WriteLine($"A megadott ország díjazottjai:");
                Console.WriteLine($"\tNév {inputOrszagDijazottjai.First().Név}");
                Console.WriteLine($"\tÉv {inputOrszagDijazottjai.First().Év}");
                Console.WriteLine($"\tNév {inputOrszagDijazottjai.First
                    ().SzületésHalálozás}");
            }
            if(inputOrszagDijazottjai.Count > 1)
            {
                Console.WriteLine($"\tA megadott országból
                   {inputOrszagDijazottjai.Count} fő díjazott volt");
            }

            //6. feladat
            Console.WriteLine("6. feladat Statisztika");
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var i in díjazottak)
            {
                if (stat.ContainsKey(i.Országkód))
                {
                    stat[i.Országkod, 1]++;
                }
                else
                {
                    stat.Add(i.Országkód, 1);
                }
            }
            foreach (var i in stat)
                if (i.Value > 5)
                {
                    Console.WriteLine($"\t{i.Key} - {})
                }

            Console.WriteLine(díjazottak.Count);

            Console.ReadKey();
        }

        
        
    }
}
