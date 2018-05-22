using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me two numbers:\nNumber one: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("\nSecond number: ");
            double b = double.Parse(Console.ReadLine());

            var calculator = new Calculator();
            double answer = calculator.AddWhoNumbers(a, b);
            Console.WriteLine("\n1st and 2nd number added together: " + answer);
            Console.WriteLine("***");

            Console.ReadLine();


        }
    }
}
