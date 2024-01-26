using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobel_Díj
{
    internal class Awarded
    {
        public int Year { get; private set; }
        public string Name { get; private set; }
        public string BirthDeath { get; private set; }
        public string CountryCode { get; private set; }

        public Awarded(string row)
        {
            string[] m = row.Split(';');
            Year = int.Parse(m[0]);
            Name = m[1];
            BirthDeath = m[2];
            CountryCode = m[3];
        }
    }
}