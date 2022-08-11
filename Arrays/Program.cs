using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array definition
            string[] colors = new string[5];
            string[] animals = { "cat", "dog", "monkey", "tiger" };
            int[] array;
            array = new int[4];


            //assigning values ​​to arrays
            colors[0] = "blue";
            colors[1] = "red";
            Console.WriteLine(colors[0]);
            Console.WriteLine(animals[0]);


            //loops with arrays
            Console.Write("Please enter the array length: ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array1 = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Please enter {0}. number: ", i + 1);
                array1[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach (var number in array1)
            {
                sum += number;
            }
            Console.WriteLine(sum);


            //sort
            int[] array2 = { 3, 54, 6, 7, 88, 53, 25 };
            Console.WriteLine("*****not sorted*****");
            foreach (var number in array2)
                Console.WriteLine(number);

            Array.Sort(array2);
            Console.WriteLine("*****sorted*****");

            foreach (var number in array2)
            {
                Console.WriteLine(number);
            }


            //clear (Using array 2 elements, it converts 2 piece elements to 0 starting from the 3rd index.)
            Console.WriteLine("*****clear*****");
            Array.Clear(array2, 3, 2);
            foreach (var number in array2)
                Console.WriteLine(number);


            //reverse
            Console.WriteLine("*****reverse*****");
            Array.Reverse(array2);
            foreach (var number in array2)
                Console.WriteLine(number);


            //indexof
            Console.WriteLine("*****indexof*****");
            Console.WriteLine(Array.IndexOf(array2, 0));
            
            Console.WriteLine(Array.IndexOf(array2, 99)); //The IndexOf( ) method returns -1 if it doesn't find what it's looking for.

            string message = "happy home"; //The IndexOf() method takes a string and char type value as a parameter.
            string search = "house";
            Console.WriteLine(message.IndexOf(search));


            //resize
            Console.WriteLine("*****resize*****");

            Console.WriteLine("list increased"); 
            Array.Resize<int>(ref array2, 9);
            foreach (var number in array2)
                Console.WriteLine(number);

            Console.WriteLine("list decreased");
            Array.Resize<int>(ref array2, 3);
            foreach (var number in array2)
                Console.WriteLine(number);
        }
    }
}
