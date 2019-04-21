using System;
using System.Collections.Generic;
using System.Text;

namespace Work_Visitor
{
    interface IVisitor
    {
        void Visit(DaytimeWorker daytimeWorker);
        void Visit(NighttimeWorker nighttimeWorker);
    }
}
