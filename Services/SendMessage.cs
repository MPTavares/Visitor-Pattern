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
            Console.WriteLine($"Sending email to a  client email: {element.email}");
            

        }

        public void TreatmentEmployee(Employee element)
        {
            Console.WriteLine($"Sending SMS to a employee cell phone: {element.cellPhone}");
        }
      
    }
}
