using System;
using System.Collections.Generic;
using System.Text;

namespace Toys
{
    class Actionman : IElement
    {
        public string Theme { get; set; }
        public string Accessories { get; set; }
        public double Price { get; set; }   

        public Actionman(double price, string theme, string accessories)
        {
            Theme = theme;
            Accessories = accessories;
            Price = price;
        }

        public void Accept(IVisitor visitor)
        {
            
        }
    }
}
