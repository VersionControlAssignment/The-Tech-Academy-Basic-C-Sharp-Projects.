using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Id = 1;
            employee1.FirstName = "Chris";
            employee1.LastName = "Evans";

            Employee employee2 = new Employee();
            employee2.Id = 1;
            employee2.FirstName = "Jon";
            employee2.LastName = "Favreau";

            if (employee2 == employee2)
            {
                Console.WriteLine("employee is equal to employee2");
            }
            else
            {
                Console.WriteLine("employee1 is not equal to employee2");
            }
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string FirstName { get; internal set; }
        public string Lastname { get; set; }
        public string LastName { get; internal set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.Id.Equals(employee2.Id))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (!employee1.Id.Equals(employee2.Id))
            {
                return true;
            }
            return false;
        }
    }
}