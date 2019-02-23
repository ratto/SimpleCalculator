using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

/* This class will provide the methods for the 4 basic 
 * operations
 */

namespace SimpleCalculator {
    class SimpleOperators {
        static private double Number;

        static public double Sum(double n) {
            Number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return (n) + (Number);
        }

        static public double Subtract(double n) {
            Number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return (n) - (Number);
        }

        static public double Multiply(double n) {
            Number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return (n) * (Number);
        }

        static public double Divide(double n) {
            Number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return (n) / (Number);
        }
    }
}
