using System;
using System.Net.NetworkInformation;
using System.Threading;

/*
 *      Create a simple calculator program
 *      that has no extra methods
 */

namespace Ch6CalculatorConsole01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal number1;
            decimal number2;
            decimal result = 0;
            string  operation;
            string  op = "";
            bool    success = false;

            while (1 == 1)
            {
                Console.Clear();
                Console.Write("Enter number 1: ");
                number1 = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter number 2: ");
                number2 = Convert.ToDecimal(Console.ReadLine());
                success = false;

                while (!success) 
                {   //  Begin while
                    operation  = "\n\nEnter a 1 to do an addition\n";
                    operation += "Enter a 2 to do a subtraction\n";
                    operation += "Enter a 3 to do a multiplication\n";
                    operation += "Enter a 4 to do a division\n";
                    operation += "Enter a 5 to do a modulus\n\n";
                    operation += "Enter a 1, 2, 3, 4, of 5 now: ";

                    Console.Write(operation);
                    op = Console.ReadLine();

                    if ((op != "1") && (op != "2") && (op != "3") &&
                        (op != "4") && (op != "5"))
                    {
                        success = false;
                    }
                    else
                    {
                        success = true;
                    }

                }   //  End while

                if (op == "1")
                {
                    result = number1 + number2;
                }
                else if (op == "2")
                {
                    result = number1 - number2;
                }
                else if (op == "3")
                {
                    result = number1 * number2;
                }
                else if (op == "4")
                {
                    result = number1 / number2;
                }
                else if (op == "5")
                {
                    result = number1 % number2;
                }
                else
                {
                    Console.WriteLine("Illegal Operator");
                }

                Console.WriteLine("The result is: " + result.ToString("n2"));

                Console.ReadLine();
            }
        }
    }
}
