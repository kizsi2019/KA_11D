using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eseménykezelés
{
    internal class Program
    {
        public delegate void SzamValtozasEventHandler();

        public static event SzamValtozasEventHandler SzamValtozott;


        static int szam;

        public static int Szam
        {
            get { return szam; }

            set
            {
                if (value != szam + 1)
                {
                    szam = value;
                    return;
                }

                else
                {
                    szam = value;
                    SzamValtozott?.Invoke();
                }
            }
        }

        static void Main(string[] args)
        {
            SzamValtozott += () => Console.WriteLine("Szám értéke változott");

            Szam = 12; // Nem vált ki eseményt
            Szam = 13; // Vált ki eseményt

            Console.ReadKey();
        }
    }
}
