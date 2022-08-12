using System;

namespace Day7_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Workshop");
            Console.WriteLine("Enter 1 to check entered number is odd or even");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    OddEven resultOne = new OddEven();
                    resultOne.Oddeven();
                    break;
                default:
                    Console.WriteLine("Enter valid number");
                    break;
            }
        }
    }
}
