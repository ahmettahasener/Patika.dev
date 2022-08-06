using System;

namespace Type_Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion

            byte c = 2;
            sbyte o = 8;
            short a = 4;
            ushort b = 3;



            int d = a + b + c + o;
            Console.WriteLine("d = " + d);

            long e = d;
            Console.WriteLine("e = " + e);

            float f = d;
            Console.WriteLine("f = " + f);

            string g = "text";
            char h = 'h';
            object obj = g + h + f;
            Console.WriteLine("o = " + obj);


            //explicit conversion

            float f1 = 7.10f;
            byte b1 = (byte)f1;
            Console.WriteLine("f1 = " + f1);

            double d1 = 2.5;
            float f2 = (float)d1;
            Console.WriteLine("f2 = " + f2);

            long long1 = 1234667;
            int int1 = (int)long1;
            Console.WriteLine("int1 = " + long1);

            //ToString method
            int int2 = 13;
            string str = int2.ToString();
            Console.WriteLine("str = " + str);

            string str2 = 18.6f.ToString();
            Console.WriteLine("s2 = " + str2);

            //System.convert
            string str3 = "10";
            int sayi = Convert.ToInt32(str3);

            //parse
            string str4 = "21";
            string str5 = "15.5";
            int int3;
            double double2;

            int3 = Int32.Parse(str4);
            double2 = Double.Parse(str5);

            Console.WriteLine("int 3 = {0} double2 = {0}", int3, double2);
        }
    }
}
