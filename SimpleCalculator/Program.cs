using System;
using System.Globalization;

/*
 * This is a simple calculator exercise to workout C# skills.
 * In this version I just wanted to make a first commit to keep
 * on working. For now I will keep the code simple and silly, but
 * I will enhance this code later. My worry for now is on leaving
 * this first version working properly.
 */

namespace SimpleCalculator {
    class Program {
        static void Main(string[] args) {
            double result = 0;
            double number;
            String oper;

            Console.WriteLine("Simple Calculator");
            number = double.Parse(Console.ReadLine());
            oper = Console.ReadLine();

            // For now is just inputing one number, hitting enter and so on
            if (oper == "+") {
                result = SimpleOperators.Sum(number);
            } else if(oper == "-") {
                result = SimpleOperators.Subtract(number);
            } else if (oper == "*" || oper == "x") {
                result = SimpleOperators.Multiply(number);
            } else if (oper == "/") {
                result = SimpleOperators.Divide(number);
            } else {
                Console.WriteLine("Error");
            }

            Console.WriteLine(result);
        }
    }
}
