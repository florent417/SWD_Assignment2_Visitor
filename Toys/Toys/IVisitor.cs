using System;
using System.Collections.Generic;
using System.Text;

namespace Workers
{
    interface IVisitor
    {
        void Visit(DaytimeWorker daytimeWorker);
        void Visit(NighttimeWorker nighttimeWorker);
    }
}
