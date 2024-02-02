using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace karacsonCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //4. feladat

            List<NapiMunka> napiMunkaLista = new List<NapiMunka>();
            foreach (string sor in File.ReadAllLines("diszek.txt"))
            {
                napiMunkaLista.Add(new NapiMunka(sor));
            }

            Console.WriteLine($"4.feladat: Összesen {NapiMunka.KeszultDb} darab dísz készleten");



            //5. feladat

            bool nemKeszultDisz = false;
            foreach (NapiMunka disz in napiMunkaLista)
            {
                if (disz.HarangKesz == 0 && disz.AngyalkaKesz == 0 && disz.FenyofaKesz == 0)
                {
                    nemKeszultDisz = true;
                    break;
                }
            }
            if (nemKeszultDisz )
            {
                Console.WriteLine($"5. feladat: Volt olyan nap, amikor nem készült egy dísz sem.");
            }
            else
            {
                Console.WriteLine($"Nem volt olyan nap amikor egyetlen dísz sem készült.");
            }

            //6. feladat

            Console.WriteLine("6. feladat:");
            int nap = 0;
            do
            {
                Console.WriteLine("Adja meg a keresett napot [1...40]: ");
                nap = int.Parse(Console.ReadLine());
            } while (nap < 1 || nap > 40);
            int harangok = 0;
            int angyalok = 0;
            int fenyofak = 0;
            for (int i = 0; i < nap; i++)
            {
                harangok += napiMunkaLista[i].HarangKesz + napiMunkaLista[i].HarangEladott;
                angyalok += napiMunkaLista[i].AngyalkaKesz + napiMunkaLista[i].AngyalkaEladott;
                fenyofak += napiMunkaLista[i].FenyofaKesz + napiMunkaLista[i].FenyofaEladott;
            }
            Console.WriteLine($"\tA(z) {nap}. nap végén {harangok} harang, {angyalok} angyal, {fenyofak} fenyofa maradt készleten. ");


            Console.ReadKey();
        }
    }
}
