using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace karacsonyCLI
{
    internal class Program
    {
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

            bool nem_keszult_disz = false;

            //5.feladat
            foreach(var item in lista) 
            {
                if (item.HarangKesz == 0 && item.AngyalkaKesz == 0 && item.FenyofaKesz == 0)
                {
                    nem_keszult_disz = true;
                    break;
                }
            }

            if (nem_keszult_disz)
            {
                Console.WriteLine("5.feladat: Volt olyan nap, amikor egyetlen dísz sem készült.");
            }

            else
            {
                Console.WriteLine("5.feladat: Nem volt olyan nap, amikor egyetlen dísz sem készült.");
            }

            //6.feladat
            Console.WriteLine("6.feladat:");

           
            int napSzama;

            do
            {
                Console.Write("Adja meg a keresett napot[1 ... 40]: ");
                napSzama = Convert.ToInt32(Console.ReadLine());

            }
            while (1 > napSzama || napSzama > 40);

            int harangok = 0;
            int angyalok = 0;
            int fenyofak = 0;

            for(int i = 0; i < napSzama; i++)
            {
                harangok += lista[i].HarangKesz + lista[i].HarangEladott;
                angyalok += lista[i].AngyalkaKesz + lista[i].AngyalkaEladott;
                fenyofak += lista[i].FenyofaKesz + lista[i].FenyofaEladott;
            }

            Console.WriteLine($"\t A {napSzama} nap végén {harangok} harang, {angyalok} angyal és {fenyofak} fenyőfa maradt készleten.");

            Console.ReadKey();
        }
    }
}
