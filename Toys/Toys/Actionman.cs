using System;
using System.Collections.Generic;
using System.Text;

namespace Toys
{
    class Actionman : IElement
    {
        public string Theme { get; set; }
        public double Price { get; set; }

        public Actionman()
        {
            Theme = "No clothes";
        }

        public void PrintTheme()
        {
            Console.WriteLine("The current theme is: " + Theme);
        }

        public void Accept(IVisitor visitor)
        {

        }
    }
}
