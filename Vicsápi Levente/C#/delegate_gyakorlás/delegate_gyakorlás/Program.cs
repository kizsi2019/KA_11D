using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_gyakorlás
{
    //delegate definiálása az eseményhez
    public delegate void MyEventHandler(object sender, MyCustomEventArgs e);

    public class MyCustomEventArgs : EventArgs
    {
        public object EventSource { get; }

        public MyCustomEventArgs(object eventSource)
        {
            EventSource = eventSource;
        }
    }

    public class MyEventClass
    {
        //esemény deklarálása
        public event MyEventHandler MyEvent;

        //kiváltjuk eseményt
        public void RaiseEvent()
        {
            Console.WriteLine("Az esemény megtörtént");
            OnMyEvent(new MyCustomEventArgs(this));
        }

        //egy metódus ami az esemény kiváltásárta szolgál
        protected virtual void OnMyEvent(MyCustomEventArgs e)
        {
            MyEvent?.Invoke(this, e);
        }
    }

    //eseménykezelő osztály
    public class MyEventHandlerClass
    {
        public void HandleEvent(object sender, MyCustomEventArgs e)
        {
            Console.WriteLine("Az eseményt ez az osztály kezelte: " + sender.ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyEventClass eventSource = new MyEventClass();
            MyEventHandlerClass eventHandler = new MyEventHandlerClass();

            eventSource.MyEvent += eventHandler.HandleEvent;
            
            eventSource.RaiseEvent();

            Console.ReadKey();
        }
    }
}
