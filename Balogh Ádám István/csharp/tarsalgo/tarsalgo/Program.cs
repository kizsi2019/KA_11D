using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tarsalgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.feladat
            List<Tarsalgo> adatok = new List<Tarsalgo>(1000); 
            
            foreach (string sor in File.ReadAllLines("ajto.txt"))
            {
                adatok.Add(new Tarsalgo(sor));
            }

            //2.feladat
            Console.WriteLine("2.feladat");
            
            bool eloszorBelepett = false;
            string azonosito = "";

            foreach(var item in adatok)
            {
                if(item.BeVagyKi == "be")
                {
                    eloszorBelepett = true;
                    azonosito = item.Azonosito;
                    break;
                }

            }

            if(eloszorBelepett) 
            {
                Console.WriteLine($"Az első belépő: {azonosito}");
            }

            bool utoljaraBelepett = false;
            for (int i = adatok.Count - 1; i > 0; i--) 
            {
                if (adatok[i].BeVagyKi == "ki")
                {
                    utoljaraBelepett = true;
                    azonosito = adatok[i].Azonosito;
                    break;
                }
            }

            if (utoljaraBelepett)
            {
                Console.WriteLine($"Az utolso kiépő: {azonosito}");
            }

            //3.feladat

            List<int> szemelyek = new List<int>();
            List<int> athaladasok = new List<int>();

            
            for (int i = 0; i < adatok.Count; i++) 
            {
                if (szemelyek.Contains(int.Parse(adatok[i].Azonosito)))
                {
                    athaladasok[szemelyek.IndexOf(int.Parse(adatok[i].Azonosito))]++;
                }

                else
                {
                    szemelyek.Add(int.Parse(adatok[i].Azonosito));
                    athaladasok.Add(1);
                }
                
            }
            



            StreamWriter sw = new StreamWriter("athaladas.txt");

            for (int i = 0; i < szemelyek.Count - 1; i++)
            {
                sw.WriteLine(szemelyek[i] + " " + athaladasok[i]);
            }
            sw.Close();

            Console.ReadKey();
        }
    }
}
