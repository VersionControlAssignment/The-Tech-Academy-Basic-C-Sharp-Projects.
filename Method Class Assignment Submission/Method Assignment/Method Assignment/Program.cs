using System;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method of the console app, instantiate the class.
            MathOperation1 mathOp = new MathOperation1();

            //Call the method in the class, passing in two numbers. 
            Console.WriteLine("Enter an integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //Call the method in the class, specifying the parameters by name.
            Console.WriteLine("Enter a second integer, or just press enter: ");
            try
            {
                
                int num2 = Convert.ToInt32(Console.ReadLine());
                int results = mathOp.MathOperation(num1, num2);
                Console.WriteLine(num1 + " x " + num2 + " = " + results);
            }
            catch
            {
                
                int results = mathOp.MathOperation(num1);
                Console.WriteLine(num1 + " x Default 1 = " + results);
            }
            Console.ReadLine();
        }
    }
}