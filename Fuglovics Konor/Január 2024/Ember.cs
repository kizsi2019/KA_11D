using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Január_2024
{
    public class Ember
    {
        public Ember(string n, int é, int isz)
        {
            Név = n;
            Életkor = é;
            Iránysz = isz;
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
                if (value.Length != 0)
                {
                    név = value;
                }
                else
                {
                    Exception("A név nem lehet üres!");
                }
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
                if (value >= 0)
                {
                    életkor = value;
                }
                else
                {
                    Exception("Az életkor nem lehet negatív!");
                }
            }
        }
        private int iránysz;
        public int Iránysz
        {
            get
            {
                return iránysz;
            }
            set
            {
                if (value.ToString().Length == 4)
                {
                    iránysz = value;
                }
                else
                {
                    Exception("Helytelen irányítószám!");
                }
            }
        }
        private void Exception(string s)
        {
            throw new FormatException(s);
        }
    }   
}