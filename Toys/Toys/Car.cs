using System;
using System.Collections.Generic;
using System.Text;

namespace Toys
{
    class Car : IElement
    {
        public string Theme { get; set; }
        public string Accessories { get; set; }
        public double Price { get; set; }

        public Car(double price, string theme, string accessories)
        {
            Price = price;
            Theme = theme;
            Accessories = accessories;
        }

        public void Accept(IVisitor visitor)
        {

        }

    }
}
