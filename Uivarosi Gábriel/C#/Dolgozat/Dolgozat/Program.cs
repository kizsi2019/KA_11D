using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nevedet Elkérhetbém?");
            string Nev = Console.ReadLine();
            int Be_szam = 1;
            List <int> list = new List<int>();
            while (Be_szam != 0) {
                Console.WriteLine("Kérem Agyon jegyet (0 át ha nem akar)");
            Be_szam = Convert.ToInt32(Console.ReadLine());
                if (Be_szam != 0) { 
             
                    list.Add(Be_szam);


                }
            }
            int Átlag = 0;
            int Jegyek_száma = 0;
            foreach (int i in list)
            {
                Átlag += i;
                Jegyek_száma += 1;
            }
            Átlag = Átlag / Jegyek_száma;
            Console.WriteLine(Nev +" Átlaga " + Átlag);
            int max = list[0];
            foreach (int i in list)
            {
                if (i > max)
                {
                    max = i;
                }

            }
            Console.WriteLine(Nev + " Legnagyobb Jegye " + max);
            int min = list[0];
            foreach (int i in list)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            Console.WriteLine(Nev + " Legkisebb Jegye " + min);
                Console.ReadLine();


        }
    }
}
