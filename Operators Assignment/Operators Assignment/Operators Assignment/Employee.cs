using System;

namespace OperatorsAssignment
{
    //Create an Employee class with Id, FirstName and LastName properties. 
    public class Employee
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public static Employee operator+ (Employee actors, Employee firstName)
        {
            actors.Employee.Add(actors);
            return actors;
        }
        public static Employee operator- (Employee game, Employee firstName)
        {
            game.Employee.Remove(actors);
            return game;
        }
    }
}