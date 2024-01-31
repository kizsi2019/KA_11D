using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace op1
{
    public class Ember
    {
        public Ember(string n, int é, int isz) {
            Név = n;
            Életkor = é;
            Irányitószám = isz;



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
                else Exception("a név mező nem lehet üres");
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
                else Exception("Az életkor nem lehet negatív");

            }
        }
        private int irányitószám;
        public int Irányitószám
        {
            get
            {
                return irányitószám;
            }
            set
            {
                if (value.ToString().Length == 4) irányitószám = value;
                else Exception("Az irányítószám helytelen");
            }
        }
        private void Exception(string s)
        {
            throw new FormatException(s);
        }
    }
}
