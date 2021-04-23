using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Interface;

namespace VisitorPattern.Model
{
    public class Employee : IPeople
    {
        public string name { get; set; }
        public string registrationNumber { get; set; }
        public string email { get; set; }
        public string cellPhone { get; set; }

        public void Accept(IVisitor person)
        {
            person.TreatmentEmployee(this);
        }
    }
}
