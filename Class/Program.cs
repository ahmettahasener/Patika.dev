using System;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*****Syntax*****
            //class ClassName
            //{
            //  [Access Specifier] [Data Type] PropertyName;
            //  [Access Specifier] [Return Type] MethodName([Parameter List])
            //  {
            //  Method commands
            //  }
            //}

            //Access Specifier
            //public = Accessible from anywhere.
            //private = It can only be accessed within the class in which it is defined.
            //internal = It can only be accessed within the project it is in.
            //protected = It can only be accessed in the class in which it is defined or from classes that inherit that class.

            Employees worker1 = new Employees();
            worker1.Name = "Jack";
            worker1.Surname = "Bread";
            worker1.Number = 321;
            worker1.EmployeesInformations();

            Employees worker2 = new Employees();
            worker1.Name = "Tom";
            worker1.Surname = "Henry";
            worker1.Number = 453;
            worker1.EmployeesInformations();

            Employees worker3 = new Employees("Ford","Jerry",743);
            worker3.EmployeesInformations();

            Employees worker4 = new Employees("Tom", "Pasta");
            worker4.EmployeesInformations();

            Student student1 = new Student();
            student1.Name = "Henry";
            student1.Surname = "Tomato";
            student1.Number = 144;
            student1.Grade = 10;

            student1.WriteInformations();

            student1.NextGrade();

            student1.WriteInformations();

            Student student2 = new Student("Speed", "Flower", 452, -1);
            student2.WriteInformations();
        }
        class Employees
        {
            public string Name;
            public string Surname;
            public int Number;

            public Employees(string name, string surname, int number)
            {
                Name = name;
                Surname = surname;
                Number = number;
            }

            public Employees(string name, string surname)
            {
                Name = name;
                Surname = surname;
            }

            public Employees() { }

            public void EmployeesInformations()
            {
                Console.WriteLine("Worker's Name: " + Name);
                Console.WriteLine("Worker's Surname: " + Surname);
                Console.WriteLine("Worker's Number: " + Number);
                Console.WriteLine("********************");
            }
        }
        class Student
        {
            private string name;

            private string surname;

            private int number;

            private int grade;

            public string Name { get => name; set => name = value; }
            public string Surname { get => surname; set => surname = value; }
            public int Number { get => number; set => number = value; }
            public int Grade 
            {
                get => grade;
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Grade can not be lower than 1.");
                        grade = 1;
                    }
                    else
                        grade = value;
                }
            }

            public Student(string name, string surname, int number, int grade)
            {
                Name = name;
                Surname = surname;
                Number = number;
                Grade = grade;
            }

            public Student() { }

            public void WriteInformations()
            {
                Console.WriteLine("Student name: " + this.Name);
                Console.WriteLine("Student surname: " + this.Surname);
                Console.WriteLine("Student number: " + this.Number);
                Console.WriteLine("Student grade: " + this.Grade);
                Console.WriteLine("********************");
            }

            public void NextGrade()
            {
                this.Grade += 1;
            }
        }
        
    }
}
