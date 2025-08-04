using System;

class TicketPriceCalculator
{
    static void Main()
    {
        bool continueCalculating = true;
        
        Console.WriteLine("Ticket Price Calculator");
        Console.WriteLine("------------------------");
        
        while (continueCalculating)
        {
            Console.Write("Enter your age (or 'Q' to quit): ");
            string input = Console.ReadLine();
            
            // Check if user wants to quit
            if (input.ToUpper() == "Q")
            {
                continueCalculating = false;
                Console.WriteLine("Thank you for using the Ticket Price Calculator. Goodbye!");
                continue;
            }
            
            // Try to parse the age
            if (int.TryParse(input, out int age))
            {
                if (age > 0 && age <= 120)  // Reasonable age validation
                {
                    decimal price = CalculateTicketPrice(age);
                    Console.WriteLine($"Ticket price: GHC{price}\n");
                }
                else
                {
                    Console.WriteLine("Please enter a valid age between 1-120.\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age or 'Q' to quit.\n");
            }
        }
    }

    static decimal CalculateTicketPrice(int age)
    {
        const decimal regularPrice = 10m;
        const decimal discountedPrice = 7m;
        
        if (age <= 12 || age >= 65)
        {
            return discountedPrice;
        }
        return regularPrice;
    }
}