using System;

namespace OperatorsAssignment
{
    //Create an Employee class with Id, FirstName and LastName properties. 
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static Employee operator+ (Employee actors, Employee FirstName)
        {
            actors.Employee.Add(actors);
            return actors;
        }
        public static Employee operator- (Employee actors, Employee FirstName)
        {
            actors.Employee.Remove(actors);
            return actors;
        }
        public static Employee operator== (Employee actors, Employee FirstName)
        {
            actors.Employee.Remove(actors);
            return actors;
        }
        public static Employee operator!= (Employee actors, Employee FirstName)
        {
            actors.Employee.Remove(actors);
            return actors;
        }
    }
}