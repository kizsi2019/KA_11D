using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Ember
    {
        public Ember(string n, int e, int isz)
        {
            Név = n;
            Életkor = e;
            Irányítószám = isz;
        }
        private string név;
        public string Név
        {
            get
            {
                return név;
            }
            set
            {
                if (value.Length != 0) név = value;
                else Exception("A név mező nem lehet üres!");
            }
        }
        private int életkor;
        public int Életkor
        {
            get
            {
                return életkor;
            }
            set
            {
                if (value >= 0) életkor = value;
                else Exception("Az életkor mező nem lehet negatív!");
            }
        }
        private int irányítószám;
        public int Irányítószám
        {
            get
            {
                return irányítószám;
            }
            set
            {
                if (value.ToString().Length == 4) irányítószám = value;
                else Exception("Az irányítószám helytelen!");
            }
        }
        private void Exception(string s)
        {
            throw new FormatException(s);
        }
    }
}
