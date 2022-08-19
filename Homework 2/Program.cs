using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Throw the 20 positive numbers entered from the keyboard into 2 separate lists as prime and non-prime. (Write using the ArrayList class.)

            //Block negative and non-numeric entries.
            //Print the elements of each array in ascending order.
            //Print the number of elements and the average of both arrays to the screen.

            ArrayList prime = new ArrayList();
            ArrayList non_prime = new ArrayList();
            Regex pattern = new Regex("^[a-zA-Z]+$");
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Please enter a number: ");
                string check = Console.ReadLine();
                if (pattern.IsMatch(check) || int.Parse(check) < 0)
                {
                    Console.WriteLine("Please enter a positive number and do not write non numeric characters.");
                }
                else
                {
                    int check1 = int.Parse(check);
                    if (Prime_Check(check1))
                    {
                        prime.Add(check1);
                    }
                    else
                        non_prime.Add(check1);
                }
                
            }
            prime.Reverse();
            non_prime.Reverse();
            
            Console.WriteLine("Prime numbers are : ");
            foreach (var item in prime)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*******************");

            Console.WriteLine("Non-prime numbers are : ");
            foreach (var item in non_prime)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Number of prime numbers: " + prime.Count);
            Console.WriteLine("Number of non prime numbers: " + non_prime.Count);

            int sumofprime = 0;
            foreach (var item in prime)
            {
                sumofprime += Convert.ToInt32(item);
            }

            int sumofnonprime = 0;
            foreach (var item in non_prime)
            {
                sumofnonprime += Convert.ToInt32(item);
            }

            Console.WriteLine("Average of prime numbers: {0}", sumofprime/prime.Count);
            Console.WriteLine("Average of non prime numbers: {0}", sumofnonprime / non_prime.Count);

        }
        public static bool Prime_Check(int sayi)
        {
            bool status = false;

            int check = 0;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    check = 1;
                    break;
                }
            }
            if (check == 1)
            {
                status = false;
            }
            else
            {
                status = true;
            }

            return status;
        }

    }
}

