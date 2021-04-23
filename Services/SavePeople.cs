using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Interface;
using VisitorPattern.Model;

namespace VisitorPattern.Services
{
    public class SavePeople : IVisitor
    {
        
        public void TreatmentClient(Client element)
        {
            Console.WriteLine($"Saving client name: {element.name}");
        }

        public void TreatmentEmployee(Employee element)
        {
            Console.WriteLine($"Save employee name: {element.name}");
        }
        
    }
}
