using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OP1
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
            get
            {
                if (value.Length != 0) név = Value;
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
            get
            {
                if (value >= 0) életkor = value;
                else Exception("Az életkor mező nem lehet üres")
            }
        }
        private int irányítószám;

        public int Irányítószám
        {
            get
            {
                return irányítószám;
            }
            get
            {
                if (Value.ToString() Length == 4) irányítószám = value;
                else Exception("Az irányítószám mező nem lehet üres")
            }
        }
        private void Exception(string s)
        {
            throw new FormatException(s);
        }

}
