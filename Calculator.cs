using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public string AskOp()
        {
            string op = "";
            bool opError = true;

            Console.WriteLine("What is the operation that needs to be performed.");
            Console.ForegroundColor = ConsoleColor.Black;

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("$ Addition $ -->  (\"+\") ", Console.BackgroundColor, Console.ForegroundColor);

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("$ Subtraction $ -->  (\"-\") ", Console.BackgroundColor, Console.ForegroundColor);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("$ Multiplication $ -->  (\"*\") ", Console.BackgroundColor, Console.ForegroundColor);

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("$ Division $ -->  (\"/\") ", Console.BackgroundColor, Console.ForegroundColor);

            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("$ Power Of $ -->  (\"^\") ", Console.BackgroundColor, Console.ForegroundColor);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            while (opError)
            {

                op = Console.ReadLine();
                Console.Beep();

                if (op!="+" && op != "-" && op != "*" && op != "/" && op != "^")
                {
                    Console.WriteLine("Try with a given operator >:[");
                    opError = true;
                    Console.Beep();
                }
                else
                {
                    opError = false;
                }

            }
            
            return op;
        }

        public double AskNum(string position)
        {
            string strnum;
            bool parseError = true;
            double num = 0;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("What is the "+position+" term", Console.BackgroundColor, Console.ForegroundColor);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            strnum = Console.ReadLine();

            Console.Beep();
            Console.WriteLine("");

            while (parseError)
            {
                if (Double.TryParse(strnum, out num) == true)
                {
                    num = Double.Parse(strnum);
                    parseError = false;
                }
                else
                {
                    Console.WriteLine("This time try with an actual number ( -_-*)");
                    strnum = Console.ReadLine();
                    Console.Beep();
                    parseError = true;
                }
            }

            return num;
        }

        public double Calulate(double num1, double num2, string op)
        {
            double answer = 0;

            switch (op)
            {
                case "+":
                    answer = num1 + num2;
                    break;

                case "-":
                    answer = num1 - num2;
                    break;

                case "*":
                    answer = num1 * num2;
                    break;

                case "/":
                    answer = num1 / num2;
                    break;

                case "^":
                    answer = Math.Pow(num1, num2);
                    break;

            }

            return answer;
        }
    }
}
