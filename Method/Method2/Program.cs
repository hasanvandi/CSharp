using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isEven(8));
            Console.ReadLine();
        }
        //زوج یا فرد بودن عدد 
        public static bool isEven(int number)
        {
          if(number % 2 == 0)
            {
                return true;
            }
          return false;
        }
    }
}
