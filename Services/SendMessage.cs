using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Interface;
using VisitorPattern.Model;

namespace VisitorPattern.Services
{
    public class SendMessage : IVisitor
    {
        
        public void TreatmentClient(Client element)
        {
            Console.WriteLine($"Send email to a  client email: {element.email}");
        }

        public void TreatmentEmployee(Employee element)
        {
            Console.WriteLine($"Send SMS to a employee cell phone: {element.cellPhone}");
        }
      
    }
}
