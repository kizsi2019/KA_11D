using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak_oop
{
    public class Proba
    {
        public Proba(int n, int n2)
        {
            Number1 = n;
            Number2 = n2;
            Number3 = n + n2;
        }

        private int Number1;
        private int Number2;
        private int _number3; 

        public int Number3
        {
            get
            {
                return _number3;
            }
            set
            {
                if (Number1.ToString().Length != 0 && Number2.ToString().Length != 0)
                {
                    _number3 = value;
                }
                else
                {
                    throw new Exception("Nem lehet üres");
                }
            }
        }
    }

}
