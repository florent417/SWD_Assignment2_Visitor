using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Example
{
    public class Liqour : IElement
    {
        private double price;

        public Liqour(double item)
        {
            price = item;
        }

        public double Accept(IVisitor Visitor)
        {
            return Visitor.Visit(this);
        }

        public double getPrice()
        {
            return price;
        }
    }
}
