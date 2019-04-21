using System;
using System.Collections.Generic;
using System.Text;

namespace Workers
{
    class NighttimeWorker: IElement
    {
        public string Name { get; set; }
        public double HourlyPay { get; set; }

        public NighttimeWorker(string name, double pay)
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
