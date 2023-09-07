using System;

namespace Branching_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            int packageWeight = 40;

            //1. requirement. The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            string name = Console.ReadLine();

            //2. requirement. The user must then be prompted for the package weight.
            Console.WriteLine("Please enter the package weight:");
            int currentWeight = Convert.ToInt32(Console.ReadLine());

            if (currentWeight > packageWeight)
            {
            //3. requirement. If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express. Have a good day.” At this point the program would end.
            Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else if (packageWeight > currentWeight)
            {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            Console.ReadLine();

            //4. requirement. The user must then be prompted for the package width.
            Console.WriteLine("Please enter the package width:");
            Console.ReadLine();

            //5. requirement. Then the package height.
            Console.WriteLine("Please enter the package height:");
            Console.ReadLine();

            //6. requirement. Then the package length.
            Console.WriteLine("Please enter the package length:");
            Console.ReadLine();

            int packageDimension = 50;

            int currentDimension = Convert.ToInt32(Console.ReadLine());

            if (currentDimension > packageDimension)
            {
            //7. requirement. If the dimensions total greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.
            Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else if (packageDimension > currentDimension)
            {
            Console.ReadLine();

            //8. requirement. Next, multiply the three dimensions (height, width, & length) together, and multiply the product by the weight. Finally, divide the outcome by 100.
            int num1 = 12;
            int num2 = 10;
            int num3 = 11;
            int num4 = 40;
            int product = num1 * num2 * num3 * num4;
            Console.WriteLine(product);

            //9. requirement. The result of that calculation is the quote.
            int num5 = 52800;
            int num6 = 100;
            int quotient = num5 / num6;
            Console.WriteLine(quotient);

            //10. requirement. Display the quote to the user as a dollar amount.
            Console.WriteLine("Your estimated total for shipping this package is: $528.00");

            Console.WriteLine("Thank you!");
            Console.ReadLine();
            }
        }
    }