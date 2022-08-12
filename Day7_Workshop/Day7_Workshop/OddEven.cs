using System;
using System.Collections.Generic;
using System.Text;

namespace Day7_Workshop
{
    class OddEven
    {
        public void Oddeven()
        {
            Console.WriteLine("Enter first number");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            if (numOne % 2 == 0)
            {
                Console.WriteLine("Entered number num1 is even");

            }
            else
            {
                Console.WriteLine("Entered number num1 is odd");
            }
            if (numTwo % 2 == 0)
            {
                Console.WriteLine("Entered number num2 is even");
            }
            else
            {
                Console.WriteLine("Entered number num2 is odd");
            }
        }
    }
}
