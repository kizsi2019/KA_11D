using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobel_Díj
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Awarded> awarded_people = new List<Awarded>();
            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                awarded_people.Add(new Awarded(i));
            }

            Console.WriteLine($"The number of awarded people: {awarded_people.Count}");

            int LastYear = awarded_people.First().Year;
            foreach (var i in awarded_people)
            {
                if (i.Year > LastYear)
                {
                    LastYear = i.Year;
                }
            }
            Console.WriteLine($"Last year: {LastYear}");

            Console.Write("Please enter a country code: ");
            string InputCountryCode = Console.ReadLine().ToUpper();
            List<Awarded> InputCountrysAwardedpeople = new List<Awarded>();
            foreach (var i in awarded_people)
            {
                if (i.CountryCode == InputCountryCode)
                {
                    InputCountrysAwardedpeople.Add(i);
                }
            }
            if (InputCountrysAwardedpeople.Count == 0)
            {
                Console.WriteLine("\tThere was no awared person in the specified country!");
            }
            else if (InputCountrysAwardedpeople.Count == 1)
            {
                Console.WriteLine($"The country's awarded people:");
                Console.WriteLine($"\tName: {InputCountrysAwardedpeople.First().Name}");
                Console.WriteLine($"\tYear: {InputCountrysAwardedpeople.First().Year}");
                Console.WriteLine($"\tBrn, Dth: {InputCountrysAwardedpeople.First().BirthDeath}");
            }
            else if (InputCountrysAwardedpeople.Count > 1)
            {
                Console.WriteLine($"\tThere were {InputCountrysAwardedpeople.Count} awarded people from the specified country.");
            }

            Console.WriteLine("Statistics");
            Dictionary<string, int> stats = new Dictionary<string, int>();
            foreach (var i in awarded_people)
            {
                if (stats.ContainsKey(i.CountryCode))
                {
                    stats[i.CountryCode]++;
                }
                else
                {
                    stats.Add(i.CountryCode, 1);
                }
            }
            foreach (var i in stats)
            {
                if (i.Value > 5)
                {
                    Console.WriteLine($"\t{i.Key} - {i.Value}");
                }
            }

            int TotalLifeLength = 0;
            int KnownLifeLengths = 0;
            foreach (var i in awarded_people)
            {
                LifeLength ActiveAwardedPeopleAge = new LifeLength(i.BirthDeath);
                if (ActiveAwardedPeopleAge.KnownLifeLength)
                {
                    TotalLifeLength += ActiveAwardedPeopleAge.LifeLengthInYears;
                    KnownLifeLengths++;
                }
            }
            Console.WriteLine($"The found average age: {(double)TotalLifeLength / KnownLifeLengths:F1}");
            Console.ReadKey();
        }
    }
}
