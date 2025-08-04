using System;

class GradeCalculator
{
    static void Main()
    {
        bool continueCalculating = true;
        
        Console.WriteLine("Grade Calculator");
        Console.WriteLine("----------------");
        
        while (continueCalculating)
        {
            Console.Write("Enter numerical grade (0-100) or 'Q' to quit: ");
            string input = Console.ReadLine();
            
            // Check if user wants to quit
            if (input.ToUpper() == "Q")
            {
                continueCalculating = false;
                Console.WriteLine("Goodbye!");
                continue;
            }
            
            // Try to parse the grade
            if (int.TryParse(input, out int grade))
            {
                if (grade >= 0 && grade <= 100)
                {
                    string letterGrade = GetLetterGrade(grade);
                    Console.WriteLine($"Letter grade: {letterGrade}\n");
                }
                else
                {
                    Console.WriteLine("Grade must be between 0 and 100.\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0-100 or 'Q' to quit.\n");
            }
        }
    }

    static string GetLetterGrade(int grade)
    {
        if (grade >= 90) return "A";
        if (grade >= 80) return "B";
        if (grade >= 70) return "C";
        if (grade >= 60) return "D";
        return "F";
    }
}