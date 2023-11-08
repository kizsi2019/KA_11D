using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Kérem adjon meg egy szöveget: ");
        string szoveg = Console.ReadLine();

        string fordítottSzöveg = Fordít(szoveg);

        Console.WriteLine("A megadott szöveg fordítva: " + fordítottSzöveg);
    }

    static string Fordít(string eredeti)
    {
        Stack<char> karakterVerem = new Stack<char>();

        foreach (char karakter in eredeti)
        {
            karakterVerem.Push(karakter);
        }

        char[] fordítottKarakterek = new char[karakterVerem.Count];

        int index = 0;
        while (karakterVerem.Count > 0)
        {
            fordítottKarakterek[index] = karakterVerem.Pop();
            index++;
        }

        return new string(fordítottKarakterek);
    }
}
