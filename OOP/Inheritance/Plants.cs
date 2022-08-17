using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Plants : LivingThings
    {

        protected void Photosynthesis()
        {
            Console.WriteLine("Plants are have to photosynthesis.");
        }

        public override void ResponseToStimuli()
        {
            //base.ResponseToStimuli();
            Console.WriteLine("Plants react to the sun");
        }
    }
    public class SeedPlants : Plants
    {
        public SeedPlants()
        {
            base.Photosynthesis();
            base.Excretory();
            base.Nutrition();
            base.Respiratory();
            base.ResponseToStimuli();
        }

        public void PropagationBySeed()
        {
            Console.WriteLine("Seed plants can propagation by seed.");
        }
    }

    public class SeedlessPlants : Plants
    {
        public SeedlessPlants()
        {
            base.Photosynthesis();
            base.Excretory();
            base.Nutrition();
            base.Respiratory();
        }
        public void ReproductionBySpores()
        {
            Console.WriteLine("Seedless plants can reproduction by spores.");
        }
    }
}
