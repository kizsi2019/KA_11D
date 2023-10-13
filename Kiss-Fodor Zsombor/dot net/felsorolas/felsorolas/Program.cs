using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace felsorolas
{
    internal class Program
    {
        enum Hetnapjai : byte
        {
            Hetfo = 1,
            Kedd,
            Szerda,
            Csutortok,
            Pentek,
            Szombat,
            Vasarnap
        }


        static void Main(string[] args)
        {
            /*string[] tesztek = { "1", "7", "0", "99", "Hetfo", "Szerda", "Pentek", "pentek", "Hiba" };
            foreach (var teszt in tesztek)
            {
                try
                {
                    Hetnapjai nap = (Hetnapjai)Enum.Parse(typeof(Hetnapjai), teszt);
                    Console.WriteLine(nap);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Hiba: " + ex.Message);
                }
                Hetnapjai nap2 = Hetnapjai.Hetfo; //alap érték
                Enum.TryParse(teszt, out nap2); //generikus tryparse hívás
                Console.WriteLine(nap2);
            }
            
            // kettő dimenziós amit NEM lehet szortolni
            //KÁTTŐ
            int[,] randomoltszamok_Matri = new int[5, 5];

            for (int i = 0; i < randomoltszamok_Matri.GetLength(0); i++)
            {
                for (int j = 0; j < randomoltszamok_Matri.GetLength(1); j++)
                {
                    randomoltszamok_Matri[i, j] = r.Next(0, 100);
                }
                Console.WriteLine();
            }

            foreach (int item in randomoltszamok_Matri)
            {
                Console.WriteLine(item);
            }
            */

            //---------------------EZEK ITT A FONTOS KÓDOK!!---------------------//
            //EGYDIMENZIÓS tömb

            Console.WriteLine("---------");
            Console.WriteLine("Tömb");
            Console.WriteLine("---------");
            //tömb létrehozása
            int[] randomoltszamok_Vektor = new int[5];

            //egy új randomot huzúnk létre duh
            Random r = new Random();
            
            //ameddig a tömbünk mérete el nem éri az 5-öt
            //addig ezt csináljuk
            for (int i = 0; i < randomoltszamok_Vektor.Length; i++) {
                //létrehozunk egy random számot amit bele helyezünk a tömbbe
                randomoltszamok_Vektor[i] = r.Next(0, 100);
            } 
            //minden egyes tömb tagut leírunk
            foreach (int item in randomoltszamok_Vektor)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("---------");
            Console.WriteLine("Sorrendezett tömb");
            Console.WriteLine("---------");

            //sorrendbe rakjuk a tömböt
            Array.Sort(randomoltszamok_Vektor);
            //és most ki írjuk a rendbe rakott tömb tagokat
            foreach (int veki in randomoltszamok_Vektor)
            {
                Console.WriteLine(veki);
            }

            Console.WriteLine("---------");
            Console.WriteLine("Fordított sorrendű tömb");
            Console.WriteLine("---------");

            //FORDÍTOTT sorrendbe rakjuk a tömböt
            Array.Reverse(randomoltszamok_Vektor);
            //és most ki írjuk a rendbe rakott tömb tagokat
            foreach (int veki in randomoltszamok_Vektor)
            {
                Console.WriteLine(veki);
            }



            //---------------------felhasználó inputos tömb!!---------------------//

            Console.WriteLine("---------");
            Console.WriteLine("Tömb");
            Console.WriteLine("---------");
            //tömb létrehozása
            int[] randomoltszamok_Gazda = new int[5];

            //ameddig a tömbünk mérete el nem éri az 5-öt
            //addig ezt csináljuk
            for (int i = 0; i < randomoltszamok_Gazda.Length; i++)
            {
                //számot kérünk be
                Console.WriteLine("Adjon egy számot!");

                //be helyezzük a tömbe a számot
                randomoltszamok_Gazda[i] = Convert.ToInt32(Console.ReadLine());  
                
            }
            //minden egyes tömb tagut leírunk
            foreach (int item in randomoltszamok_Gazda)
            {
                Console.WriteLine(item);
            }

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

            Console.ReadKey();
         
        }
    }
}
