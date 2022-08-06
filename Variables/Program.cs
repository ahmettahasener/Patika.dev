using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 2;
            double ondalik = 2.2;
            float flo_ondalik = 2.2f;
            bool mantık = true;
            char ch = 'c';
            string merhaba = "hello world !";
            string sayılı = "10";
            object o1 = "sa";
            object o2 = 3;
            DateTime dt = DateTime.Now;


            string yenideger = merhaba + sayi.ToString();

            int toplam = sayi + Convert.ToInt32(sayılı);
            string datetime = DateTime.Now.ToString("dd.MM.yy");
            string hour = DateTime.Now.ToString("hh");
            string hour1 = DateTime.Now.ToString("HH");

            Console.WriteLine(datetime);
            Console.WriteLine(hour);
            Console.WriteLine(hour1);
            Console.ReadLine();
        }
    }
}
