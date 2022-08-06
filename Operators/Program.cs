using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            x = 3 + 3;
            Console.WriteLine(x);
            x += 3;
            Console.WriteLine(x);

            bool dogru = true;
            bool yanlıs = false;

            if (dogru && yanlıs)
            {
                Console.WriteLine("and işareti çalıştı");
            }

            if (dogru || yanlıs)
            {
                Console.WriteLine("or işareti çalıştı");
            }

            if (dogru && !yanlıs)
            {
                Console.WriteLine("not işareti çalıştı");
            }

            bool kucukmu;
            kucukmu = (3 < 2);
            Console.WriteLine(kucukmu);

            int a = 20;
            int b = 3;
            int c = a % b;
            Console.WriteLine(c);


            Console.ReadLine();
        }
    }
}
