using System;

namespace Decision_Making
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time <= 12 && time >= 7)
            {
                Console.WriteLine("Good Morning !");
            }
            else if (time <= 23 && time > 12)
            {
                Console.WriteLine("Have a good day !");
            }
            else if (time < 7)
            {
                Console.WriteLine("Good night !");
            }


            int month = DateTime.Now.Month;

            switch(month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                default:
                    Console.WriteLine("Other Months");
                    break;
            }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;
                default:
                    break;
            }
    }
}
}
