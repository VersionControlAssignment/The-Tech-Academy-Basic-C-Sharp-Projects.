using System;

namespace Polymorphism_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.firstName = "Paul";
            employee.lastName = "Rudd";
            employee.ID = 1;

            employee.SayName(employee.firstName, employee.lastName);

            employee.Quit();

            IQuittable Emp1 = new Employee();

            Emp1.Quit();

            Console.ReadLine();
        }
    }
}