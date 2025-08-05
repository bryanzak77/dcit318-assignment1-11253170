using System;

namespace TriangleTypeIdentifierApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Triangle Type Identifier!");
            Console.WriteLine("Please enter the length of the first side:");
            string? side1Input = Console.ReadLine();
            int side1;

            // Handle input for side 1
            try
            {
                side1 = Convert.ToInt32(side1Input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input for side 1. Please enter a valid whole number.");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number entered for side 1 is too large or too small.");
                return;
            }

            Console.WriteLine("Please enter the length of the second side:");
            string? side2Input = Console.ReadLine();
            int side2;

            // Handle input for side 2
            try
            {
                side2 = Convert.ToInt32(side2Input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input for side 2. Please enter a valid whole number.");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number entered for side 2 is too large or too small.");
                return;
            }

            Console.WriteLine("Please enter the length of the third side:");
            string? side3Input = Console.ReadLine();
            int side3;

            // Handle input for side 3
            try
            {
                side3 = Convert.ToInt32(side3Input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input for side 3. Please enter a valid whole number.");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number entered for side 3 is too large or too small.");
                return;
            }

            // Validate that all sides are positive
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                Console.WriteLine("Triangle sides must be positive numbers. Please try again.");
                return;
            }

            // Check if the sides can form a valid triangle (Triangle Inequality Theorem)
            if (!((side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1)))
            {
                Console.WriteLine("The entered side lengths cannot form a valid triangle.");
                return;
            }

            // Determine the type of triangle
            string triangleType;

            if (side1 == side2 && side2 == side3)
            {
                triangleType = "Equilateral";
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                triangleType = "Isosceles";
            }
            else
            {
                triangleType = "Scalene";
            }

            Console.WriteLine($"Based on the given side lengths, the triangle is: {triangleType}");

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
