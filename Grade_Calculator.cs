using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nSelect an Application:");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Exit");

            Console.Write("Enter your choice (1-2): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GradeCalculator();
                    break;
                case "2":
                    Console.WriteLine("Exiting... Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid input. Please select a valid option.");
                    break;
            }
        }
    }

    static void GradeCalculator()
    {
        Console.Write("\nEnter a numerical grade (0-100): ");
        if (int.TryParse(Console.ReadLine(), out int grade))
        {
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Grade must be between 0 and 100.");
                return;
            }

            string letterGrade;
            if (grade >= 90) letterGrade = "A";
            else if (grade >= 80) letterGrade = "B";
            else if (grade >= 70) letterGrade = "C";
            else if (grade >= 60) letterGrade = "D";
            else letterGrade = "F";

            Console.WriteLine($"Letter Grade: {letterGrade}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
