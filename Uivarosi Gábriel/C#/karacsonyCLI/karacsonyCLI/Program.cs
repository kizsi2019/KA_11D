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
           
            List<NapiMunka> Beolvasot_lista = new List<NapiMunka>();
         foreach (string sor in File.ReadAllLines("diszek.txt")) 
            {
                Beolvasot_lista.Add(new NapiMunka(sor));
            }


            Console.WriteLine($"4.feladat: Összesen {NapiMunka.KeszultDb} darab dísz készűlt");
          
            bool NemkeszultDisz = false;

            foreach (NapiMunka dísz in Beolvasot_lista) 
            {
                if (dísz.HarangKesz == 0 && dísz.AngyalkaKesz == 0 && dísz.FenyofaKesz == 0) {
                
                    NemkeszultDisz = true;
                    break;
                }
            }
            if (NemkeszultDisz)
            {
                Console.WriteLine("Volt olyan nap, amin Dísz nem készűlt ell");

            } else { Console.WriteLine("Dolgozott"); }
            bool Rosz_bekért_nap = true;
            int bekért_nap = 0;
            do
            {
                Console.WriteLine("Kérem agyon egy napot 1-40!");
                 bekért_nap = Convert.ToInt32(Console.ReadLine()) ;
                if (bekért_nap < 41 && bekért_nap > 0) Rosz_bekért_nap = false;
            } while (Rosz_bekért_nap);
            int harangok = 0;
            int angyalok = 0;
            int feyofak = 0;
            for (int i = 0; i < bekért_nap; i++)
            {
                harangok += Beolvasot_lista[i].HarangKesz + Beolvasot_lista[i].HarangEladott;
                angyalok += Beolvasot_lista[i].AngyalkaKesz + Beolvasot_lista[i].AngyalkaEladott;
                feyofak += Beolvasot_lista[i].FenyofaKesz + Beolvasot_lista[i].FenyofaEladott;
            }
            Console.WriteLine($"\tA(z) {bekért_nap}. nap végén {harangok} harang, {angyalok} angyal, {feyofak} fenyőfa maradt készleten");



            Console.ReadKey();
         
        }
    }
}


