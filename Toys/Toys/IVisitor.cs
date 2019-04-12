using System;
using System.Collections.Generic;
using System.Text;

namespace Toys
{
    interface IVisitor
    {
        void Visit(Actionman actionman);
        void Visit(Car car);
    }
}
