﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozási_tételek
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] tomb = new int[] { 53, 71, 32, 11, 2, 4, 85, 1, 41, 42, 64 };
            int total = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                total += tomb[i];
            };
            Console.WriteLine($"A tömbben tárolt számok összege: {total}");*/

            /*int[] randT = new int[10];
            Random r = new Random();
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 21);
            }
            int j = 0;
            while (j < randT.Length && randT[j] <= 15)
            {
                j++;
            }
            if (j < randT.Length) Console.WriteLine("There is.");
            else Console.WriteLine("There is not.");*/

            /*int[] randT = new int[10];
            Random r = new Random();
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 21);
            }
            int pcs = 0;
            for (int i = 0; i < randT.Length; i++)
            {
                if (randT[i] % 2 == 0) pcs++;
            }
            Console.WriteLine($"A generált tömbben {pcs}db páros szám van.");*/

            /*int[] tomb = new int[] { 2, 63, 52, 32, 77, 94, 421, 41, 1, 7 };
            int highest_index = 0;
            int tiniest_index = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > tomb[highest_index]) highest_index = i;
                if (tomb[i] < tomb[tiniest_index]) tiniest_index = i;
            }
            Console.WriteLine($"A legnagyobb elem indexe: {highest_index}, értéke: {tomb[highest_index]}");
            Console.WriteLine($"A legkisebb elem indexe: {tiniest_index}, értéke: {tomb[tiniest_index]}");*/

            StreamReader file = new StreamReader("July.txt");
            List<double> temperature = new List<double>();
            while (!file.EndOfStream)
            {
                temperature.Add(double.Parse(file.ReadLine()));
            }
            int lowest_temp = 0;
            for (int i = 0; i < temperature.Count; i++)
            {
                if (temperature[i] < temperature[lowest_temp]) lowest_temp = i;
            }
            Console.WriteLine($"A legalacsonyabb hômérséklet {lowest_temp + 1}-ik napon {temperature[lowest_temp]}°C volt.");

            Console.ReadKey();
        }
    }
}
