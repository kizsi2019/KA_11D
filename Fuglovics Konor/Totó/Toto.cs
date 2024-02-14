using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totó
{
    class ResultChecker
    {
        private string Results;

        private int NumOfTies
        {
            get
            {
                return Counting('X');
            }
        }

        private int Counting(char output)
        {
            int piece = 0;
            foreach (var i in Results)
            {
                if (i == output) piece++;
            }
            return piece;
        }

        public bool NoTieMatch
        {
            get
            {
                return NumOfTies == 0;
            }
        }

        public ResultChecker(string results) // konstruktor
        {
            Results = results;
        }
    }
}
