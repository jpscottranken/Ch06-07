using System;

/*
 *      Create a simple calculator program
 *      that has extra methods
 */

namespace Ch6CalculatorConsole02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Declaring and initializing local program variables
            decimal number1  = 0;
            decimal number2  = 0;
            decimal result   = 0;
            string operation = "";
            string op        = "";
            bool success     = false;

            while (1 == 1)      //  Infinite loop on purpose
            {
                number1 = inputNumber("1");
                number2 = inputNumber("2");

                success = false;

                while (!success)
                {   //  Begin while
                    operation = selectOperation();

                    success = determineSuccess(op);
                }   //  End while

                result = determineResult(number1, number2, op);

                displayOutput(result);

                Console.ReadLine();
            }
        }

        static string selectOperation()
        {
            string operation = "";
            string op = "";
            operation = "\n\nEnter a 1 to do an addition\n";
            operation += "Enter a 2 to do a subtraction\n";
            operation += "Enter a 3 to do a multiplication\n";
            operation += "Enter a 4 to do a division\n";
            operation += "Enter a 5 to do a modulus\n\n";
            operation += "Enter a 1, 2, 3, 4, of 5 now: ";

            Console.Write(operation);
            op = Console.ReadLine();

            return op;
        }

        static bool determineSuccess(string op)
        {
            bool retVal = true;

            if ((op != "1") && (op != "2") && (op != "3") &&
                (op != "4") && (op != "5"))
            {
                retVal = false;
            }

            return retVal;
        }

        static decimal inputNumber(string s)
        {
            Console.Clear();
            Console.Write("Enter number " + s + ":");
            decimal number = Convert.ToDecimal(Console.ReadLine());
            return number;
        }

        static decimal determineResult(decimal number1, decimal number2, string op)
        {
            decimal result = 0m;

            if (op == "1")
            {
                result = add2(number1, number2);
            }
            else if (op == "2")
            {
                result = sub2(number1, number2);
            }
            else if (op == "3")
            {
                result = prod2(number1, number2);
            }
            else if (op == "4")
            {
                result = div2(number1, number2);
            }
            else if (op == "5")
            {
                result = mod2(number1, number2);
            }
            else
            {
                Console.WriteLine("Illegal Operator");
            }

            return result;
        }

        static decimal add2(decimal n1, decimal n2)
        {
            return n1 + n2;
        }
        static decimal sub2(decimal n1, decimal n2)
        {
            return n1 - n2;
        }
        static decimal prod2(decimal n1, decimal n2)
        {
            return n1 * n2;
        }
        static decimal div2(decimal n1, decimal n2)
        {
            return n1 / n2;
        }
        static decimal mod2(decimal n1, decimal n2)
        {
            return n1 % n2;
        }

        static void displayOutput(decimal result)
        {
            Console.WriteLine("The result is: " + result.ToString("n2"));
        }
    }
}

