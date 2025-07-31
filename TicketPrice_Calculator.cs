using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            double ticketPrice;

            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7.00;
                Console.WriteLine("You are eligible for a discounted ticket.");
            }
            else
            {
                ticketPrice = 10.00;
            }

            Console.WriteLine($"Your ticket price is: GHC{ticketPrice:F2}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric age.");
        }
    }
}