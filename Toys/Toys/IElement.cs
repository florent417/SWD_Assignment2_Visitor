using System;
using System.Collections.Generic;
using System.Text;

namespace Toys
{
    interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
