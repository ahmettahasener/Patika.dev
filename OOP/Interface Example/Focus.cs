using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Focus : ICar
    {
        public int HowManyTires()
        {
            return 4;
        }

        public Color StandardColor()
        {
            return Color.White;
        }

        public Brand WhichBrand()
        {
            return Brand.Ford;
        }
    }
}
