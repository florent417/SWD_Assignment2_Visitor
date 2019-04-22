using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Example
{
    /// <summary>
    /// Interface for Visitorclasses.
    /// All classes which supports visitors must be implemented in here.
    /// </summary>
    public interface IVisitor
    {
        double Visit(Liqour liqourItem);
        double Visit(Tobacco tobaccoItem);
    }
}
