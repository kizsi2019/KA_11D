using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim_e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adjon meg egy pozitív egész számot:");
            if (int.TryParse(Console.ReadLine(), out int szam) && szam > 1)
            {
                bool isPrime = IsPrime(szam);

                if (isPrime)
                {
                    Console.WriteLine($"{szam} prímszám.");
                }
                else
                {
                    Console.WriteLine($"{szam} nem prímszám.");
                }
            }
            else
            {
                Console.WriteLine("Hibás bemenet. Kérem adjon meg egy pozitív egész számot nagyobb, mint 1.");
            }

            Console.ReadKey();
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }

}

