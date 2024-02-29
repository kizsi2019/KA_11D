using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            string kiadas;
            string bevetel;

            List<int> kiadasok = new List<int>();
            List<int> bevetelek = new List<int>();


            Console.Write("Adja meg a nevét ");
            string nev = Console.ReadLine();

            Console.WriteLine();

            try
            {
                do
                {
                    Console.Write("Adja meg a kiadásait ");
                    kiadas = Console.ReadLine();

                    if (kiadas != "")
                    {

                        int kiadas_int = int.Parse(kiadas);
                        kiadasok.Add(kiadas_int);
                    }

                }
                while (kiadas != "");

                Console.WriteLine();

                do
                {

                    Console.Write("Adja meg a bevételeit ");
                    bevetel = Console.ReadLine();

                    if (bevetel != "")
                    {

                        int bevetel_int = int.Parse(bevetel);
                        bevetelek.Add(bevetel_int);
                    }

                }
                while (bevetel != "");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Hiba történt: {0}", ex);
            }

            
            int összes_kiadás = kiadasok.Sum();
            int összes_bevétel = bevetelek.Sum();
            int egyenleg = összes_bevétel - összes_kiadás;
            int legnagyobb_kiadás = kiadasok.Max();
            int legkisebb_kiadás = kiadasok.Min();

            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("{0} legnagyobb kiadása: {1}", nev.ToUpper(), legnagyobb_kiadás);
            Console.WriteLine("{0} legkisebb kiadása: {1}", nev.ToUpper(), legkisebb_kiadás);
            Console.WriteLine("{0} egyenlege: {1}", nev.ToUpper(), egyenleg); 

            Console.ReadKey();
        }
    }
}
