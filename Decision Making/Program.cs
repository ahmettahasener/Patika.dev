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



    }
}
}
