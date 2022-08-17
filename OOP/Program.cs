using OOP.Inheritance;
using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SeedPlants seedPlant = new SeedPlants();
            seedPlant.PropagationBySeed();

            Console.WriteLine("***********************");

            Birds Eagle = new Birds();
            Eagle.Fly();
        }
    }
}
