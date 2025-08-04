using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        bool continueChecking = true;
        
        Console.WriteLine("Triangle Type Identifier");
        Console.WriteLine("------------------------");
        
        while (continueChecking)
        {
            Console.WriteLine("\nEnter lengths of three sides of a triangle in centimetres (or 'Q' to quit):");
            
b             Console.Write("Side 1 (or 'Q' to quit): ");
            string input = Console.ReadLine();
            if (input.ToUpper() == "Q")
            {
                continueChecking = false;
                Console.WriteLine("\nThank you for using the Triangle Type Identifier. Goodbye!");
                break;
            }
            
            double side1 = GetPositiveNumber(input);
            
            Console.Write("Side 2: ");
            double side2 = GetPositiveNumber();
            
            Console.Write("Side 3: ");
            double side3 = GetPositiveNumber();
            
            if (IsValidTriangle(side1, side2, side3))
            {
                string triangleType = DetermineTriangleType(side1, side2, side3);
                Console.WriteLine($"\nThis is a {triangleType} triangle.");
            }
            else
            {
                Console.WriteLine("\nThese sides do not form a valid triangle.");
            }
        }
    }

    static double GetPositiveNumber(string initialInput = null)
    {
        while (true)
        {
            if (initialInput != null)
            {
                if (double.TryParse(initialInput, out double number) && number > 0)
                {
                    initialInput = null; 
                    return number;
                }
                Console.Write("Invalid input. Please enter a positive number: ");
                initialInput = null; 
            }
            
            if (double.TryParse(Console.ReadLine(), out double num) && num > 0)
            {
                return num;
            }
            Console.Write("Invalid input. Please enter a positive number: ");
        }
    }

    static bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

    static string DetermineTriangleType(double a, double b, double c)
    {
        if (Math.Abs(a - b) < 0.001 && Math.Abs(b - c) < 0.001) 
        {
            return "Equilateral";
        }
        if (Math.Abs(a - b) < 0.001 || Math.Abs(a - c) < 0.001 || Math.Abs(b - c) < 0.001)
        {
            return "Isosceles";
        }
        return "Scalene";
    }
}