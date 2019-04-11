using System;
using System.Collections.Generic;
using System.Text;

namespace Toys
{
    class Actionman : IElement
    {
        public string Theme { get; set; }
        private double _price;

        public Actionman(double price)
        {
            Theme = "No clothes";
            _price = price;
        }

        public void PrintTheme()
        {
            Console.WriteLine("The current theme is: " + Theme);
        }

        public double GetPrice()
        {
            return _price;
        }

        public void Accept(IVisitor visitor)
        {
            
        }
    }
}
