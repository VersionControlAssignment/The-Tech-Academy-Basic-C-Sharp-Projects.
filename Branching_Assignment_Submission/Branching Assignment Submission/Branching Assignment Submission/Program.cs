using System;

namespace Branching_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. requirement.
            string greeting = "Welcome to Package Express. Please follow the instructions below.";
            Console.WriteLine(greeting);

            //2. requirement.
            Console.Write("Please enter the package weight:");
            double weight = double.Parse(Console.ReadLine());

            //3. requirement.
            if (weight > 50)
            {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            //4. requirement.
            Console.Write("Please enter the package width:");
            double width = double.Parse(Console.ReadLine());

            if (width > 50)
            {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            }

            //5. requirement.
            Console.Write("Please enter the package height:");
            double height = double.Parse(Console.ReadLine());

            if (height > 50)
            {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            }

            //6. requirement.
            Console.Write("Please enter the package length:");
            double length = double.Parse(Console.ReadLine());

            if (length > 50)
            {
            //7. requirement.
            Console.WriteLine("Package too big to be shipped via Package Express.");
            }

            //8. requirement.
            double product = width * height * length * weight / 100;
            Console.WriteLine("Your estimated total for shipping this package is: " + "$" + product);
            Console.ReadLine();

            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}