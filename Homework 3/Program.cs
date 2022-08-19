using System;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the largest 3 and the smallest 3 of the 20 numbers entered from the keyboard, calculates the averages of both groups, and prints these averages and average totals to the console. (Write using the Array class.)

            Console.WriteLine("please enter 20 numbers. The largest and smallest 3 and their average will be calculated");
            int[] numbers = new int[20];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Please enter {0}. number: ",i+1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            
            Console.Write("The smallest 3 numbers among the numbers you wrote: ");
            Console.Write(numbers[0] + " ");
            Console.Write(numbers[1] + " ");
            Console.WriteLine(numbers[2] + " ");
            int smallsSum = numbers[0] + numbers[1] + numbers[2];
            int smallsAverage = smallsSum / 3;
            Console.WriteLine("The sum of the 3 smallest numbers: " + smallsSum);
            Console.WriteLine("The average of the 3 smallest numbers: " + smallsAverage);

            Console.WriteLine("****************************");

            Console.Write("The 3 largest numbers among the numbers you wrote:");
            Console.Write(numbers[17] + " ");
            Console.Write(numbers[17] + " ");
            Console.WriteLine(numbers[19] + " ");
            int largesSum = numbers[17] + numbers[18] + numbers[19];
            int largesAverage = largesSum / 3;
            Console.WriteLine("The sum of the 3 largest numbers: " + largesSum);
            Console.WriteLine("The average of the 3 largest numbers: " + largesAverage);

        }
    }
}
