using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    internal class TotoData
    {
        public int Ev { get; set; }
        public int Het { get; set; }
        public int Fordulo { get; set; }
        public double T13p1 { get; set; }
        public double Ny13p1 { get; set; }
        public string Eredmenyek { get; set; }


        public TotoData(string line)
        {
            string[] splitted = line.Split(';');
            Ev = int.Parse(splitted[0]);
            Het = int.Parse(splitted[1]);
            Fordulo = int.Parse(splitted[2]);
            T13p1 = double.Parse(splitted[3]);
            Ny13p1 = double.Parse(splitted[4]);
            Eredmenyek = splitted[5];
        }

        public override string ToString(); 
        { 
            string output = "";
            output += "\tÉv: ";
            output += Ev;
            output += "\n\tHét: ";
            output += Het;
            output += "\n\tForduló: ";
            output += Forduló;
            output += "\n\tTelitalálat: ";
            output += T13p1;
            output += "\n\tNyeremények: ";
            output += Ny13p1;
            output += "\n\tEredmények: ";
            output += Eredmenyek;
            return output;
            
        }

    }
}
