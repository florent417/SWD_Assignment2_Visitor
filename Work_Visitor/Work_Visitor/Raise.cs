using System;
using System.Collections.Generic;
using System.Text;

namespace Work_Visitor
{
    class Raise: IVisitor
    {
        private double _multiplier = 0;

        public Raise(double mul)
        {
            _multiplier = mul;
        }

        public void Visit(DaytimeWorker daytimeWorker)
        {
            Console.WriteLine("Daytime workers have now gotten a raise");
            Console.WriteLine(daytimeWorker.Name + ":");
            Console.WriteLine("Old hourly pay: {0}", daytimeWorker.HourlyPay);
            Console.WriteLine("New hourly pay {0}", daytimeWorker.HourlyPay *= _multiplier);
        }

        public void Visit(NighttimeWorker nighttimeWorker)
        {
            Console.WriteLine("Nighttime workers have now gotten a raise");
            Console.WriteLine(nighttimeWorker.Name + ":");
            Console.WriteLine("Old hourly pay: {0}", nighttimeWorker.HourlyPay);
            Console.WriteLine("New hourly pay {0}", nighttimeWorker.HourlyPay *= _multiplier);
        }
    }
}
