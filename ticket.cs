using System;

namespace TicketPriceCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie Theater Ticket Price Calculator!");
            Console.WriteLine("Please enter your age:");

            string? ageInput = Console.ReadLine();
            int age;

            try
            {
                age = Convert.ToInt32(ageInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid age (a whole number).");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number you entered is too large or too small. Please enter a realistic age.");
                return;
            }

            if (age < 0)
            {
                Console.WriteLine("Age cannot be negative. Please enter a valid age.");
                return;
            }

            const decimal REGULAR_PRICE = 10.00m;
            const decimal DISCOUNT_PRICE = 7.00m;

            decimal ticketPrice;

            if (age >= 65 || age <= 12)
            {
                ticketPrice = DISCOUNT_PRICE;
            }
            else
            {
                ticketPrice = REGULAR_PRICE;
            }

            Console.WriteLine($"The ticket price is: GHC{ticketPrice:F2}");

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
