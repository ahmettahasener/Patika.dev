using System;
using System.Collections;
using System.Collections.Generic;

namespace Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that stores the vowels in a sentence entered from the keyboard in an array and sorts the elements of the array.

            Console.Write("Please write a sentence: ");
            string sentence = Console.ReadLine();

            List<char> ContainedVowels = new List<char>();
            char[] letters = sentence.ToCharArray();
            char[] vowels = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            foreach (var letter in vowels)
            {
                int value = Array.IndexOf(letters, letter);
                if (value != -1) 
                {
                    ContainedVowels.Add(letter);
                }
            }

            Console.Write("Vowels in the sentence: ");
            foreach (var letter in ContainedVowels)
            {
                Console.Write(letter + " ");
            }
        }
    }
}
