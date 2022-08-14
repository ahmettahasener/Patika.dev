using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using System.Collections.Generic;
            //List<T> class
            //T -> object
            //List<string> colors = new List<string>();

            List<int> numberList = new List<int>();
            numberList.Add(13);
            numberList.Add(25);
            numberList.Add(34);
            numberList.Add(4);
            numberList.Add(56);
            numberList.Add(67);
            numberList.Add(7);
            numberList.Add(83);
            numberList.Add(95);
            numberList.Add(10);

            List<string> colorList = new List<string>();
            colorList.Add("green");
            colorList.Add("blue");
            colorList.Add("red");
            colorList.Add("orange");
            colorList.Add("yellow");

            //count
            Console.WriteLine(numberList.Count);
            Console.WriteLine(colorList.Count);

            //foreach and listForEach
            foreach (var item in colorList)
            {
                Console.WriteLine(item);
            }

            colorList.ForEach(item=> Console.WriteLine(item));

            //remove
            colorList.Remove("green");
            numberList.Remove(4);
            colorList.RemoveAt(1);
            numberList.RemoveAt(2);

            //contains
            if (colorList.Contains("yellow"))
            {
                Console.WriteLine("Yellow found in the list.");
            }

            //BinarySearch
            colorList.ForEach(item => Console.WriteLine(item));
            Console.WriteLine(colorList.BinarySearch("orange"));
            numberList.ForEach(item => Console.WriteLine(item));
            Console.WriteLine(numberList.BinarySearch(95));

            //convert array to list
            string[] animals = { "cat", "dog", "tiger" };
            List <string> animalsList = new List<string>(animals);

            //clear
            animalsList.Clear();

            //object in list
            List<Users> usersList = new List<Users>();
            Users user1 = new Users();
            user1.Name = "Jack";
            user1.Surname = "Programmer";
            user1.Age = 22;

            Users user2 = new Users();
            user2.Name = "Tony";
            user2.Surname = "Designer";
            user2.Age = 20;

            usersList.Add(user1);
            usersList.Add(user2);

            List<Users> usersList2 = new List<Users>();
            usersList2.Add(new Users()
            {
                Name = "Logan",
                Surname = "Artist",
                Age = 22
            });

            foreach (var user in usersList)
            {
                Console.WriteLine("Name = {0}, Surname = {1}, Age = {2}",user.Name,user.Surname,user.Age);
            }


        }
    }
    public class Users
    {
        private string name;

        private string surname;

        private int age;
        
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
    }
}
