using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class User
    {
        public string Name { get; set; }
        public int Income { get; set; }
        public List<int> Expenses { get; set; }

        public User(string name)
        {
            Name = name;
            Income = 0;
            Expenses = new List<int>();
        }

        public void GetIncome()
        {
            while (true)
            {
                try
                {
                    Console.Write($"{Name}, kérem, adja meg a havi bevételét: ");
                    Income = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hibás input! Kérem, csak számokat adjon meg.");
                }
            }
        }

        public void GetExpenses()
        {
            while (true)
            {
                try
                {
                    Console.Write($"{Name}, hány kiadást szeretne megadni? ");
                    int expenseCount = int.Parse(Console.ReadLine());

                    for (int i = 0; i < expenseCount; i++)
                    {
                        Console.Write($"Kiadás {i + 1}: ");
                        Expenses.Add(int.Parse(Console.ReadLine()));
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hibás input! Kérem, csak számokat adjon meg.");
                }
            }
        }

        public int CalculateBalance()
        {
            return Income - Expenses.Sum();
        }

        public int GetMaxExpense()
        {
            return Expenses.Count > 0 ? Expenses.Max() : 0;
        }

        public int GetMinExpense()
        {
            return Expenses.Count > 0 ? Expenses.Min() : 0;
        }
    }

    static void Main()
    {

        Console.Write("Kérem, adja meg a nevét: ");
        string name = Console.ReadLine();

        User user = new User(name);

        user.GetIncome();
        user.GetExpenses();

        int balance = user.CalculateBalance();
        int maxExpense = user.GetMaxExpense();
        int minExpense = user.GetMinExpense();

        Console.WriteLine($"{user.Name} egyenlege: {balance}");
        Console.WriteLine($"{user.Name} legnagyobb kiadása: {maxExpense}");
        Console.WriteLine($"{user.Name} legkisebb kiadása: {minExpense}");
    }
}
