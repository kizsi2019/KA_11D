using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Console.Write("Add meg a neved:");
            string nev = Console.ReadLine();

           
            List<double> jegyek = new List<double>();
            while (true)
            {
                Console.Write("Add meg a neved, vagy írd be, hogy vége.");
                string input = Console.ReadLine();
                if (input.ToLower() == "vége")
                    break;

                if (double.TryParse(input, out double jegy))
                {
                    jegyek.Add(jegy);
                }
                else
                {
                    Console.WriteLine("Hibás jegy, kérlek adj meg egy érvényes jegyet.");
                }
            }

            if (jegyek.Count > 0)
            {
               
                double atlag = Math.Round(jegyek.Average(), 2);

                
                double legjobbJegy = jegyek.Max();
                double legrosszabbJegy = jegyek.Min();

               
                Console.WriteLine($"{nev.ToUpper()} átlaga: {atlag}");
                Console.WriteLine($"{nev.ToUpper()} legjobb jegye: {legjobbJegy}");
                Console.WriteLine($"{nev.ToUpper()} legrosszabb jegye: {legrosszabbJegy}");
            }
            else
            {
                Console.WriteLine("Nem adott meg érvényes jegyeket.");*/
            Console.Write("Kérem, adjon meg egy szöveget: ");
            string input = Console.ReadLine();

            string reversedString = ReverseStringUsingStack(input);

            Console.WriteLine("A fordított szöveg: " + reversedString);
        }

        static string ReverseStringUsingStack(string input)
        {
            Stack<char> stack = new Stack<char>();

          
            foreach (char character in input)
            {
                stack.Push(character);
            }

            
            char[] reversedChars = new char[input.Length];
            int index = 0;

            while (stack.Count > 0)
            {
                reversedChars[index++] = stack.Pop();
            }

            string reversedString = new string(reversedChars);

            return reversedString;
            Console.ReadLine();

        }
        }
    }
