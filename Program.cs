using System;
using VisitorPattern.Model;
using VisitorPattern.Services;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var client = new Client();
            client.name = "Client 1";
            client.email = "client1@personal.com";
            client.documentNumber = "ABC";

            var employee = new Employee();
            employee.name = "Employee 50";
            employee.email = "employee50@enterprise.com";
            employee.registrationNumber = "ER34";
            employee.cellPhone = "55112222222";

            var savePeople = new SavePeople();
            var sendMessage = new SendMessage();

            employee.Accept(savePeople);
            employee.Accept(sendMessage);


            client.Accept(savePeople);
            client.Accept(sendMessage);

           
        }
    }
}
