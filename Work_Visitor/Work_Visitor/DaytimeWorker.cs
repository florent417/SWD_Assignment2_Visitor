using System;
using System.Collections.Generic;
using System.Text;

namespace Work_Visitor
{
    class DaytimeWorker: IElement
    {
        public string Name { get; set; }
        public double HourlyPay { get; set; }

        public DaytimeWorker(string name, double pay)
        {
            Name = name;
            HourlyPay = pay;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
