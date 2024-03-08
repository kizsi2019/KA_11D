using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace eseménykezelés_paraméterrel
{
    internal class Program
    {
        public delegate void SzamValtozasEventHandler(int ujErtek);

        public static event SzamValtozasEventHandler SzamValtozott;

        static int szam;
        public static int Szam
        {
            get { return szam; }
            set
            {
                if (value != szam + 1 && value != szam - 1)
                {
                    szam = value;
                    return;
                }

                
                 szam = value;
                 SzamValtozott?.Invoke(szam); // Az új érték átadása az eseménykezelőnek
                
                
            }
        }
        static void Main(string[] args)
        {
            SzamValtozott += ujErtek => Console.WriteLine($"A szám értéke megváltozott: {ujErtek}");

            Szam = 10; 
            Szam = 11; 

            Console.ReadKey();
        }
    }
}
