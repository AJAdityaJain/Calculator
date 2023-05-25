using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {

                Calculator Maths = new Calculator();

                string operators = Maths.AskOp();
                double num1 = Maths.AskNum("first");
                double num2 = Maths.AskNum("second");
                double answer = Maths.Calulate(num1, num2, operators);
                string strnum1 = Convert.ToString(num1);
                string strnum2 = Convert.ToString(num2);
                string y_n;

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(strnum1 + operators + strnum2 + '=');
                
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(answer);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("If you want to continue type (y)es otherwise (n)o..");
                Console.Beep();
                y_n = Console.ReadLine();
                
                if(y_n == "y" || y_n == "yes")
                {
                    repeat = true;
                    Console.Beep();
                    Console.Clear();
                }
                else
                {
                    repeat = false;
                    Environment.Exit(0);
                }
            }
        }
    }
}
