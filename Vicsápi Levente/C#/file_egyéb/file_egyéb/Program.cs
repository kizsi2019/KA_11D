using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file_egyéb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg a forrásfáj elérési útját! ");
            string forrasfajl = Console.ReadLine();

            Console.Write("Add meg hol legyen a fájl új elérési útja! ");
            string celfajl = Console.ReadLine();

            try 
            {
                if (File.Exists(forrasfajl))
                {
                    File.Copy(forrasfajl, celfajl, true);
                }

                Console.WriteLine("A másolás sikeres volt");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Hiba történt: {ex.Message}");
            }
            
            Console.ReadKey();
        }
    }
}
