using System;

namespace Bar_Example
{
    class TaxHolidayVisitor : IVisitor
    {
        public double Visit(Liqour liqourItem)
        {
            return (liqourItem.getPrice() * 1.50);
        }
        
        public double Visit(Tobacco tobaccoItem)
        {
            return (tobaccoItem.GetPrice() * 1.50);
        }
    }
}
