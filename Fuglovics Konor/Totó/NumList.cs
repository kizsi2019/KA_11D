using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totó
{
    internal class NumList
    {
        public int Year { get; private set; }
        public int Week { get; private set; }
        public int Round { get; private set; }
        public int T13p1 { get; private set; }
        public int Ny13p1 { get; private set; }
        public string Results { get; private set; }

        public NumList(string row)
        {
            string[] m = row.Split(';');
            Year = int.Parse(m[0]);
            Week = int.Parse(m[1]);
            Round = int.Parse(m[2]);
            T13p1 = int.Parse(m[3]);
            Ny13p1 = int.Parse(m[4]);
            Results = m[5];
        }
    }
}
