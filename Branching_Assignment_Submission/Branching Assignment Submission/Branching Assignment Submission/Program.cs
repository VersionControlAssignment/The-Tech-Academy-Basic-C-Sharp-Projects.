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
            double num1 = double.Parse(Console.ReadLine());

            //3. requirement.
            if (num1 > 50)
            {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            Console.ReadLine();
            Environment.Exit(0);
            }

            //4. requirement.
            Console.Write("Please enter the package width:");
            double num2 = double.Parse(Console.ReadLine());

            if (num2 > 50)
            {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            Console.ReadLine();
            Environment.Exit(0);
            }

            //5. requirement.
            Console.Write("Please enter the package height:");
            double num3 = double.Parse(Console.ReadLine());

            if (num3 > 50)
            {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            Console.ReadLine();
            Environment.Exit(0);
            }

            //6. requirement.
            Console.Write("Please enter the package length:");
            double num4 = double.Parse(Console.ReadLine());

            if (num4 > 50)
            {
            //7. requirement.
            Console.WriteLine("Package too big to be shipped via Package Express.");
            Console.ReadLine();
            Environment.Exit(0);
            }

            //8. requirement.
            double product = num1 * num2 * num3 * num4 / 100;
            Console.WriteLine("Your estimated total for shipping this package is: " + "$" + product);
            Console.ReadLine();

            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}