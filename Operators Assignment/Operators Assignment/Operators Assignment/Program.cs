using System;
using System.Collections.Generic;
using System.Linq;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property.
            //Remember that comparison operators must be overloaded in pairs. 
            List<Employee> actors = new List<Employee>()
            {
                new Employee() {Id = 1, firstName = "Robert", lastName = "Downey Jr." },
                new Employee() {Id = 2, firstName = "Chris", lastName = "Evans" },
                new Employee() {Id = 3, firstName = "Mark", lastName = "Ruffalo" },
                new Employee() {Id = 4, firstName = "Chris", lastName = "Hemsworth" },
                new Employee() {Id = 5, firstName = "Scarlett", lastName = "Johansson"},
                new Employee() {Id = 6, firstName = "Jeremy", lastName = "Renner"},
                new Employee() {Id = 7, firstName = "Don", lastName = "Cheadle"},
                new Employee() {Id = 8, firstName = "Scarlett", lastName = "Paltrow"},
                new Employee() {Id = 9, firstName = "Jon", lastName = "Favreau"},
                new Employee() {Id = 10, firstName = "Bradley", lastName = "Cooper"}
            };

            List<Employee> chris = new List<Employee>();
            foreach (Employee employee in actors)
            {
                if (employee.firstName == "Chris")
                {
                    chris.Add(employee);
                }
            }

            List<Employee> chris2 = actors.Where(x => x.firstName == "chris").ToList();

            List<Employee> bigid = actors.Where(x => x.Id > 5).ToList();

            Console.ReadLine();
        }
    }
}