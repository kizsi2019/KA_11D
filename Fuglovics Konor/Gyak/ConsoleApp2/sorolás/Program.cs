using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorolás
{
    class Program
    {
        enum Weekdays : byte
        {
            Monday = 1,
            Tuesady,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string [] args)
        {
            string [] tests = {"1", "7", "0", "09", "Monday", "Wednesday", "wednesday", "Error"};
            foreach (var test in tests)
            {
                try
                {
                    Weekdays day = (Weekdays)Enum.Parse(typeof(Weekdays), test);
                    Console.WriteLine(day);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
