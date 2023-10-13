using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tömb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------");
            Console.WriteLine("Mátrixos Tömb");
            Console.WriteLine("---------");
            //tömb létrehozása
            int[,] randomoltszamok_Gazda = new int[3,3];

            //ameddig a tömbünk 
            //addig ezt csináljuk
            for (int i = 0; i < randomoltszamok_Gazda.GetLength(0); i++)
            {
                for (int j = 0; j < randomoltszamok_Gazda.GetLength(1); j++)
                {
                    //számot kérünk be
                    Console.WriteLine("Adjon egy számot!");

                    //be helyezzük a tömbe a számot
                    randomoltszamok_Gazda[i,j] = Convert.ToInt32(Console.ReadLine());

                }

            }
            //minden egyes tömb tagut leírunk
            for (int i = 0; i < randomoltszamok_Gazda.GetLength(0); i++)
            {
                for (int j = 0; j < randomoltszamok_Gazda.GetLength(1); j++)
                {
                    Console.Write(randomoltszamok_Gazda[i, j] + " ");
                }
                Console.WriteLine(" ");
                
            }
            
            //
            int osszeg = 0;
            foreach (int item in randomoltszamok_Gazda)
            {
                osszeg += item;
            }
            Console.WriteLine(osszeg);

            //
            int max = randomoltszamok_Gazda[0,0];
            foreach (int item in randomoltszamok_Gazda)
            {
                if (max < item)
                {
                    max = item;
                }
            }
            Console.WriteLine(max);

            //a tömb legkisebb tagját megkeressük
            int min = randomoltszamok_Gazda[0, 0];
            foreach (int item in randomoltszamok_Gazda)
            {
                if (min > item)
                {
                    min = item;
                }
            }
            Console.WriteLine(min);

            //tagok számolása
            int tag = randomoltszamok_Gazda[0, 0];
            foreach (int item in randomoltszamok_Gazda)
            {
                if (item == 0)
                {
                    tag++;
                }
            }
            Console.WriteLine(tag);

            /*
            Console.WriteLine("---------");
            Console.WriteLine("Sorrendezett tömb");
            Console.WriteLine("---------");
            
            //sorrendbe rakjuk a tömböt
            Array.Sort(randomoltszamok_Gazda);
            //és most ki írjuk a rendbe rakott tömb tagokat
            foreach (int veki in randomoltszamok_Gazda)
            {
                Console.WriteLine(veki);
            }

            Console.WriteLine("---------");
            Console.WriteLine("Fordított sorrendű tömb");
            Console.WriteLine("---------");

            //FORDÍTOTT sorrendbe rakjuk a tömböt
            Array.Reverse(randomoltszamok_Gazda);
            //és most ki írjuk a rendbe rakott tömb tagokat
            foreach (int veki in randomoltszamok_Gazda)
            {
                Console.WriteLine(veki);
            }
            */

            Console.ReadKey();
        }
    }
}
