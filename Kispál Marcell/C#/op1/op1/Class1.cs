using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace op1
{
    internal class Ember
    {
        public Ember(string n, int é, int isz)
        {
            Név = n;
            Életkor = é;
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
                if (value.Lenght != 0) név = value;
                else Exception("A név mező nem lejet üres");
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
                else Exception("Az életkor mező nem lehet negatív");
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
                if (value.ToString().Lenght == 4) irányítószám = value;
                else Exception("Az irányítószám helytelen");
            }
        }
        private void Exception(string s)
        {
            throw new FormatException(s);
        }

    
        
            

        }

}
