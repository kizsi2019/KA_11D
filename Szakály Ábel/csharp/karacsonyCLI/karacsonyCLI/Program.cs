using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace karacsonyCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Napimunka> napiMunkaLista = new List<Napimunka>();
            foreach(string sor in File.ReadAllLines("diszek.txt"))
            {
                napiMunkaLista.Add(new Napimunka(sor));
            }

            Console.WriteLine($"4.feladat: Összesen {Napimunka.KeszultDb} darab dísz készült");

            bool nemKeszultDisz = false;
            foreach (Napimunka disz in napiMunkaLista)
            {
                if (disz.HarangKesz == 0 && disz.AngyalkaKesz == 0 && disz.FenyofaKesz == 0)
                {
                    nemKeszultDisz = true;
                    break;
                }
            }
            if (nemKeszultDisz)
            {
                Console.WriteLine($"5. feladat: Volt olyan nap, amikor egyetlen dísz sem készült.");
            }
            else
            {
                Console.WriteLine($"5.feladat: Nem volt olyan nap amikor egyetlen dísz sem készült");
            }

            Console.WriteLine("6. feladat");
            int nap = 0;
            do
            {
                Console.WriteLine("Adja meg a keresett napot[1....40]: ");
                nap = int.Parse( Console.ReadLine() );

            } while (nap < 1 || nap > 40);
            int harangok = 0;
            int angyalok = 0;
            int fenyofak = 0;

            for (int i = 0; i < nap; i++)
            {
                harangok += napiMunkaLista[i].HarangKesz + napiMunkaLista[i].AngyalkaEladott + napiMunkaLista[i].FenyofaEladott;
                angyalok += napiMunkaLista[i].AngyalkaKesz + napiMunkaLista[i].AngyalkaEladott + napiMunkaLista[i].FenyofaEladott;
                fenyofak += napiMunkaLista[i].FenyofaKesz+ napiMunkaLista[i].AngyalkaEladott + napiMunkaLista[i].FenyofaEladott;
            }
            Console.WriteLine($"\t A(z) {nap}. nap végén{harangok} harang, {angyalok} angyal, {fenyofak} fenyőfa maradt készleten");





            Console.ReadKey();
        }
    }
}
