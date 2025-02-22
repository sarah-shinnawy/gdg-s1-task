using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.Write("Enter the first number: ");
                int num1;
                while (!int.TryParse(Console.ReadLine(), out num1))
                {
                    Console.Write("Invalid input. Please enter a valid integer: ");
                }

                Console.Write("Enter the second number: ");
                int num2;
                while (!int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.Write("Invalid input. Please enter a valid integer: ");
                }

                Console.Write("Enter operation: add (+), subtract (-), multiply (*), divide (/): ");
                string operation = Console.ReadLine()!;

                int result = 0;
                bool validOperation = true;

                switch (operation)
                {
                    case "+":
                        result = AddNumbers(num1, num2);
                        break;
                    case "-":
                        result = SubtractNumbers(num1, num2);
                        break;
                    case "*":
                        result = MultiplyNumbers(num1, num2);
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            validOperation = false;
                        }
                        else
                        {
                            result = DivideNumbers(num1, num2);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation. Please enter +, -, *, or /.");
                        validOperation = false;
                        break;
                }

                if (validOperation)
                {
                    Console.WriteLine($"Result: {result}");
                }

                Console.WriteLine("\nPress '5' to exit or any other key to continue.");
                string input = Console.ReadLine()!;
                choice = (input == "5") ? 5 : 0;

            } while (choice != 5);

            Console.WriteLine("Exiting the calculator.");
        }

        static int AddNumbers(int num1, int num2) => num1 + num2;
        static int SubtractNumbers(int num1, int num2) => num1 - num2;
        static int MultiplyNumbers(int num1, int num2) => num1 * num2;
        static int DivideNumbers(int num1, int num2) => num1 / num2;
    }
}
