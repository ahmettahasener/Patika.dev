using System;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Wednesday);

            int C = 25;
            if (C <= (int)Weather.Cold)
            {
                Console.WriteLine("You do not have to wear jacket.");
            }
            else if (C >= (int)Weather.Hot)
            {
                Console.WriteLine("You should be careful. Weather is hot.");
            }
            else
            {
                Console.WriteLine("Weather is likely normal.");
            }
        }
    }
    enum Days
    {
        Monday=1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday=12,
        Saturday,
        Sunday,
    }
    enum Weather
    {
        Cold = 5,

        Normal = 20,

        Hot = 30,
    }
}
