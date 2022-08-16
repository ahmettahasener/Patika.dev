using System;

namespace Static_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of Employees: {0}", Workers.NumberOfEmployees);
            Workers worker1 = new Workers("Tom","Henry","IT");
            Console.WriteLine("Number of Employees: {0}", Workers.NumberOfEmployees);
            Workers worker2 = new Workers("Jack", "Rosa", "Software");
            Workers worker3 = new Workers("Daisy", "Anna", "Sales");
            Console.WriteLine("Number of Employees: {0}", Workers.NumberOfEmployees);

            //Operation operation = new Operation();  *****Operation is a static class. So it gives an error.*****

            Console.WriteLine(Operation.Addition(100, 200));
            Console.WriteLine(Operation.Extraction(300, 80));

            //Struct
            Rectangle_Class rectangle_Class = new Rectangle_Class();
            rectangle_Class.ShortEdge = 4;
            rectangle_Class.LongEdge = 8;
            Console.WriteLine("The area of the class rectangle is {0} ", rectangle_Class.Area());

            Rectangle_Struct rectangle_Struct = new Rectangle_Struct();
            rectangle_Struct.ShortEdge = 4;
            rectangle_Struct.LongEdge = 8;
            Console.WriteLine("The area of the struct rectangle is {0} ", rectangle_Struct.Area());

            Rectangle_Struct rectangle_struct;
            rectangle_struct.ShortEdge = 4;
            rectangle_struct.LongEdge = 8;
            Console.WriteLine("The second area of the struct rectangle is {0} ", rectangle_struct.Area());
        }
    }
    class Workers
    {
        private static int numberOfEmployees;

        public static int NumberOfEmployees { get => numberOfEmployees;}

        private string Name;
        private string Surname;
        private string Department;

        static Workers()
        {
            numberOfEmployees = 0;
        }

        public Workers(string name, string surname, string department)
        {
            this.Name = name;
            this.Surname = surname;
            this.Department = department;
            numberOfEmployees += 1;
        }
    }
    static class Operation
    {
        //Any non-static method or property cannot be defined or used in static classes.
        //Static classes cannot be inherited
        public static long Addition(int number1,int number2)
        {
            return number1 + number2;
        }

        public static long Extraction(int number1, int number2)
        {
            return number1 - number2;
        }
    }
    class Rectangle_Class
    {
        public int ShortEdge;
        
        public int LongEdge;
        
        public long Area()
        {
            return this.ShortEdge * this.LongEdge;
        }
    }
    struct Rectangle_Struct
    {
        public int ShortEdge;

        public int LongEdge;

        public long Area()
        {
            return this.ShortEdge * this.LongEdge;
        }
    }
}
