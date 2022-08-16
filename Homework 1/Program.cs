using System;

namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HOMEWORK 1
            //In a console application, ask the user to enter a positive number(n). Then ask the user to enter n positive numbers. Print the even numbers that the user has entered to the console.

            Console.Write("Please enter a positive number: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Please enter {0}. number: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Even numbers you wrote: ");
            foreach (var item in array)
            {
                if (item % 2 == 0)
                {
                    Console.Write(item + " ");
                }
            }


            //HOMEWORK 2
            //In a console application, ask the user to enter two positive numbers (n, m). Then ask the user to enter n positive numbers. From the numbers entered by the user, print the numbers that are divisible by m to the console.

            Console.Write("Please enter first positive number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter second positive number: ");
            int m = int.Parse(Console.ReadLine());
            int[] array1 = new int[n1];
            for (int i = 0; i < n1; i++)
            {
                Console.Write("Please enter a number: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            foreach (var item in array1)
            {
                if (item % m == 0 || item == m)
                {
                    Console.Write(item + " ");
                }
            }


            //HOMEWORK 3
            //In a console application, ask the user to enter a positive number (n). Then ask the user to enter n words. Print the words entered by the user from the end to the beginning to the console.
            Console.Write("Please enter a positive number: ");
            int n2 = int.Parse(Console.ReadLine());
            string[] array2 = new string[n2];
            for (int i = 0; i < n2; i++)
            {
                Console.Write("Please enter {0}. word: ", i);
                array2[i] = (Console.ReadLine());
            }
            Array.Reverse(array2);

            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }


            //HOMEWORK 4
            //In a console application, ask the user to type a sentence. Print the total number of words and letters in the sentence to the console.

            Console.Write("Please enter a sentence: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(" ");
            Console.WriteLine("You have {0} words.", words.Length);

            int letter = 0;
            char[] trim = { '!', '.', ',', ';' };
            foreach (var item in words)
            {
                string res = item.Trim(trim);
                letter += res.Length;
            }
            Console.WriteLine("You have {0} letters.", letter);
        }
    }
}
