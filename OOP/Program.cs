using OOP.Inheritance;
using OOP.Interface;
using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SeedPlants seedPlant = new SeedPlants();
            seedPlant.PropagationBySeed();

            Console.WriteLine("********************************");

            Birds Eagle = new Birds();
            Eagle.Fly();
            Console.WriteLine("********************************");


            //Interface

            FileLogger fileLogger = new FileLogger();
            fileLogger.writeLog();

            SmsLogger smsLogger = new SmsLogger();
            smsLogger.writeLog();

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.writeLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();
            Console.WriteLine("**************Interface******************");


            //Interface Example
            Focus focus = new Focus();
            Console.WriteLine(focus.WhichBrand().ToString());
            Console.WriteLine(focus.HowManyTires().ToString());
            Console.WriteLine(focus.StandardColor().ToString());

            Civic civic = new Civic();
            Console.WriteLine(civic.WhichBrand().ToString());
            Console.WriteLine(civic.HowManyTires().ToString());
            Console.WriteLine(civic.StandardColor().ToString());
            Console.WriteLine("**************Abstract******************");

            //Abstract Class
            FocusAbstract focusAbstract = new FocusAbstract();
            Console.WriteLine(focusAbstract.WhichBrand().ToString());
            Console.WriteLine(focusAbstract.HowManyTires().ToString());
            Console.WriteLine(focusAbstract.StandardColor().ToString());

            CivicAbstract civicAbstract = new CivicAbstract();
            Console.WriteLine(civicAbstract.WhichBrand().ToString());
            Console.WriteLine(civicAbstract.HowManyTires().ToString());
            Console.WriteLine(civicAbstract.StandardColor().ToString());
        }
    }
}
