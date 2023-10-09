using System;
using System.Collections.Generic;
using System.Linq;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee actors = new Employee();
            actors.actors = new List<Employee>();
            Employee actors = new Employee();
            actors.FirstName = "Chris";
            actors += FirstName;
            actors -= FirstName;
            actors == Firstname;
            actors != FirstName;


            //Overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property.
            //Remember that comparison operators must be overloaded in pairs. 
            List<Employee> actors = new List<Employee>()
            {
                new Employee() {Id = 1, FirstName = "Robert", LastName = "Downey Jr." },
                new Employee() {Id = 2, FirstName = "Chris", LastName = "Evans" },
                new Employee() {Id = 3, FirstName = "Mark", LastName = "Ruffalo" },
                new Employee() {Id = 4, FirstName = "Chris", LastName = "Hemsworth" },
                new Employee() {Id = 5, FirstName = "Scarlett", LastName = "Johansson"},
                new Employee() {Id = 6, FirstName = "Jeremy", LastName = "Renner"},
                new Employee() {Id = 7, FirstName = "Don", LastName = "Cheadle"},
                new Employee() {Id = 8, FirstName = "Scarlett", LastName = "Paltrow"},
                new Employee() {Id = 9, FirstName = "Jon", LastName = "Favreau"},
                new Employee() {Id = 10, FirstName = "Bradley", LastName = "Cooper"}
            };

            List<Employee> chris = new List<Employee>();
            foreach (Employee employee in actors)
            {
                if (employee.FirstName == "Chris")
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