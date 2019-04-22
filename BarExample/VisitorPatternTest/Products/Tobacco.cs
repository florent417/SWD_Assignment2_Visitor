using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Example 
{
    public class Tobacco : IElement
    {
        private double _price;
        public Tobacco(double item)
        {
            _price = item;
        }
        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public double GetPrice()
        {
            return _price;
        }
    }
}
