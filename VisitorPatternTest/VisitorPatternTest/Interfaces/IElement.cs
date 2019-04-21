using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Example
{
    /// <summary>
    /// All classes which supports the Visitorpattern must implement this interface.
    /// The Accept-method requires an object from a class which implements the IVisor interface.
    /// </summary>
    interface IElement
    {
        double Accept(IVisitor visitor);
    }
}