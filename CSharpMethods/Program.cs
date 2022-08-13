using System;

namespace CSharpMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string variable1 = "hello world 1";
            string variable2 = "hello world 2";

            //Length
            Console.WriteLine(variable1.Length);

            //ToUpper-ToLower
            Console.WriteLine(variable1.ToUpper());
            Console.WriteLine(variable1.ToLower());

            //Concat
            Console.WriteLine(string.Concat(variable1," 13.08.2022"));

            //Compare, CompareTo
            //if var1 and var2 equal = 0
            //if var1 bigger than var2 = 1
            //if var2 bigger than var1 = 1
            Console.WriteLine(variable1.CompareTo(variable2));

            //last bool value checks upper or lower case
            Console.WriteLine(string.Compare(variable2 , variable1, true)); //last parameter is ignore case, if true case sensetive
            Console.WriteLine(string.Compare(variable2, variable1, false));

            //Contains
            Console.WriteLine(variable1.Contains(variable2)); //If it finds variable, it returns the index of variable, otherwise it returns -1

            //ends-startwith
            Console.WriteLine(variable1.EndsWith("1"));
            Console.WriteLine(variable2.StartsWith("world 2"));

            //IndexOf
            //where it finds the index first
            Console.WriteLine(variable1.IndexOf("l"));
            Console.WriteLine(variable1.IndexOf("ld"));
            Console.WriteLine(variable1.LastIndexOf("d"));

            //Insert
            Console.WriteLine(variable1.Insert(3," added text "));

            //PadLeft, PadRight
            Console.WriteLine(variable1 + variable2.PadLeft(30));
            Console.WriteLine(variable1 + variable2.PadLeft(30, '*'));
            Console.WriteLine(variable1.PadRight(30) + variable2);
            Console.WriteLine(variable1.PadRight(30, '*') + variable2);

            //Remove
            Console.WriteLine(variable1.Remove(7));
            Console.WriteLine(variable2.Remove(2,5));
            Console.WriteLine(variable2.Remove(0,1));

            //Replace
            Console.WriteLine(variable1.Replace("hello","merhaba"));
            Console.WriteLine(variable1.Replace("world", "dünya"));

            //Split
            Console.WriteLine(variable1.Split(" ")[1]); //split the string by blanks, throw it into the array and fetch the 1st index

            //Substring
            Console.WriteLine(variable2.Substring(2,5)); //Starting from the 2nd index up to the 5th index
            Console.WriteLine(variable2.Substring(4)); //Gets all indexes starting from the 4th index to the end

            Console.WriteLine(DateTime.Now); //9.06.2021 18:35:15
            Console.WriteLine(DateTime.Now.Date); //9.06.2021 00:00:00
            Console.WriteLine(DateTime.Now.Day); //9
            Console.WriteLine(DateTime.Now.Month); //6
            Console.WriteLine(DateTime.Now.Year); //2021
            Console.WriteLine(DateTime.Now.Hour); //18
            Console.WriteLine(DateTime.Now.Minute); //35
            Console.WriteLine(DateTime.Now.Second); //15

            Console.WriteLine(DateTime.Now.DayOfWeek); //Wednesday
            Console.WriteLine(DateTime.Now.DayOfYear); //160

            Console.WriteLine(DateTime.Now.ToLongDateString()); //Wednesday, June 9, 2021
            Console.WriteLine(DateTime.Now.ToShortDateString()); //9.06.2021
            Console.WriteLine(DateTime.Now.ToLongTimeString()); //18:38:42
            Console.WriteLine(DateTime.Now.ToShortTimeString()); //18:38

            //şuanki zamana eklemeler yapmak
            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); //9
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Saturday

            Console.WriteLine(DateTime.Now.ToString("MM")); //06
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //April

            Console.WriteLine(DateTime.Now.ToString("yy")); //21
            Console.WriteLine(DateTime.Now.ToString("yyy")); //2021

            Console.WriteLine(Math.Abs(-25)); //25
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(70));

            Console.WriteLine(Math.Ceiling(22.5)); //round to the nearest big number
            Console.WriteLine(Math.Round(22.7));  //23 (rounds to whichever number is closer)
            Console.WriteLine(Math.Round(22.3));  //22
            Console.WriteLine(Math.Floor(22.5));  //round to the nearest smaller number

            Console.WriteLine(Math.Max(23, 74));
            Console.WriteLine(Math.Min(23, 74));

            Console.WriteLine(Math.Pow(2, 4)); //2^4

            Console.WriteLine(Math.Sqrt(9)); //9^2

            Console.WriteLine(Math.Log(9)); //E-base equivalent of Log9 9

            Console.WriteLine(Math.Exp(3)); //e^3

            Console.WriteLine(Math.Log10(10)); //The logarithm base 10 equivalent of 10

        }
    }
}
