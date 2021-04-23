using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Interface;

namespace VisitorPattern.Model
{
    public class Client : IPeople
    {
        public string name { get; set; }
        public string documentNumber { get; set; }
        public string email { get; set; }
      

        public void Accept(IVisitor person)
        {
            person.TreatmentClient(this);
        }

        
    }
}
