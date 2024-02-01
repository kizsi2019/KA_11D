using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using karácsony_díszek;

namespace karacsonyCLI
{
    internal class Program
    {
        private static IEnumerable<NapiMunka> NapiMunkaLista;

        public static int napiMunkaLista { get; private set; }

        static void Main(string[] args)
        {
            List<NapiMunka> lista = new List<NapiMunka>();

            //3.feladat
            foreach (var item in File.ReadAllLines("diszek.txt"))
            {
                lista.Add(new NapiMunka(item));
            }

            //4.feladat

            Console.WriteLine($"4.feladat: Összesen {NapiMunka.KeszultDb} dísz készült.");

            bool nemKeszultDisz = false;
            foreach (NapiMunka disz  in NapiMunkaLista) 
            {
                if (disz.HarangKesz == 0 && disz.AngyalkaKesz == 0 && disz.FenyofaKesz == 0)
                {
                    nemKeszultDisz = true;
                    break;
                }
            }
            if (nemKeszultDisz)
            {
                Console.WriteLine($"5. fleadat: Volt olyan nap, amikor egyetlen dísz sem készült");
            }
            else
            {
                Console.WriteLine($"5. fleadat: Volt olyan nap, amikor egyetlen dísz sem készült");
            }

            Console.WriteLine("6. feladat:");
            int nap = 0;
            do
            {
                Console.Write("Adja meg a keresett napot [1...40]:");
                nap = int.Parse(Console.ReadLine() );

            } while ( nap < 1 || nap > 40 );

            int harangok = 0;
            int angyalok = 0;
            int fenyofak = 0;
            for (int i = 0; i < nap; i++)
            {
                harangok += lista[i].HarangKesz + lista[i].HarangEladott;
                angyalok += lista[i].Angyalkakesz + lista[i].AngyalkaEladott;
                fenyofak += lista[i].FenyofaKesz + lista[i].FenyofaEladott;
            }
            Console.WriteLine($"\tA(z) {nap}, nap végén {harangok} harangok, {angyalok} angyal, {fenyofak} fenyőfa maradt készleten");

            Console.ReadKey();
        }
    }
}