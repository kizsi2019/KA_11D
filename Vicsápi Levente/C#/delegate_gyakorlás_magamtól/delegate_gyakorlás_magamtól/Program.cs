using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace delegate_gyakorlás_magamtól
{
    public delegate void MyEventHandler(object sender, EventArgs e);

    public class MyEventClass
    {
        public event MyEventHandler MyEvent;

        public void Event_method()
        {
            Console.WriteLine("Meghívódott a függvény");
        }

        public void OnMyEvent(EventArgs e)
        {
            MyEvent?.Invoke(this, e);
        }
    }

    public class EventCall
    {
        public void EventHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Az esemény kiváltotta: " + sender.ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyEventClass eventsource = new MyEventClass();
            EventCall eventcall = new EventCall();

            eventsource.MyEvent += eventcall.EventHandler;

            eventsource.Event_method();

            Console.ReadKey();
        }
    }
}
