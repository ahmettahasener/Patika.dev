using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Animals : LivingThings
    {
        protected void Adaption()
        {
            Console.WriteLine("Animals are have to adaption.");
        }
        public override void ResponseToStimuli()
        {
            base.ResponseToStimuli();
            Console.WriteLine("Animals respond to touch");
        }
    }
    public class Reptiles : Animals
    {
        public Reptiles()
        {
            base.Adaption();
            base.Excretory();
            base.Nutrition();
            base.Respiratory();
        }
        public void CrawlingMotion()
        {
            Console.WriteLine("Reptiles move by crawling.");
        }
    }
    public class Birds : Animals
    {
        public Birds()
        {
            base.Adaption();
            base.Excretory();
            base.Nutrition();
            base.Respiratory();
            base.ResponseToStimuli();
        }
        public void Fly()
        {
            Console.WriteLine("Birds are fly.");
        }
    }
}
