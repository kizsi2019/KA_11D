using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    class EredmenyElemzo
    {
        public int Év { get; private set; }
        public int Hét { get; private set; }
        public int Forduló { get; private set; }
        public double T13p1 { get; private set; }
        public double Ny13p1 { get; private set; }

        private string Eredmenyek;

        private int DontetlenekSzama
        {
            get
            {
                return Megszamol('X');
            }
        }

        private int Megszamol(char kimenet)
        {
            int darab = 0;
            foreach (var i in Eredmenyek)
            {
                if (i == kimenet) darab++;
            }
            return darab;
        }

        public bool NemvoltDontetlenMerkozes
        {
            get
            {
                return DontetlenekSzama == 0;
            }
        }

        public EredmenyElemzo(string eredmenyek) // konstruktor
        {
            Eredmenyek = eredmenyek;
            string[] splitted = eredmenyek.Split(';');
            Év = int.Parse(splitted[0]);
            Hét = int.Parse(splitted[1]);
            Forduló = int.Parse(splitted[2]);
            T13p1 = double.Parse(splitted[3]);
            Ny13p1 = double.Parse(splitted[4]);
            Eredmenyek = (splitted[5]);
        }
    }
}