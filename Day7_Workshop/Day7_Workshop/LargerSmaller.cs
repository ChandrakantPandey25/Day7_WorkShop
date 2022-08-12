using System;
using System.Collections.Generic;
using System.Text;

namespace Day7_Workshop
{
    class LargerSmaller
    {
        public void Largersmaller()
        {
            Console.WriteLine("Enter first number");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            if (numOne > numTwo)
            {
                Console.WriteLine("Larger number is:" + numOne);
                Console.WriteLine("Smaller number is:" + numTwo);
            }
            else
            {
                Console.WriteLine("Larger number is:" + numTwo);
                Console.WriteLine("Smaller number is:" + numOne);
            }
        }
    }
}
