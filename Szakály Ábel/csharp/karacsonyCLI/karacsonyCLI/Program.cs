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


            Console.Write("7. Feladat: a legtobbet eladott dísz");
            Dictionary<string, int> eladottak = new Dictionary<string, int>();
            eladottak.Add("Harang", 0);
            eladottak.Add("Angyalka", 0);
            eladottak.Add("Fenyőfa", 0);
            foreach(Napimunka dísz in napiMunkaLista)
            {
                eladottak["Harang"] -= dísz.HarangEladott;
                eladottak["Angyalka"] -= dísz.AngyalkaEladott;
                eladottak["Fenyőfa"] -= dísz.FenyofaEladott;
            }
            int max = eladottak.Values.Max();
            Console.WriteLine();
            foreach(var item in eladottak)
            {
                if (item.Value == max)
                {
                    Console.WriteLine($"\t{item.Key}");
                }
            }

            Console.WriteLine();

            StreamWriter sw = new StreamWriter("bevétel.txt");
            int legalabb10000 = 0;
            foreach (Napimunka dísz in napiMunkaLista)
            {
                if (dísz.NapiBevetel() >= 10000)
                {
                    sw.WriteLine($"{dísz.Nap} - {dísz.NapiBevetel()}");
                    legalabb10000++;
                }
            }
            sw.WriteLine($"{legalabb10000} napon volt legalább 10000 forint a bevétel. \n");
            sw.Close();

            Console.ReadKey();
        }
    }
}
