using System;

namespace Class_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method of the console app, instantiate the class.
            VoidMethod math = new VoidMethod();
            
            Console.WriteLine("Type a number:");
            int dividend = Convert.ToInt32(Console.ReadLine());
            math.MathOp(dividend);
            Console.WriteLine(math.Value);
            Console.ReadLine();

            //Call the method in the class, passing in two numbers. 
            Console.WriteLine("Please write your text:");
            string input = Console.ReadLine();
            string phrase = math.StringCounter(input, out int count);
            Console.WriteLine(phrase);
            Console.WriteLine("Double would be: " + (count * 2));
            Console.ReadLine();

            //Call the method in the class, specifying the parameters by name.
            Console.WriteLine("Please write you text:");
            string input2 = Console.ReadLine();
            int phrase2_len = math.StringCounter(input2);
            Console.WriteLine("This text is " + phrase2_len + " characters long");
            Console.ReadLine();
            
            Console.WriteLine("Please write you text:");
            string input3 = Console.ReadLine();
            int i_count = VoidMethod.IFinder(input3);
            Console.WriteLine("This text has " + i_count + " i's in it.");
            Console.ReadLine();
        }
    }
}