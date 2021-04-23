using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Model;

namespace VisitorPattern.Interface
{
    public interface IVisitor
    {
        void TreatmentEmployee(Employee element);
        void TreatmentClient(Client element);
    }
}
