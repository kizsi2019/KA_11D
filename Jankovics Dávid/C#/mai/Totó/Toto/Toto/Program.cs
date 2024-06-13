using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Fordulo> fordulok = new List<Fordulo>();
        string filePath = "toto.txt"; 

        try
        {
            var lines = File.ReadAllLines(filePath).Skip(1); 
            foreach (var line in lines)
            {
                var parts = line.Split(';');
                fordulok.Add(new Fordulo
                {
                    Ev = int.Parse(parts[0]),
                    Het = int.Parse(parts[1]),
                    ForduloSorszama = int.Parse(parts[2]),
                    T13p1 = int.Parse(parts[3]),
                    Ny13p1 = long.Parse(parts[4]),
                    Eredmenyek = parts[5]
                });
            }

            Console.WriteLine($"3. feladat: Fordulók száma: {fordulok.Count}");

            var telitalalatosSzelvenyek = fordulok.Sum(f => f.T13p1);
            Console.WriteLine($"4. feladat: Telitalálatos szelvények száma: {telitalalatosSzelvenyek}");

            var telitalalatosFordulok = fordulok.Where(f => f.T13p1 > 0 || f.Ny13p1 > 0);
            double atlagNyeremeny = telitalalatosFordulok.Average(f => (double)f.T13p1 * f.Ny13p1);
            Console.WriteLine($"5. feladat: Átlag nyeremény: {Math.Round(atlagNyeremeny)} Ft");

            var legnagyobbNyeremenyFordulo = fordulok.OrderByDescending(f => f.Ny13p1).First();
            var legkisebbNyeremenyFordulo = fordulok.OrderBy(f => f.Ny13p1).First(f => f.Ny13p1 > 0);

            Console.WriteLine($"6. feladat:: Legkisebb és legnagyobb nyeremény:");

            var dontetlenNelkuliFordulo = fordulok.Any(f => EredmenyElemzo.NemvoltDontetlenMerkozes(f.Eredmenyek));
            Console.WriteLine($"8. feladat: {(dontetlenNelkuliFordulo ? "Volt" : "Nem volt")} döntetlen nélküli forduló.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hiba történt a fájl olvasása során: {ex.Message}");
        }
    }
}