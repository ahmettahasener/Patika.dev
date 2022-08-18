using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class CivicAbstract : Car
    {
        public override Brand WhichBrand()
        {
            return Brand.Honda;
        }

        public override Color StandardColor()
        {
            return Color.Black;
        }
    }
}
