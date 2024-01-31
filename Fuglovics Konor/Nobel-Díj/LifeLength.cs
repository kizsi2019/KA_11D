using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobel_Díj
{
    internal class LifeLength
    {
        private int From { get; set; }
        private int To { get; set; }
        public int LifeLengthInYears => From == -1 || To == -1 ? -1 : To - From;

        public bool KnownLifeLength => LifeLengthInYears != -1;

        public LifeLength(string BirthDeath)
        {
            string[] m = BirthDeath.Split('-');
            try
            {
                From = int.Parse(m[0]);
            }
            catch (Exception)
            {
                From = -1;
            }
            try
            {
                To = int.Parse(m[1]);
            }
            catch (Exception)
            {
                To = -1;
            }
        }
    }
}
