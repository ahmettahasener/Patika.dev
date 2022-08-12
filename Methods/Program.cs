using System;
using System.Linq;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            Console.WriteLine(a + b);



            int sum = Addition(a, b);
            Console.WriteLine(sum);



            int number1 = 20; //here it uses the value of the variable named number 1. So when you write number 1 in the method, it uses the number "20".
            int number2 = 30;
            var resultRef = AdditionRef(ref number1, number2); //We have given it with the ref keyword to use the number 1 inside the method.
            Console.WriteLine(resultRef);
            var resultParam = Addition(3, 4, 5, 6, 6, 7, 7, 8, 8, 8, 8, 9, 234, 234, 52);
            Console.WriteLine(resultParam);

            Methods method = new Methods(); //created an instance
            method.WriteToConsole("hello world!");
            method.AdditionOut(32, 43, out int value1);
            Console.WriteLine(value1);


            //recursive methods
            //3^4
            int resultRecursive = 1;
            for (int i = 1; i < 5; i++)
            {
                resultRecursive = resultRecursive * 3;

            }
            Console.WriteLine("3^4 not recursive " + resultRecursive);

            operation operation = new();
            Console.WriteLine("3^4 recursive " + operation.Exponential(3, 4));



            //extension methods
            string text1 = "I want to be game developer.";
            Console.WriteLine(text1);
            bool resultExtension = text1.CheckSpaces();
            Console.WriteLine(resultExtension);

            if (resultExtension)
                Console.WriteLine(text1.RemoveWhiteSpaces());
            Console.WriteLine(text1.MakeUpperCase());
            Console.WriteLine(text1.MakeLowerCase());

            int[] array = { 1, 7, 5, 41, 45, 6, 8, 23, 9, 11 };
            array.SortArray();
            array.WriteToConsole();

            int number3 = 8;
            Console.WriteLine(number3.IsEvenNumber());
            Console.WriteLine(text1.GetFirstCharacter());



            //out parameters
            string number = "999";
            bool result = int.TryParse(number, out int outNumber);
            if (result)
            {
                Console.WriteLine(number);
                Console.WriteLine("string converted to int");
            }
            else
            {
                Console.WriteLine("string not converted to int");
            }
        }
        //default value
        static int Addition(int Value1, int value2 = 10)
        {
            return (Value1 + value2);
        }
        //usage of "ref" keyword.
        static int AdditionRef(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        //method overloading.
        //Method signature: methodName + parameternumber + parameter types
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        //usage of "params" keyword.
        static int Addition(params int[] numbers)
        {
            return numbers.Sum();
        }
    }

    class Methods
    {
        public void WriteToConsole(string text)
        {
            Console.WriteLine(text);
        }

        public void AdditionOut(int number1, int number2, out int resultOut)
        {
            resultOut = number1 + number2;
        }
    }
    class operation
    {
        public int Exponential(int sayi, int us)
        {
            if (us < 2)
                return sayi;

            return Exponential(sayi, us - 1) * sayi;
        }
        //Exponential(3,4)
        //Exponential(3,3)*3
        //Exponential(3,2)*3*3
        //Exponential(3,1)*3*3*3
        //3*3*3*3 = 3^4
    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] array = param.Split(" ");
            return string.Join("",array);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void WriteToConsole(this int[] param)
        {
            foreach (int item in param)
                Console.WriteLine(item);
        }

        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }
    }
}
