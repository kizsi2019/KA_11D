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

            List<NapiMunka> napok = new List<NapiMunka>();

            int napSzama;

            do
            {
                Console.Write("Adja meg a keresett napot[1 ... 40]: ");
                napSzama = Convert.ToInt32(Console.ReadLine());

                foreach (var item in lista)
                {
                    if (item.Nap == napSzama)
                    {
                        napok.Add(item);
                    }
                }  
            }
            while (1 > napSzama || napSzama > 40);

            Console.WriteLine($"A(z) {napok[0].Nap}. nap végén {napok[0].HarangKesz} harang, {napok[0].AngyalkaKesz} angyalka és {napok[0].FenyofaKesz} fenyőfa maradt a készleten.");

            Console.ReadKey();
        }
    }
}
