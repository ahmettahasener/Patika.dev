using System;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("bir sayı giriniz: ");
                int num;
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("girdiğiniz sayı: " + num);
            }
            catch (Exception hata)
            {
                Console.WriteLine("Hatanız: " + hata.Message.ToString());
            }
            finally
            {
                Console.WriteLine("işlem tamamlandı");
            }


            try
            {
                //int a = int.Parse(null);
                // int a = int.Parse("test");
                int a = int.Parse("20000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz: " + ex);
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil. " + ex);
            }
            catch (OverflowException ex)  //veritipin aralıgına uygun olmayan değer verilince alınan hata
            {
                Console.WriteLine("Çok küçük veya çok büyük değer girdiniz. " + ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }
    }
}
}
