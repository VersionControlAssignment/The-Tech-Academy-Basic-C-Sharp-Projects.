using System;

namespace Method_Assignment
{
    class MathOperation1
    {
        //Create a class. In that class, create a void method that takes two integers as parameters.
        //Have the method do a math operation on the first integer and display the second integer to the screen. 
        public int MathOperation(int i, int j = 1)
        {
            
            int result = i * j;
            return result;
        }
    }
}