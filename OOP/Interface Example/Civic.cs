using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Civic : ICar
    {
        public int HowManyTires()
        {
            return 4;
        }

        public Color StandardColor()
        {
            return Color.Black;
        }

        public Brand WhichBrand()
        {
            return Brand.Honda;
        }
    }
}
