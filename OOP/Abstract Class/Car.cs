using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Car
    {
        public int HowManyTires()
        {
            return 4;
        }
        public virtual Color StandardColor()
        {
            return Color.White;
        }
        public abstract Brand WhichBrand();

    }
}
