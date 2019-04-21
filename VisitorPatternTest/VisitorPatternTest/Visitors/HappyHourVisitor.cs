using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Example
{
    class HappyHourVisitor : IVisitor
    {
        public double Visit(Liqour liqourItem)
        {
            return (liqourItem.getPrice() * 0.30);
        }

        public double Visit(Tobacco tobaccoItem)
        {
            return (tobaccoItem.GetPrice() * 0.30);
        }
    }
}
