//Andy Allaico
// Software Dev with Frameworks
// CPS 3330 03
// Unit 2 Lab assignment.
using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of integers you will give (2 or 3):");
            int amount = Convert.ToInt32(Console.ReadLine());

            if (amount == 3)
            {
                Console.WriteLine("Enter the number for a:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the number for b:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the number for c:");
                int c = Convert.ToInt32(Console.ReadLine());

                int product = Task5.Class1.CalculateProduct(a, b, c);
                Console.WriteLine($"The product of {a}, {b}, and {c} is {product}");
            }
            else
            {
                Console.WriteLine("Enter the number for a:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the number for b:");
                int b = Convert.ToInt32(Console.ReadLine());

                int product = Task5.Class1.CalculateProduct(a, b);
                Console.WriteLine($"The product of {a} and {b} is {product}");
            }
        }
    }
}
