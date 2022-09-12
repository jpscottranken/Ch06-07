using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH7CalculatorConsole01
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number1 = 0m;
            string number1Str;
            decimal number2 = 0m;
            string number2Str;
            decimal result = 0m;
            string operation;
            string op = "";
            bool success = false;
            bool answer;

            while (1 == 1)
            {
                Console.Clear();
                Console.Write("Enter number 1: ");
                number1Str = Console.ReadLine();
                //  Verify there is something input
                if (number1Str.Trim() == "")
                {
                    Console.WriteLine("Nothing Input For Number 1");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    answer = Decimal.TryParse(number1Str, out number1);
                    if (!answer)
                    {
                        Console.WriteLine("Non-Numeric Input For Number 1");
                        Console.ReadLine();
                        return;
                    }
                }

                Console.WriteLine("The value of number1 is: " + number1.ToString());
                //number1 = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter number 2: ");
                number2Str = Console.ReadLine();
                //  Verify there is something input
                if (number2Str.Trim() == "")
                {
                    Console.WriteLine("Nothing Input For Number 2");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    answer = Decimal.TryParse(number2Str, out number2);
                    if (!answer)
                    {
                        Console.WriteLine("Non-Numeric Input For Number 2");
                        Console.ReadLine();
                        return;
                    }
                }

                Console.WriteLine("The value of number2 is: " + number2.ToString());

                success = false;

                while (!success)
                {   //  Begin while
                    operation = "\n\nEnter a 1 to do an addition\n";
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
