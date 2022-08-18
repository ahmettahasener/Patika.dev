using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class CorollaAbstract : Car
    {
        public override Brand WhichBrand()
        {
            return Brand.Toyota;
        }
    }
}
