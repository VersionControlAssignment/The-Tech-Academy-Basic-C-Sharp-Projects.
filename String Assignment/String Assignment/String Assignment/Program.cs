using System;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jesse";
            string quote = "Bob said, \"Hello\", Jesse. \n Hello on a new line. \n \t Hello on a tab.";
            string fileName = "C:\\Users\\Jesse";

            name = name.ToUpper();

            Console.WriteLine(quote);
            Console.WriteLine(name);
            Console.ReadLine();

            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Jesse");

            //Console.WriteLine(sb);
            //Console.ReadLine();
        }
    }
}