using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documentation
{
    /// <summary>
    /// This is the calculator class
    /// </summary>
    /// <remarks>
    /// It only contains class for adding two numbers
    /// </remarks>
    class Calculator
    {
        /// <summary>Gets the value of PI </summary>
        public static double PI { get;}

        /// <summary>
        /// Adds two doubles, and returns the result
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>The sum of the two provided numbers</returns>
        /// <example>
        /// <code>
        /// double c = Calculator.Add(1, 4);
        /// </code>
        /// </example>
        public double AddWhoNumbers(double a, double b)
        {
            return a + b;
        }


    }
}
