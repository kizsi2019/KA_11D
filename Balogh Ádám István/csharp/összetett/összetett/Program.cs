﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace összetett
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* List<int> lista = new List<int>(8);
            lista.Add(12);
            lista.Add(43);
            lista.Add(2);
            for (int i = 0; i < lista.Count; i++)
                foreach (var item in lista){
                    Console.WriteLine(item);
                   
                }
            List<int> lista = new List<int>();
            lista.Add(12);
            lista.Add(43);
            lista.Add(2);
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            lista.Insert(1, 31);
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            } 

            List<int> lista = new List<int>() { 10, 23, 4};
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            lista.Remove(23);
            
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
           List<int> lista = new List<int>() { 10, 23, 4, 30};
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            lista.RemoveAt(2);
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
           List<int> lista = new List<int>() { 10 ,23, 4, 30, 10, 16, 19, 20, 34, 10};
            lista.Clear();
            Console.WriteLine("Törlés után a kapacitása: {0}, mérete:{1}", lista.Capacity,);
            
           List<string> lista = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi"};
            lista.Sort();
            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }
            {

            }
           List<string> lista = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi" };
            int index = lista.IndexOf("körte");
            if (index != -1) Console.WriteLine("Van körte, indexe:" + index);
            */
          List<int> lista = new List<int>() { 20 ,31, 10};
            int[] tömb = lista.ToArray();
            foreach (item in tömb)
           
            {
                Console.WriteLine(tömb);
            }
            {
                Console.ReadKey();
            }
               
                

                
            
                
            
        }
    }
}
