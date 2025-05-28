using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Method
    {
        public void Calculate(string name, int number1, int number2, string oprator, int result)
        {
            Console.WriteLine($"{name}:{number1} {oprator} {number2} = {result}");
        }

        public int GetNumber(string numberOrder)
        {
            Console.Write($"Please Enter {numberOrder} number:");
            return int.Parse(Console.ReadLine());
        }
    }
}
