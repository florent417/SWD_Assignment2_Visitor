using System;
using System.Collections.Generic;
using System.Text;

namespace Work_Visitor
{
    interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
