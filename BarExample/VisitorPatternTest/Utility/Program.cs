using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration for visitor-objects
            TaxHolidayVisitor HolCalc = new TaxHolidayVisitor();
            HappyHourVisitor HapCalc = new HappyHourVisitor();

            //Default prices are set for objects
            Liqour RedWine = new Liqour(10.0);
            Tobacco Prince = new Tobacco(30.5);

            //Print default prices for products
            Console.WriteLine("*** Prices by default ***");
            Console.WriteLine("REDWINE: " + RedWine.getPrice());
            Console.WriteLine("PRINCE: " + Prince.GetPrice() + "\n");

            //Print modified prices for products. Prices has been modified by visitors.
            Console.WriteLine("*** Holiday prices ***");
            Console.WriteLine("REDWINE: " + RedWine.Accept(HolCalc));
            Console.WriteLine("PRINCE: " + Prince.Accept(HolCalc));
            Console.WriteLine();
            Console.WriteLine("*** Happyhour prices ***");
            Console.WriteLine("REDWINE happyhour price: " + RedWine.Accept(HapCalc));
            Console.WriteLine("PRINCE happyhour price: " + Prince.Accept(HapCalc));
        }
    }
}
