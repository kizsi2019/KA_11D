using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarácsonyCLI
{
    class DailyJob
    {
        public static int DonePcs { get; private set; }
        public int Day { get; private set; }
        public int DoneBell { get; private set; }
        public int SoldBell { get; private set; }
        public int DoneAngel { get; private set; }
        public int SoldAngel { get; private set; }
        public int DoneTree { get; private set; }
        public int SoldTree { get; private set; }

        public DailyJob(string sor)
        {
            string[] s = sor.Split(';');
            Day = Convert.ToInt32(s[0]);
            DoneBell = Convert.ToInt32(s[1]);
            SoldBell = Convert.ToInt32(s[2]);
            DoneAngel = Convert.ToInt32(s[3]);
            SoldAngel = Convert.ToInt32(s[4]);
            DoneTree = Convert.ToInt32(s[5]);
            SoldTree = Convert.ToInt32(s[6]);

            DailyJob.DonePcs += DoneBell + DoneAngel + DoneTree;
        }

        public int DailyIncome()
        {
            return -(SoldBell * 1000 + SoldAngel * 1350 + SoldTree * 1500);
        }
    }
}
