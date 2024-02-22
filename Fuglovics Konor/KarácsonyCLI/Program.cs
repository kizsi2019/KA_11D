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

            bool NotMadeDecors = false;
            foreach (DailyJob i in DailyJobList)
            {
                if (i.DoneBell == 0 && i.DoneAngel == 0 && i.DoneTree == 0)
                {
                    NotMadeDecors = true;
                    break;
                }
            }
            if (NotMadeDecors)
            {
                Console.WriteLine($"There was a day when she didn't make any decorations");
            }
            else
            {
                Console.WriteLine("There was no day when she didn't make any decorations");
            }

            int day = 0;
            do
            {
                Console.Write("Enter the specified day between the 1st and the 40th day: ");
                day = int.Parse(Console.ReadLine());
            }
            while (day < 1 || day > 40);
            int bells = 0;
            int angels = 0;
            int trees = 0;
            for (int i = 0; i < day; i++)
            {
                bells += DailyJobList[i].DoneBell + DailyJobList[i].SoldBell;
                angels += DailyJobList[i].DoneAngel + DailyJobList[i].SoldAngel;
                trees += DailyJobList[i].DoneTree + DailyJobList[i].SoldTree;
            }
            Console.WriteLine($"\tThere were {bells} bells, {angels} angels and {trees} trees in storage on the {day}. day");

            Console.Write("The most sold decoration: ");
            Dictionary<string, int> sold = new Dictionary<string, int>();
            sold.Add("Bell", 0);
            sold.Add("Angel", 0);
            sold.Add("Tree", 0);
            foreach (DailyJob decor in DailyJobList)
            {
                sold["Bell"] -= decor.SoldBell;
                sold["Angel"] -= decor.SoldAngel;
                sold["Tree"] -= decor.SoldTree;
            }
            int max = sold.Values.Max();
            Console.WriteLine($"{max} pcs");
            foreach (var i in sold)
            {
                if (i.Value == max)
                {
                    Console.WriteLine($"\t{i.Key}");
                }
            }

            StreamWriter write = new StreamWriter("income.txt");
            int atleastTenThousand = 0;
            foreach (DailyJob i in DailyJobList)
            {
                if (i.DailyIncome() >= 10000)
                {
                    write.WriteLine($"{i.Day} - {i.DailyIncome()}");
                    atleastTenThousand++;
                }
            }
            write.WriteLine($"There was atleast 10000 HUF at day {atleastTenThousand} \n");
            write.Close();
            Console.ReadKey();
        }
    }
}
