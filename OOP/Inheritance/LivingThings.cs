using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class LivingThings
    {
        protected void Nutrition()
        {
            Console.WriteLine("Living things are have to nutrition.");
        }

        protected void Respiratory()
        {
            Console.WriteLine("Living things are have to respiratory.");
        }

        protected void Excretory()
        {
            Console.WriteLine("Living things are have to excretory.");
        }

        public virtual void ResponseToStimuli()
        {
            Console.WriteLine("Living things react to stimuli.");
        }
    }
    public sealed class Sealed
    {
        //The sealed keyword is a class and method modifier. If a class is marked with the sealed command, it cannot be inherited from that class. So that class cannot be the base class of another class. Also, if a method is marked with the sealed command, classes derived from that method are prevented from overriding that method.
    }
}
