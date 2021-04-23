using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Interface
{
    public interface IPeople
    {
        void Accept(IVisitor person);
    }
}
