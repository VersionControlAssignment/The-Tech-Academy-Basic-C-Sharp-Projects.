using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Assignment_Submission
{
    public class Employee : Person, IQuittable
    {
        public int ID { get; set; }
        public void SayName(string firstname, string lastname)
        {
            Console.WriteLine(firstname + " " + lastname);
        }
        public void Quit()
        {

        }
    }
}