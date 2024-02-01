using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace KarácsonyCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DailyJob> DailyJobList = new List<DailyJob>();
            foreach (string i in File.ReadAllLines("diszek.txt"))
            {
                DailyJobList.Add(new DailyJob(i));
            }

            Console.WriteLine($"{DailyJob.DonePcs} decorations were made in total.");

            Console.ReadKey();
        }
    }
}
