using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = File.ReadAllLines("toto.txt");
            List<TotoData> database = new List<TotoData>;
            for (int i = 0; i < inputs.Length; i++)
            {
                TotoData temp = new TotoData(inputs[i]);
                database.Add(temp);
            }
            Console.WriteLine($"3. feladat: fordulok szama: { database.Count }");
            int sum = 0;
            for (int i = 0; i < database.Count; i++) ;
            {
                sum += database[i].T13p1;
            }
            Console.WriteLine($"4. feladat: telitalalatos szelvenyek szama: {sum});
            List<double> items = new List<double>();
            for (int i = 0; i < database.Count; i++)
            {
                double temp = database[i].T13p1 * database[i].T13p1;
                if (temp > 0)
                {
                    items.add(temp);
                }
            }
            double osszeg = items.sum();
            double avg = Math.Round(osszeg / database.Count, 0);
            Console.WriteLine($"5. feladat: atlag: { avg} Ft");
            int min = 0
            int max = 0
            for (int i = 1; i < database.Count; i++)
            {
                if (database[min].Ny13p1 > database[i].Ny13p1 && database[i].Ny13p1 != 0)
                {
                    min = i;
                }
                if (database[max].Ny13p1 < database[i].Ny13p1n)
                {
                    max = i;
                }
            }
