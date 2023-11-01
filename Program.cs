namespace BasicCalculatorAssignment
{
    internal class Program
    {
        // The goal of this assignment is to learn how to create and use methods in our code
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("-----------------");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an operation: ");

                // Task 1. 
                int choice = Convert.ToInt32(Console.ReadLine());
                // Task 2. 
                if (choice == 5)
                {
                    Console.WriteLine("Exit");
                    break; 
                }
                     
                // Task 3. 
                double firstNumber;
                Console.Write("Enter the first number: ");
                {
                    string userInput = Console.ReadLine();
                    firstNumber = Convert.ToDouble(userInput);
                }
                // Task 4. 
                double secondNumber;
                Console.Write("Enter second number: ");
                {
                    string userInput = Console.ReadLine();
                    secondNumber = Convert.ToDouble(userInput);
                }
                // Task 5. Create double variable for default result value and assign it to be 0
                double result = 0;
                // Task 6. 
                // Task 6.1 
                
                switch (choice)
                {
                    case 1:
                        result = Add(firstNumber, secondNumber);
                        break;
                    case 2:
                        result = Subtract(firstNumber, secondNumber);
                        break;
                    case 3:
                        result = Multiply(firstNumber, secondNumber);
                        break;
                    case 4:
                        if (secondNumber != 0)
                        {
                            result = Divide(firstNumber, secondNumber);
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose a valid operation.");
                        break;
                }

                Console.WriteLine("Result: " + result);
            }
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
            // Task 7. Print out the result
        }
        }

        
    }
