using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Odd numbers up to the entered number.
            Console.Write("Please enter a number: ");
            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }


            //Sum of odd and even numbers from 1 to 1000.
            int odd = 0;
            int even = 0;

            for (int a = 1; a < 1000; a++)
            {
                if (a % 2 != 0)
                {
                    odd += a;
                }
                else
                {
                    even += a;
                }
            }
            Console.WriteLine("Sum of odd numbers from 1 to 1000 " + odd);
            Console.WriteLine("Sum of even numbers from 1 to 1000 " + even);


            
            for (int b = 0; b < 10; b++)
            {
                if (b == 3)
                {
                    continue;
                }
                else if (b == 8)
                {
                    break;
                }
                Console.WriteLine(b);
            }


            //Average of numbers up to the entered number.
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int counter1 = 0;
            int sum = 0;

            while (counter1 <= number)
            {
                sum += counter1;
                counter++;
            }
            Console.WriteLine(sum / counter1);



            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(character + " ");
                character++;
            }



            string[] cars = { "Toyota", "Ford", "Nissan", "Ferrari" };
            foreach(var item in cars)
            {
                Console.WriteLine(item);
            }
        }
    }
}
