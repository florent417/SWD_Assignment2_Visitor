using System;
using System.Collections.Generic;
using System.Text;

namespace Toys
{
    class HolidaySpecials : IVisitor
    {
        HolidaySpecials()
        {
        }

        public void Visit(Car car)
        {
            Console.WriteLine("For the holidays you can get the car with the original theme {0} changed to a theme of the current holiday season", car.Theme);
            Console.WriteLine("With a reduced price going from {0} to {1}!!",car.Price,car.Price*0.50);
            Console.WriteLine("Including accessories for the current season!");
        }

        public void Visit(Actionman actionman)
        {

        }
    }
}
