using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter side A: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side B: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side C: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Triangle inequality validation
        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }
        else
        {
            Console.WriteLine("The given sides do not form a valid triangle.");
        }
    }
}