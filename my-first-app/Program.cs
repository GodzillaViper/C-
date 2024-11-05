using System;

class Program
{
    static void Main()
    {
        
        //Console.Write("Enter the first number: ");
        //double num1 = double.Parse(Console.ReadLine());

        //Console.Write("Enter the second number: ");
        //double num2 = double.Parse(Console.ReadLine());

        
        //Console.WriteLine("Addition: " + (num1 + num2));
        //Console.WriteLine("Subtraction: " + (num1 - num2));
        //Console.WriteLine("Multiplication: " + (num1 * num2));

        //Console.WriteLine(num2 != 0 ? "Division: " + (num1 / num2) : "Division by zero is not allowed.");


        //uppgift 2
        //Console.Write("Enter degrees in Celsius: ");
        //double num1 = double.Parse(Console.ReadLine());

        //Console.WriteLine("Degrees in Fahrenheit:" + (num1 * 9/5 + 32));

        //uppgift 3 
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter your birthdate (YYYYMMDD): ");
        int birthDate;
        while (!int.TryParse(Console.ReadLine(), out birthDate) || birthDate < 10000101 || birthDate > 99991231)
        {
            Console.Write("Invalid input. Please enter your birthdate in YYYYMMDD format: ");
        }

        Console.Write("Enter today's date (YYYYMMDD): ");
        int currentDate;
        while (!int.TryParse(Console.ReadLine(), out currentDate) || currentDate < 10000101 || currentDate > 99991231)
        {
            Console.Write("Invalid input. Please enter today's date in YYYYMMDD format: ");
        }

        int age = (currentDate - birthDate) / 10000;

        Console.WriteLine($"Hello {firstName}, you are {age} years old.");
        

    }
}