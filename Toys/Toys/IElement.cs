using System;
using System.Collections.Generic;
using System.Text;

namespace Workers
{
    interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
