using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szám_változás_delegate_
{
    public delegate void SzamValtozasEvent(int ujszam);

    public class SzamValtozottEvent
    {
        public event SzamValtozasEvent SzamEvent;

        private int szam;

        public int Szam
        {
            get { return szam; }

            set
            {
                if (szam != value)
                {
                    int oldnumber = szam;
                    szam = value;
                    SzamValtozott(oldnumber, szam);
                }
            }
        }

        protected virtual void SzamValtozott(int regiszam, int ujszam)
        {
            SzamEvent?.Invoke(ujszam);
        }
    }

    public class SzamValtozasEventHandling
    {
        public void SzamValtozasEventHandler(int ujszam)
        {
            Console.WriteLine($"A szám megváltozott: {ujszam}");
        }
    }

    class Program
    {
        static void Main(string[] args) 
        {
            SzamValtozottEvent eventsource = new SzamValtozottEvent();
            SzamValtozasEventHandling eventhandling = new SzamValtozasEventHandling();

            eventsource.Szam = 10;

            eventsource.SzamEvent += eventhandling.SzamValtozasEventHandler;


            eventsource.Szam = 11;

            Console.ReadKey();

        }
    }
    
}
