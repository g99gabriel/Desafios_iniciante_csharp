using System.Data;
using System.Reflection.Emit;

namespace CalculatorApp
{
     public class CalculatorApp
    {
       static void Main(string[] args)
        {
            bool reboot = true;
            do 
            {     
                    Console.WriteLine("Welcome to the Calculator App!");
                    Console.WriteLine("Select an operation:");
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Division");
                    Console.WriteLine("0. Exit");

                    int choice= Convert.ToInt32(Console.ReadLine());
                    double num1, num2, result;

                    switch (choice)
                    {
                        case 0:
                            Console.WriteLine("Exiting the app!");
                            break;
                        
                        case 1: 
                            Console.WriteLine("Enter two numbers to add: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            num2 = Convert.ToDouble(Console.ReadLine());
                            result = num1 + num2;
                            Console.WriteLine($"Result: {result}");
                            break;
                        case 2:
                            Console.WriteLine("Enter two numbers to add: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            num2 = Convert.ToDouble(Console.ReadLine());
                            result = num1 - num2;
                            Console.WriteLine($"Result : {result}");
                            break;

                        case 3:
                        Console.WriteLine("Enter two numbers to add: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            num2 = Convert.ToDouble(Console.ReadLine());
                            result = num1 * num2;
                            Console.WriteLine($"Result : {result}");
                            break;
                        case 4:
                            Console.WriteLine("Enter two numbers to add: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            num2 = Convert.ToDouble(Console.ReadLine());
                            result = num1 / num2;
                            Console.WriteLine($"Result : {result}");
                            if (num1 == 0 || num2 == 0)
                            {
                                Console.WriteLine("It's not possible divide by 0");
                            }
                            break;
                    }
                    Console.WriteLine("Press Enter for return in menu..");
                    ConsoleKeyInfo keyEnter = Console.ReadKey();
                    if (keyEnter.Key == ConsoleKey.Escape)
                {
                    reboot = false;
                }
            }  
            while (reboot);
            Console.WriteLine("\nPrograma Encerrado, Até logo!");

                
            
        }
     
    }  
}

    
