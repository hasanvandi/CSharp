using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Method method = new Method();
            int num01 = method.GetNumber("First");
            int num02 = method.GetNumber("Secound");
            Console.WriteLine();

  
            Console.WriteLine("sum[a,A,+]");
            Console.WriteLine("sub[-, s, S]");
            Console.WriteLine("mult[*,M,m]");
            Console.WriteLine("Div[/,D,d]");
            Console.WriteLine("Which one?");
            string userInput = Console.ReadLine();


            if (userInput == "+" || userInput == "a" || userInput == "A")
            {
                method.Calculate("Add", num01, num02, "+", num01 + num02);
            }
            else if (userInput == "-" || userInput == "S" || userInput == "s")
            {
                method.Calculate("Subtract", num01, num02, "-", num01 + num02);
            }
            else if (userInput == "*" || userInput == "M" || userInput == "m")
            {
                method.Calculate("Multiply", num01, num02, "*", num01 + num02);
            }
            else
            {
                Console.WriteLine("Please enter the oprator correctly.");
            }


            Console.ReadLine();
        }
 
    }
    
}
